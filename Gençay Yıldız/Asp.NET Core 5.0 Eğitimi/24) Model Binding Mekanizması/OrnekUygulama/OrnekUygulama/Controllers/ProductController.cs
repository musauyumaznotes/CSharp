using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;

namespace OrnekUygulama.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            var product = new Product();
            return View(product);
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        //public IActionResult CreateProduct(string txtProductName,string txtQuantity)
        public IActionResult CreateProduct(Product product)
        {
            return View();
        }
    }
}
