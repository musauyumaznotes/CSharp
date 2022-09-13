using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        // GET: Default
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }
        public ActionResult About() 
        {
            var degerler = context.Hakkimizdas.ToList();
            return View(degerler);
        }
        public PartialViewResult Partial1()
        {
            var degerler = context.Blogs.OrderByDescending(x=>x.Id).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = context.Blogs.OrderBy(x => x.Id).Take(1).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = context.Blogs.OrderByDescending(x => x.Yorums.Count).Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = context.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = context.Blogs.OrderBy(x => x.Id).Take(3).ToList();
            return PartialView(deger);
        }
    }
}