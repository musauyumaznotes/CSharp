using MVCStok.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStok.Controllers
{
    public class SatisController : Controller
    {
        MvcDbStokEntities stok = new MvcDbStokEntities();
        // GET: Satis
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SatisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SatisYap(Satislar satis)
        {
            satis.CreatedAt = DateTime.Now;
            satis.IsActive = true;
            stok.Satislar.Add(satis);
            stok.SaveChanges();
            return View("Index");
        }
    }
}