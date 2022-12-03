using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;

namespace OrnekUygulama.Controllers
{
    public class Model
    {
        public string txtValue1 { get; set; }
        public string txtValue2 { get; set; }
        public string txtValue3 { get; set; }
    }
    public class MyClass
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
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
        //public IActionResult VeriAl(IFormCollection datas)
        //public IActionResult VeriAl(string txtValue1, string txtValue2, string txtValue3)
        //public IActionResult VeriAl(Product model)
        public IActionResult VeriAl(MyClass model)
        {
            //var value1 = datas["txtValue1"].ToString();
            //var value2 = datas["txtValue2"];
            //var value3 = datas["txtValue3"];
            return View();
        }

    }
}
