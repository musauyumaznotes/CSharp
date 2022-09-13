using Microsoft.AspNetCore.Mvc;

namespace CoreKitaplik2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
