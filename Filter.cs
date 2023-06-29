namespace App
{
    public class Filter
    {
        public List<object> Items { get; set; }
        public Filter(List<object> items)
        {
            Items = items;
        }

        public List<string> GetStrings()
        {
            return Items.OfType<string>().ToList();
        }

        public List<char> GetChars()
        {
            return Items.OfType<char>().ToList();
        }

        public List<int> GetEventNumbers()
        {
            List<int> ints = Items.OfType<int>().ToList();
            return ints.Where(n => n % 2 == 0).ToList();
        }

        public List<double> GetDoubles()
        {
            return Items.OfType<double>().ToList();
        }

        public List<float> GetFloats()
        {
            return Items.OfType<float>().ToList();
        }

    }
}