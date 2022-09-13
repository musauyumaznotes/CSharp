using Microsoft.AspNetCore.Mvc;

namespace OrnekUygulama.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetProducts()
        {
            return View();
        }
    }
}
