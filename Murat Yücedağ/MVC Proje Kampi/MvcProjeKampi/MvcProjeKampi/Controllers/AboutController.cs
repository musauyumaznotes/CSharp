using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
      
        public ActionResult Index()
        {
            var aboutValue = aboutManager.GetList();
            return View(aboutValue);
        }
        [HttpGet]
    
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
  
        public ActionResult AddAbout(About about)
        {
            aboutManager.AboutAdd(about);
            return RedirectToAction("Index");
        }
   
        public PartialViewResult AboutAddPartial()
        {
            return PartialView();
        }
    }
}