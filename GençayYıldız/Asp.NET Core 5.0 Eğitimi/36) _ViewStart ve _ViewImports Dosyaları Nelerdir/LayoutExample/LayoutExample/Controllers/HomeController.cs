using Microsoft.AspNetCore.Mvc;

namespace LayoutExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sayfa1()
        {
            return View();
        }
        public IActionResult Sayfa2()
        {
            return View();
        }
    }
}
