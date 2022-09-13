using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelController : Controller
    {
        // GET: WriterPanel
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        int id;
        public ActionResult WriterProfile()
        {
            return View();
        }
        public ActionResult MyHeading(string p)
        {
            Context c = new Context();
            p = (string)Session["WriterEmail"];
            var writerIdInfo = c.Writers.Where(x => x.WriterEmail == p).Select(y => y.WriterId).FirstOrDefault();
            id = writerIdInfo;
            var contentValues = headingManager.GetListByWriter(writerIdInfo);
            return View(contentValues);
        }
        [HttpGet]
        public ActionResult NewHeading()
        {
            List<SelectListItem> valueCategory = (from x in categoryManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }
                                                  ).ToList();
            ViewBag.vlc = valueCategory;
            return View();
        }
        [HttpPost]
        public ActionResult NewHeading(Heading heading)
        {
            Context c = new Context();
            string writerEmailInfo = (string)Session["WriterEmail"];
            var writerIdInfo = c.Writers.Where(x => x.WriterEmail == writerEmailInfo).Select(y => y.WriterId).FirstOrDefault();
            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            heading.WriterId = writerIdInfo;
            heading.HeadingStatus = true;
            headingManager.HeadingAdd(heading);
            return RedirectToAction("MyHeading");
        }
        [HttpGet]
        public ActionResult EditMyHeading(int id)
        {
            List<SelectListItem> valueCategory = (from x in categoryManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }
                                                  ).ToList();
            ViewBag.vlc = valueCategory;
            var headingValue = headingManager.GetById(id);
            return View(headingValue);
        }
        [HttpPost]
        public ActionResult EditMyHeading(Heading heading)
        {
            headingManager.HeadingUpdate(heading);
            return RedirectToAction("MyHeading");
        }
        public ActionResult DeleteMyHeading(int id)
        {
            var headingvalue = headingManager.GetById(id);
            headingvalue.HeadingStatus = false;
            headingManager.HeadingDelete(headingvalue);
            return RedirectToAction("MyHeading");
        }

    }
}