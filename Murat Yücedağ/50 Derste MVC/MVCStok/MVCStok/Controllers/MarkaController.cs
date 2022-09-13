using MVCStok.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStok.Controllers
{
    public class MarkaController : Controller
    {
        MvcDbStokEntities stok = new MvcDbStokEntities();
        // GET: Marka
        public ActionResult MarkaListele()
        {
            var degerler = stok.Markalar.ToList();
            return View(degerler);
        }
        public ActionResult YeniMarka(Markalar marka)
        {
            return View();
        }
        public ActionResult Sil(int id)
        {
            var marka = stok.Markalar.Find(id);
            stok.Markalar.Remove(marka);
            stok.SaveChanges();
            return RedirectToAction("MarkaListele");
        }
    }
}