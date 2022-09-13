using MVCStok.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
namespace MVCStok.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        MvcDbStokEntities stok = new MvcDbStokEntities();
        public ActionResult KategoriListesi(int sayfa=1)
        {
            //var degerler = stok.Kategoriler.ToList();
            var degerler = stok.Kategoriler.ToList().ToPagedList(sayfa, 4);
            return View(degerler);
        }
        [HttpPost]
        public ActionResult YeniKategori(Kategoriler kategori)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            kategori.CreatedAt = DateTime.Now;
            kategori.IsActive = false;
            kategori.Ad.ToUpper();
            stok.Kategoriler.Add(kategori);
            stok.SaveChanges();
            return RedirectToAction("KategoriListesi");

        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }
        public ActionResult Sil(int id)
        {
            var kategori = stok.Kategoriler.Find(id);
            if (kategori.IsActive == true)
            {
                kategori.IsActive = false;
                stok.SaveChanges();
                return RedirectToAction("KategoriListesi");

            }
            else
            {
                stok.Kategoriler.Remove(kategori);
                stok.SaveChanges();
                return RedirectToAction("KategoriListesi");
            }

        }
        public ActionResult KategoriGetir(int id)
        {
            var kategori = stok.Kategoriler.Find(id);
            return View("KategoriGetir", kategori);
        }
        public ActionResult Guncelle(Kategoriler kategori)
        {
            var kategoriBul = stok.Kategoriler.Find(kategori.Id);
            kategoriBul.Ad = kategori.Ad;
            stok.SaveChanges();
            return RedirectToAction("KategoriListesi");
        }

    }
}