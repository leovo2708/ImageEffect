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
        private ImageForm inputImageForm = null;
        private ImageForm outputImageForm = null;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            InitFiltersDropdown();
            UpdateButtonState(0);
            base.OnShown(e);
        }

        private void InitFiltersDropdown()
        {
            ArrayList q = new ArrayList();
            q.Add(new ListBoxItem("ColorFiltering", new ColorFiltering()));
            q.Add(new ListBoxItem("Invert", new Invert()));
            q.Add(new ListBoxItem("Opening", new Opening()));
            q.Add(new ListBoxItem("BlobsFiltering", new BlobsFiltering()));
            q.Add(new ListBoxItem("GaussianSharpen", new GaussianSharpen()));
            q.Add(new ListBoxItem("ContrastCorrection", new ContrastCorrection()));
            q.Sort();
            foreach (object o in q)
            {
                filterComboBox.Items.Add(o);
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
                inputListBox.Items.Clear();
                dialog.FileNames.ToList().ForEach(filePath =>
                {
                    var fileName = Path.GetFileName(filePath);
                    inputListBox.Items.Add(new ListBoxItem(fileName, filePath));
                });
                if (inputListBox.Items.Count > 0)
                {
                    inputListBox.SelectedIndex = 0;
                }
            }

            UpdateButtonState(1);
        }

        private void LoadInput(string fileName)
        {
            var image = Bitmap.FromFile(fileName);
            inputPictureBox.Image = image;
            if (autoPreprocessCheckBox.Checked)
            {
                runButton_Click(null, null);
            }
        }

        private void UpdateButtonState(int step)
        {
            if (!autoPreprocessCheckBox.Checked)
            {
                runButton.Enabled = step >= 1;
            }

            if (step == 1)
            {
                outputPictureBox.Image = null;
            }

            decodeButton.Enabled = step >= 2;
            if (step == 2)
            {
                outputTextBox.Text = "";
            }
        }

        private void inputPictureBox_Click(object sender, EventArgs e)
        {
            if (inputPictureBox.Image != null)
            {
                if (inputImageForm == null || inputImageForm.IsDisposed)
                {
                    inputImageForm = new ImageForm(inputPictureBox.Image, "Input image");
                    inputImageForm.Show(this);
                }
            }
        }

        private void outputPictureBox_Click(object sender, EventArgs e)
        {
            if (outputPictureBox.Image != null)
            {
                if (outputImageForm == null || outputImageForm.IsDisposed)
                {
                    outputImageForm = new ImageForm(outputPictureBox.Image, "Output image");
                    outputImageForm.Show(this);
                }
            }
        }

        private Bitmap Preprocessing(Bitmap inputImage)
        {
            var filters = filterListBox.Items.Cast<ListBoxItem>().Select(item => (IFilter)item.Value).ToArray();
            var seq = new FiltersSequence(filters);
            return seq.Apply(inputImage);
            //return MyEffect(inputImage);
            //return ColorRangeExtract(inputImage, 215, 16, 22, 70);
            //return BlobExtract(inputImage);
        }

        private Bitmap MyEffect(Bitmap inputImage)
        {
            Bitmap result = new Bitmap(inputImage);
            for (var i = 0; i < 7; i++)
            {
                var x = 25 * (i + 1);
                for (var j = 0; j < inputImage.Height; j++)
                {
                    var y = j;
                    result.SetPixel(x, y, Color.Black);
                }
            }
            return result;
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

        private Bitmap BlobExtract(Bitmap image)
        {
            var blobCounter = new BlobCounter()
            {
                ObjectsOrder = ObjectsOrder.XY
            };
            blobCounter.ProcessImage(image);
            Bitmap bitmap = MainForm.DrawBitmapsAlignBottom((
                from blob in (IEnumerable<Blob>)blobCounter.GetObjects(image, false)
                select blob.Image.ToManagedImage()).ToList<Bitmap>());
            return bitmap;
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

        private Bitmap ColorRangeExtract(Bitmap image, int red, int green, int blue, int delta)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    result.SetPixel(x, y, Color.Black);
                    Color pixelColor = image.GetPixel(x, y);
                    if ((red + delta < pixelColor.R ? false : red - delta <= pixelColor.R))
                    {
                        if ((green + delta < pixelColor.G ? false : green - delta <= pixelColor.G))
                        {
                            if ((blue + delta < pixelColor.B ? false : blue - delta <= pixelColor.B))
                            {
                                result.SetPixel(x, y, Color.White);
                            }
                        }
                    }
                }
            }
            return result;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            var inputImage = (Bitmap)inputPictureBox.Image;
            var outputImage = Preprocessing(inputImage);
            outputPictureBox.Image = outputImage;
            statusLabel.Text = "Preprocess completely";
            UpdateButtonState(2);
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            var inputImage = (Bitmap)outputPictureBox.Image;
            var text = Tesseract(inputImage);
            outputTextBox.Text = text;
            statusLabel.Text = "Decode completely";
        }

        private void inputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (ListBoxItem)inputListBox.SelectedItem;
            var filePath = (string)item.Value;
            LoadInput(filePath);
        }

        private void autoPreprocessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            runButton.Enabled = !autoPreprocessCheckBox.Checked;
            if (autoPreprocessCheckBox.Checked)
            {
                runButton_Click(null, null);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var item = (ListBoxItem)filterComboBox.SelectedItem;
            if (item == null)
            {
                MessageBox.Show("Please select a filter to add");
                return;
            }

            var types = Assembly.GetExecutingAssembly().GetTypes();
            var typeName = $"{item.Text}Form";
            var filterTypes = types.Where(type => type.Name == typeName);
            if (filterTypes.Count() == 1)
            {
                var type = filterTypes.First();
                var form = (FilterParam)Activator.CreateInstance(type, item.Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    filterListBox.Items.Add(form.Item);
                }
            }
            else
            {
                filterListBox.Items.Add(item);
            }
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
    }
}
