using Microsoft.AspNetCore.Mvc;

namespace OrnekUygulama.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
