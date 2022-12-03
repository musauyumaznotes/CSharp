using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;
using OrnekUygulama.Models.ViewModels;

namespace OrnekUygulama.Controllers
{
    //Tuple : İçerisinde birden fazla değeri veriyi nesneyi referans edebilen ve semantik açıdan dilin bize kazandırdığı
    //söz dizimine sahip olan bir nesnedir.
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult GetProducts()
        {
            Product product = new Product
            {
                Id = 1,
                ProductName = "A Product",
                Quantity = 15
            };
            User user = new User
            {
                Id = 1,
                Name = "Musa",
                LastName = "Uyumaz"
            };

            //UserProduct userProduct = new UserProduct
            //{
            //    Product = product,
            //    User = user
            //};

            var userProduct = (product, user);
            return View(userProduct);
        }
    }
}
