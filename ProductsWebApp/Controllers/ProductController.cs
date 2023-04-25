using Microsoft.AspNetCore.Mvc;
using ProductsWebApp.Models;

namespace ProductsWebApp.Controllers
{
    public class ProductController : Controller
    {
        List<Product> prList = new List<Product>();
        Product pr = new Product("", "", 0);

        public ProductController()
        {
            Populate();
        }
        public IActionResult Index()
        {
            Populate();
            return View(prList);
        }

        public void Populate()
        {
            prList.Add(new Product("P123", "Milk", 5.89));
            prList.Add(new Product("P246", "Bread", 18.89));
            prList.Add(new Product("P369", "Butter", 28.89));
            prList.Add(new Product("P321", "Flour", 85.49));
            prList.Add(new Product("P789", "Meat", 115.79));
        }
    }
}
