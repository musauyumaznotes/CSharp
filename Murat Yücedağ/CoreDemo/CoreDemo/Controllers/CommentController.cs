using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAddComment ()
        {
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id) 
        {
            var values = commentManager.GetAll(id);
            return PartialView(values);
        }
    }
}
