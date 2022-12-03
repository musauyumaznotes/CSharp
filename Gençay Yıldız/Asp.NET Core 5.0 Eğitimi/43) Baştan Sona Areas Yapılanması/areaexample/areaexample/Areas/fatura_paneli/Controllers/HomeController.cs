using Microsoft.AspNetCore.Mvc;

namespace areaexample.Areas.fatura_paneli.Controllers
{
    [Area("fatura_yonetimi")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var data = TempData["data"];
            return View();
        }
    }
}
