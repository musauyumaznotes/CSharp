using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Admin
    
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            Context c = new Context();
            var adminInfo = c.Admins.FirstOrDefault(x=>x.UserName==admin.UserName && x.Password==admin.Password);

            if (adminInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminInfo.UserName, false);
                Session["UserName"]=admin.UserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
        [HttpGet]
        public ActionResult WriterLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WriterLogin(Writer writer)
        {
            Context c = new Context();
            var writerInfo = c.Writers.FirstOrDefault(x => x.WriterEmail == writer.WriterEmail && x.WriterPassword == writer.WriterPassword);

            if (writerInfo != null)
            {
                FormsAuthentication.SetAuthCookie(writerInfo.WriterEmail, false);
                Session["WriterEmail"] = writerInfo.WriterEmail;
                return RedirectToAction("MyContent", "WriterPanelContent");
            }
            else
            {
                return RedirectToAction("WriterLogin");
            }
        }
    }
}