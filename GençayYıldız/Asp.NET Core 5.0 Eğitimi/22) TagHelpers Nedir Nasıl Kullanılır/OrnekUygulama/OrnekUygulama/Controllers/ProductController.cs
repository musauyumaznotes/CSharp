using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;

namespace OrnekUygulama.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            ViewBag.Mesaj = "Merhaba";

            User u = new User
            {
                LastName = "gawghs ehrdsh pesegl"
            };
            return View(u);
        }
    }
}
