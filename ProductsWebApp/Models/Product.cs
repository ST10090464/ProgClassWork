namespace ProductsWebApp.Models
{
    public class Product
    {
        public string? Code { get; set; } 

        public string? Desc { get; set; }

        public double Price { get; set; }

        public Supplier? Supplier { get; set; }

        //This is a constructor, remember that constructors are methods that have same names as classes
        public Product(string? code, string? desc, double price)
        {
            Code = code;
            Desc = desc;
            Price = price;
        }
    }
}
