using Skill_CodeFirstEntity.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skill_CodeFirstEntity.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            CONTEXT c = new CONTEXT();
            var degerler=c.YETENEKLERS.ToList();
            return View(degerler);
        }
    }
}