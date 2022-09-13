using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        BlogYorum blogYorum = new BlogYorum();
        public ActionResult Index()
        {
            blogYorum.Blog = context.Blogs.ToList();
            blogYorum.Yorum = context.Yorums.ToList();
            blogYorum.SonBloglar = context.Blogs.OrderByDescending(x => x.Tarih).Take(3).ToList();
            blogYorum.SonYorumlar = context.Yorums.OrderByDescending(x => x.BlogId).Take(3).ToList();
            return View(blogYorum);
        }
      
        public ActionResult BlogDetay(int id)
        {
            blogYorum.Blog = context.Blogs.Where(x => x.Id == id).ToList();
            blogYorum.Yorum = context.Yorums.Where(y => y.BlogId == id && y.IsActive==true).ToList();
            blogYorum.SonBloglar = context.Blogs.OrderByDescending(x=>x.Tarih).Take(3).ToList();
            blogYorum.SonYorumlar = context.Yorums.OrderByDescending(x => x.BlogId).Take(3).ToList();
            
            return View(blogYorum);
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorum yorum)
        {
            
            context.Yorums.Add(yorum);
            context.SaveChanges();
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
    }
}