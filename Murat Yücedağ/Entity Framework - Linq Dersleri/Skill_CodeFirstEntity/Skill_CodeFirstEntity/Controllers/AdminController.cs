using Skill_CodeFirstEntity.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skill_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        CONTEXT c = new CONTEXT();
        // GET: Admin
        public ActionResult Index()
        {
            
            var degerler = c.YETENEKLERS.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(YETENEKLER yetenekler)
        {
            c.YETENEKLERS.Add(yetenekler);
            c.SaveChanges();
            return View();
        }
        public ActionResult YetenekSil(int id)
        {
            var deger =c.YETENEKLERS.Find(id);
            c.YETENEKLERS.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGuncelle(int id)
        {
            var deger = c.YETENEKLERS.Find(id);
            return View("YetenekGuncelle",deger);

        }
        [HttpPost]
        public ActionResult YetenekGuncelle(YETENEKLER yetenekler)
        {
            var deger = c.YETENEKLERS.Find(yetenekler.Id);
            deger.ACIKLAMA = yetenekler.ACIKLAMA;
            deger.Deger = yetenekler.Deger;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}