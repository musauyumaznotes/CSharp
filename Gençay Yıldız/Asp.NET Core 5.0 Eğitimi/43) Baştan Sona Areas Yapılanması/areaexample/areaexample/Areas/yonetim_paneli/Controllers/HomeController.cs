using Microsoft.AspNetCore.Mvc;

namespace areaexample.Areas.yonetim_paneli.Controllers
{
    [Area("yonetim_paneli")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["data"] = "Sebebsiz boş yere ayrılacaksan..";
            return RedirectToAction("Index", "Home", new { area = "fatura_yonetimi" });
        }
    }
}
