using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audiovisalParcial.Utils
{
    public class ComboBoxItem
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public ComboBoxItem(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
