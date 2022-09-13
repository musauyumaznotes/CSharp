using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context(); 
        [Authorize]
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }
        [HttpPost]
        [Authorize]
        public ActionResult YeniBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [Authorize]
        public ActionResult BlogSil(int id)
        {
            var silinecekBlog = context.Blogs.Find(id);
            context.Blogs.Remove(silinecekBlog);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize]
        public ActionResult BlogGetir(int id)
        {
            var bulunacakBlog = context.Blogs.Find(id);
            return View("BlogGetir",bulunacakBlog);
        }
        [Authorize]
        public ActionResult BlogGuncelle(Blog blog)
        {
            var blogBul = context.Blogs.Find(blog.Id);
            blogBul.Baslik = blog.Baslik;
            blogBul.Aciklama = blog.Aciklama;
            blogBul.BlogImage = blog.BlogImage;
            blogBul.Tarih = blog.Tarih;
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize]
        public ActionResult YorumListele()
        {
            var degerler = context.Yorums.ToList();
            return View(degerler);
        }
        [Authorize]
        public ActionResult YorumSil(Blog blog)
        {
            var silinecekYorum = context.Yorums.Find(blog.Id);
            context.Yorums.Remove(silinecekYorum);
            context.SaveChanges();
            return RedirectToAction("YorumListele");
        }
        [Authorize]
        public ActionResult YorumGetir(int id)
        {
            var guncellenecekYorum = context.Yorums.Find(id);
            return View("YorumGetir",guncellenecekYorum);
        }
        [Authorize]
        public ActionResult YorumGuncelle(Yorum yorum)
        {
            var guncellenecekYorum = context.Yorums.Find(yorum.Id);
            guncellenecekYorum.AdSoyad = yorum.AdSoyad;
            guncellenecekYorum.Icerik = yorum.Icerik;
            guncellenecekYorum.Mail = yorum.Mail;
            guncellenecekYorum.IsActive = yorum.IsActive;
            context.SaveChanges();
            return RedirectToAction("YorumListele");
        }

    }
}