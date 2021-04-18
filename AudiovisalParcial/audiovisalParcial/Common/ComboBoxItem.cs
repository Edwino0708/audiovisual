namespace audiovisalParcial.Common
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
