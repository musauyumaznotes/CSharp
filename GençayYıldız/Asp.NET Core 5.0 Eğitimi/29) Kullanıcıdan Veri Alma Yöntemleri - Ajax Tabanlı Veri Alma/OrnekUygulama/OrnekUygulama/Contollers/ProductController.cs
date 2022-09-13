using Microsoft.AspNetCore.Mvc;

namespace OrnekUygulama.Contollers
{
    public class ProductController : Controller
    {
        public class AjaxData
        {
            public string A { get; set; }
            public string B { get; set; }
        }
        public IActionResult GetProducts()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VeriAl(AjaxData ajaxData)
        {
            return View();
        }
    }
}
