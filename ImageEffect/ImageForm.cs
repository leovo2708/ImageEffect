using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEffect
{
    public partial class ImageForm : Form
    {
        protected ImageForm()
        {
            InitializeComponent();
        }

        public ImageForm(Image image, string title)
            :this()
        {
            pictureBox.Image = image;
            ClientSize = image.Size;
            Text = title;
        }
    }
}
