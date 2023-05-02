namespace _1MayTaskHome.Models
{
    public class Color
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public List<Product> Products { get; set; }
        //public List<ColorProduct> ColorProducts { get; set; }
    }
}
