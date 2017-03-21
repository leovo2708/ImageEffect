using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageEffect
{
    public class ListBoxItem: IComparable
    {
        public string Text { get; private set; }

        public object Value { get; private set; }

        public ListBoxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }

        public int CompareTo(object obj)
        {
            var target = (ListBoxItem)obj;
            return Text.CompareTo(target.Text);
        }
    }
}
