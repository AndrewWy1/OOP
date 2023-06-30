namespace LinqStudy
{
    public class Product
    {
        public string Name { get; set; } = null!;
        public int Energy { get; set; }

        public override string ToString()
        {
            return $"{Name} {Energy}";
        }
    }
}
