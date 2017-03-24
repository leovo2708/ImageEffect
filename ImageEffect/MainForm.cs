using AForge.Imaging;
using AForge.Imaging.Filters;
using ImageEffect.Filters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace ImageEffect
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            LoadFilters();
            base.OnShown(e);
        }

        private void LoadFilters()
        {
            filterListBox.Enabled = false;
            var filters = new ArrayList();
            var aforgeAssembly = typeof(IFilter).Assembly;
            var filterTypes = aforgeAssembly.GetTypes().Where(type => !type.IsAbstract
                && type.GetConstructor(Type.EmptyTypes) != null
                && type.GetInterfaces().Contains(typeof(IFilter)));
            filterTypes.ToList().ForEach(type =>
            {
                var name = type.Name;
                var filter = Activator.CreateInstance(type);
                filters.Add(new ListBoxItem(name, filter));
            });
            filters.Sort();

            var customFilters = new ArrayList();
            filterTypes = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.GetInterfaces().Contains(typeof(IFilter)));
            filterTypes.ToList().ForEach(type =>
            {
                var name = type.Name;
                var filter = Activator.CreateInstance(type);
                customFilters.Add(new ListBoxItem(name, filter));
            });
            filters.InsertRange(0, customFilters);

            foreach (var filter in filters)
            {
                filterListBox.Items.Add(filter);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Please select images"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dialog.FileNames.ToList().ForEach(filePath =>
                {
                    var fileName = Path.GetFileName(filePath);
                    var image = (Bitmap)Bitmap.FromFile(filePath);
                    imageList.Images.Add(image);
                    var item = new ListViewItem();
                    item.ImageIndex = imageList.Images.Count - 1;
                    item.Text = fileName;
                    item.Tag = filePath;
                    this.imageListView.Items.Add(item);
                });
            }

            statusLabel.Text = "Load done";
        }

        public string Tesseract(Bitmap image)
        {
            //var testdataPath = @"D:\Softwares\Captcha\tessdata-3.04.00\";
            var testdataPath = @"D:\Softwares\Captcha\tesseract";
            using (var engine = new TesseractEngine(testdataPath, "eng", EngineMode.Default))
            {
                engine.SetVariable("tessedit_char_whitelist", "0123456789abcdefghijklmnopqrstuvwxyz");
                using (var page = engine.Process(image, null))
                {
                    return page.GetText().Trim();
                }
            }
        }

        public static Bitmap DrawBitmapsAlignBottom(List<Bitmap> bitmaps)
        {
            int totalWidth = 0;
            int maxHeight = 0;
            foreach (Bitmap bmp in bitmaps)
            {
                totalWidth = totalWidth + bmp.Width;
                if (maxHeight < bmp.Height)
                {
                    maxHeight = bmp.Height;
                }
            }
            Bitmap result = new Bitmap(totalWidth + 20 + (bitmaps.Count<Bitmap>() - 1) * 10, maxHeight + 20, PixelFormat.Format24bppRgb);
            int startX = 10;
            using (Graphics g = Graphics.FromImage(result))
            {
                g.FillRectangle(Brushes.Black, 0, 0, result.Width, result.Height);
                foreach (Bitmap bmp in bitmaps)
                {
                    g.DrawImage(bmp, new Point(startX, result.Height - bmp.Height - 10));
                    startX = startX + bmp.Width + 10;
                }
            }
            return result;
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            var inputImage = (Bitmap)outputPictureBox.Image;
            var text = Tesseract(inputImage);
            outputTextBox.Text = text;
            statusLabel.Text = "Decode completely";
        }

        private void filterListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (filterListBox.SelectedItem == null) return;
            filterListBox.DoDragDrop(filterListBox.SelectedItem, DragDropEffects.Move);
        }

        private void filterListBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void filterListBox_DragDrop(object sender, DragEventArgs e)
        {
            Point point = filterListBox.PointToClient(new Point(e.X, e.Y));
            int index = filterListBox.IndexFromPoint(point);
            if (index < 0) index = filterListBox.Items.Count - 1;
            object data = e.Data.GetData(typeof(ListBoxItem));
            filterListBox.Items.Remove(data);
            filterListBox.Items.Insert(index, data);
        }

        private void filterListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(filterListBox);
                selectedItems = filterListBox.SelectedItems;
                if (filterListBox.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        filterListBox.Items.Remove(selectedItems[i]);
                }
            }
        }

        private void imageListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageListView.SelectedItems.Count > 0)
            {
                var lastSelectItem = imageListView.SelectedItems[imageListView.SelectedItems.Count - 1];
                var filePath = lastSelectItem.Tag as string;
                var inputImage = (Bitmap)Bitmap.FromFile(filePath);
                inputPictureBox.Image = inputImage;
                filterListBox.Enabled = true;
            }
            else
            {
                filterListBox.Enabled = false;
            }
        }

        private void filterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterListBox.SelectedItem == null) return;
            try
            {
                statusLabel.Text = "";
                var item = (ListBoxItem)filterListBox.SelectedItem;
                var inputImage = (Bitmap)inputPictureBox.Image;
                var filter = (IFilter)item.Value;
                var outputImage = filter.Apply(inputImage);
                outputPictureBox.Image = outputImage;
            }
            catch (Exception ex)
            {
                outputPictureBox.Image = null;
                statusLabel.Text = ex.Message;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var outputImage = outputPictureBox.Image;
            if (outputImage == null)
            {
                MessageBox.Show("Output is empty");
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Title = "Save output image",
                Filter = "PNG File|*.png",
                FilterIndex = 2,
                RestoreDirectory = true,
            };
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputImage.Save(saveFileDialog.FileName);
                statusLabel.Text = "Save done";
            }
        }
    }
}
