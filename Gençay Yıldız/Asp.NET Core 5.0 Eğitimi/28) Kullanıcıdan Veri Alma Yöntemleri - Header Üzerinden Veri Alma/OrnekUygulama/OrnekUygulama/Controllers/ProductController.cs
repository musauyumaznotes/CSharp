using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;

namespace OrnekUygulama.Controllers
{
    public class ProductController : Controller
    {
        public class RouteData
        {
            public string A { get; set; }
            public string B { get; set; }
            public int Id { get; set; }
        }
        public IActionResult GetProducts()
        {
            var product = new Product();
            return View(product);
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        public IActionResult VeriAl()
        {
            var headers = Request.Headers;
            return View();
        }
    }
}
