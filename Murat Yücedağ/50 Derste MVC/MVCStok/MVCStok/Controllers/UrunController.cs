using MVCStok.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStok.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        MvcDbStokEntities stok = new MvcDbStokEntities();
        public ActionResult UrunListesi()
        {
            var degerler = stok.Urunler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            List<SelectListItem> degerler = (from x in stok.Kategoriler.Where(z=>z.IsActive==true).ToList()
                                             select new SelectListItem
                                             {   Text = x.Ad,
                                                 Value = x.Id.ToString(),
                                                 
                                             }).ToList();
            ViewBag.degerler = degerler;

            List<SelectListItem> markalar = (from x in stok.Markalar.Where(z=>z.IsActive==true).ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Ad,
                                                 Value = x.Id.ToString()
                                             }).ToList();
            ViewBag.markalar = markalar;
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(Urunler urun)
        {
            var kategori = stok.Kategoriler.Where(m => m.Id == urun.Kategoriler.Id).FirstOrDefault();
            urun.Kategoriler = kategori;
            var marka = stok.Markalar.Where(m => m.Id == urun.Markalar.Id).FirstOrDefault();
            urun.Markalar = marka;
            urun.IsActive = false;
            urun.CreatedAt = DateTime.Now;
            stok.Urunler.Add(urun);
            stok.SaveChanges();
            return RedirectToAction("/UrunListesi");
        }
        public ActionResult Sil(int id)
        {
            var urun = stok.Urunler.Find(id);
            stok.Urunler.Remove(urun);
            stok.SaveChanges();
            return RedirectToAction("UrunListesi");
        }
        [HttpGet]
        public ActionResult UrunGetir(int id)
        {
            var urun = stok.Urunler.Find(id);

            List<SelectListItem> kategoriler = (from x in stok.Kategoriler.Where(z => z.IsActive == true).ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Ad,
                                                 Value = x.Id.ToString(),

                                             }).ToList();
            ViewBag.kategoriler = kategoriler;

            List<SelectListItem> markalar = (from x in stok.Markalar.Where(z => z.IsActive == true).ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Ad,
                                                 Value = x.Id.ToString()
                                             }).ToList();
            ViewBag.markalar = markalar;

            return View("UrunGetir",urun);
        }
        [HttpPost]
        public ActionResult Guncelle(Urunler urun)
        {
            var aranacakUrun = stok.Urunler.Find(urun.Id);
            var marka = stok.Markalar.Find(urun.MarkaId);
            var kategori = stok.Kategoriler.Find(urun.KategoriId);
           
            aranacakUrun.Ad = urun.Ad;
            aranacakUrun.MarkaId = marka.Id;
            aranacakUrun.KategoriId = kategori.Id;
            aranacakUrun.Fiyat = urun.Fiyat;
            aranacakUrun.Stok = urun.Stok;
            //aranacakUrun.IsActive = urun.IsActive;
            aranacakUrun.IsActive = true;
            aranacakUrun.CreatedAt = DateTime.Now;
            stok.SaveChanges();
            return RedirectToAction("UrunListesi");
        }
    }
}