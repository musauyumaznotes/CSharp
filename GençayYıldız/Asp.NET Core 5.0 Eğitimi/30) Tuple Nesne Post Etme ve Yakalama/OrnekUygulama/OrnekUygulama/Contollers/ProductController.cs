using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;

namespace OrnekUygulama.Contollers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            var tuple = (new Product(), new User());
            return View(tuple);
        }
        [HttpPost]
        public IActionResult CreateProduct([Bind(Prefix ="Item1")]Product product,[Bind(Prefix ="Item2")]User user)
        {
            return View();
        }


    }
}
