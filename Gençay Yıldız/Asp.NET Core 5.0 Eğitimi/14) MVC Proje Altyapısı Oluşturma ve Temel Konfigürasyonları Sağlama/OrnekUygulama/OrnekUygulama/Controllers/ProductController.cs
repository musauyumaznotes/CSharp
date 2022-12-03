using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models;

namespace OrnekUygulama.Controllers
{
    //[NonController]
    public class ProductController : Controller
    {
        //public IActionResult GetProducts()
        //{
        //    Product product = new Product(); 
        //    //Veri üretildi...

        //    //ViewResult result = View(); --> ilgili action ismiyle birebir aynı olan viewi tetikler
        //    ViewResult result = View("ahmet");//--> Belirtilen view ismindeki view dosyasını render eder.
        //    return result;
        //}
        #region ViewResult
        //public ViewResult GetProducts2()
        //{
        //    ViewResult result = View();
        //    return result;
        //}
        #endregion
        #region PartialViewResult
        //public PartialViewResult GetProducts()
        //{
        //    PartialViewResult result = PartialView();
        //    return result;
        //}
        #endregion
        #region JsonRsult
        //public JsonResult GetProducts()
        //{
        //    JsonResult result = Json(new Product
        //    {
        //        Id = 1,
        //        ProductName = "Terlik",
        //        Quantity = 15
        //    });
        //    return result;
        //}
        #endregion
        #region EmptyResult
        //public EmptyResult GetProducts()
        //{
        //    return new EmptyResult();
        //}
        //public void GetProducts()
        //{

        //}

        #endregion
        #region ContentResult
        //public ContentResult GetProducts()
        //{
        //    ContentResult result = Content("sebepsiz boş yere ayrılacaksannnn.......");
        //    return result;
        //}
        #endregion
        #region ActionResult
        public ActionResult GetProducts()
        {
            ActionResult result = View();
            return result;
        }
        #endregion
        #region IActionResult
        //public ViewResult GetProducts()
        //{

        //}
        #endregion


        public IActionResult Index()
        {
            return View();

        }
        [NonAction]
        public void X()
        {

        }
    }
}
