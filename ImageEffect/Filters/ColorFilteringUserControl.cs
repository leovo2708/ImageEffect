using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEffect.Filters
{
    public partial class ColorFilteringUserControl : UserControl, FilterSetting
    {
        public ListBoxItem Item { get; private set; }

        protected ColorFilteringUserControl()
        {
            InitializeComponent();
        }

        public ColorFilteringUserControl(ColorFiltering filter)
            : this()
        {
            var redRange = filter.Red;
            redNumericUpDown1.Value = redRange.Min;
            redNumericUpDown2.Value = redRange.Max;
            var greenRange = filter.Green;
            greenNumericUpDown1.Value = greenRange.Min;
            greenNumericUpDown2.Value = greenRange.Max;
            var blueRange = filter.Blue;
            blueNumericUpDown1.Value = blueRange.Min;
            blueNumericUpDown2.Value = blueRange.Max;
        }

        public ListBoxItem Save()
        {
            var redRange = new AForge.IntRange((int)redNumericUpDown1.Value, (int)redNumericUpDown2.Value);
            var greenRange = new AForge.IntRange((int)greenNumericUpDown1.Value, (int)greenNumericUpDown2.Value);
            var blueRange = new AForge.IntRange((int)blueNumericUpDown1.Value, (int)blueNumericUpDown2.Value);
            var filter = new ColorFiltering(redRange, greenRange, blueRange);
            var text = $"ColorFiltering ({redRange} - {greenRange} - {blueRange})";
            return new ListBoxItem(text, filter);
        }
    }
}
