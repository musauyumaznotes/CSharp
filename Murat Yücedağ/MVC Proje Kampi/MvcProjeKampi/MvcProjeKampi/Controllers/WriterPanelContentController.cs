using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelContentController : Controller
    {
        ContentManager contentManager = new ContentManager(new EfContentDal());
        // GET: WriterPanelContent
        public ActionResult MyContent()
        {
            Context c = new Context();
            string p = (string)Session["WriterEmail"];
            var writerIdInfo = c.Writers.Where(x => x.WriterEmail == p).Select(y=>y.WriterId).FirstOrDefault();
            var contentValues = contentManager.GetListByWriter(writerIdInfo);
            return View(contentValues);
        }
    }
}