using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModulerTasarim.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ModulerTasarim.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Data = new List<string> {"img1.jpg", "img2.jpg", "img3.jpg" };
            object o = new object();
            return View(o);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
