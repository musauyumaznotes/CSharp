using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        IImageFileManager imageFileManager = new IImageFileManager(new EfImageFileDal());

        public ActionResult Index()
        {
            var images = imageFileManager.GetList();
            return View(images);
        }
    }
}