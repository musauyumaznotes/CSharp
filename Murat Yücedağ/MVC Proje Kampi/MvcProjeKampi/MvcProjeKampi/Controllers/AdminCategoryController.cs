using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        [Authorize(Roles="A")]
        public ActionResult Index()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }
        [HttpGet]
 
        public ActionResult AddCategory()
        {
            return View();

        }
        [HttpPost]
 
        public ActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);

            if (results.IsValid)
            {
                cm.CategoryAdd(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
           
            

        }
     
        public ActionResult DeleteCategory(int id)
        {
            var categoryCalue = cm.GetById(id);
            cm.CategoryDelete(categoryCalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
 
        public ActionResult EditCategory(int id)
        {
            var categoryCalue = cm.GetById(id);
            return View(categoryCalue);
        }
        [HttpPost]
    
        public ActionResult EditCategory(Category category)
        {
            cm.CategoryUpdate(category);
            return RedirectToAction("Index");
        }
    }
}