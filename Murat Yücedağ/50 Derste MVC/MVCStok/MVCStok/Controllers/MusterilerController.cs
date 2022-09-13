using MVCStok.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStok.Controllers
{
    public class MusterilerController : Controller
    {
        // GET: Musteriler
        MvcDbStokEntities stok = new MvcDbStokEntities();
        public ActionResult MusteriListesi(string p)
        {
            var degerler = stok.Musteriler.ToList();
           
            if (!string.IsNullOrEmpty(p))
            {
               degerler = degerler.Where(m => m.Ad.Contains(p)).ToList();
            }
            
            return View(degerler);
        }
        [HttpPost]
        public ActionResult YeniMusteri(Musteriler musteri)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniMusteri");
            }
            musteri.CreatedAt = DateTime.Now;
            musteri.IsActive = false;
            stok.Musteriler.Add(musteri);
            stok.SaveChanges();
            return RedirectToAction("MusteriListesi");                                                                                             
        }
        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }
        public ActionResult Sil(int id)
        {
            var musteri = stok.Musteriler.Find(id);
            stok.Musteriler.Remove(musteri);
            stok.SaveChanges();
            return RedirectToAction("MusteriListesi");
        }
        public ActionResult MusteriGetir(int id)
        {
            var musteri = stok.Musteriler.Find(id);
            return View("MusteriGetir",musteri);
        }
        public ActionResult Guncelle(Musteriler musteri)
        {
            var arananMusteri = stok.Musteriler.Find(musteri.Id);
            arananMusteri.Ad = musteri.Ad;
            arananMusteri.Soyad = musteri.Soyad;
            //arananMusteri.IsActive = musteri.IsActive;
            arananMusteri.CreatedAt = DateTime.Now;
            arananMusteri.IsActive = false;
            stok.SaveChanges();
            return RedirectToAction("MusteriListesi");
        }

    }
}