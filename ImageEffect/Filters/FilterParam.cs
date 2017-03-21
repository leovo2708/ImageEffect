using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEffect.Filters
{
    public interface FilterParam
    {
        ListBoxItem Item { get; }
        DialogResult ShowDialog();
    }
}
