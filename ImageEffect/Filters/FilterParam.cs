using System.Windows.Forms;

namespace ImageEffect.Filters
{
    public interface FilterParam
    {
        ListBoxItem Item { get; }
        DialogResult ShowDialog();
    }
}
