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
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        WriterValidator validator = new WriterValidator();
  
        public ActionResult Index()
        {
            var writerValues = writerManager.GetList();
            return View(writerValues);
        }
        [HttpGet]

        public ActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]

        public ActionResult AddWriter(Writer writer)
        {
           
            ValidationResult results = validator.Validate(writer);
            if (results.IsValid)
            {
                writerManager.WriterAdd(writer);
                return RedirectToAction("Index");
            }else
            {
                foreach (var error in results.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View();
            }
            
        }
        [HttpGet]

        public ActionResult EditWriter(int id)
        {
            var writerValue = writerManager.GetById(id);
            return View(writerValue);
        }
        [HttpPost]

        public ActionResult EditWriter(Writer writer)
        {
            ValidationResult results = validator.Validate(writer);
            if (results.IsValid)
            {
                writerManager.WriterUpdate(writer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var error in results.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View();
            }
        }
    }
   
}