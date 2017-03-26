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
    public partial class BlobsFilteringUserControl : UserControl, FilterSetting
    {
        public ListBoxItem Item { get; private set; }

        protected BlobsFilteringUserControl()
        {
            InitializeComponent();
        }

        public BlobsFilteringUserControl(BlobsFiltering filter)
            :this()
        {
            minWidthNumericUpDown.Value = filter.MinWidth;
            maxWidthNumericUpDown.Value = filter.MaxWidth;
            minHeightNumericUpDown.Value = filter.MinHeight;
            maxHeightNumericUpDown.Value = filter.MaxHeight;
        }

        public ListBoxItem Save()
        {
            var minWidth = (int)minWidthNumericUpDown.Value;
            var maxWidth = (int)maxWidthNumericUpDown.Value;
            var minHeight = (int)minHeightNumericUpDown.Value;
            var maxHeight = (int)maxHeightNumericUpDown.Value;
            var filter = new BlobsFiltering(minWidth, minHeight, maxWidth, maxHeight);
            var text = $"BlobsFiltering ({minWidth}, {maxWidth} - {minHeight}, {maxHeight})";
            return new ListBoxItem(text, filter);
        }
    }
}
