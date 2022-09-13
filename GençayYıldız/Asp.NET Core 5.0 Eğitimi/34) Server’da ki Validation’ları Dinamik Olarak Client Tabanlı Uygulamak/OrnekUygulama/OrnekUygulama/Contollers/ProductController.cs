using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrnekUygulama.Models;
using System.Linq;

namespace OrnekUygulama.Contollers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product model)
        {
            //ModelState : MVC'de bir type'ın data annotationslarının durumunu kontrol eden ve geriye sonuç dönen bir property
            if (!ModelState.IsValid)
            {
                //Loglama
                //Kullanıcı Bilgilendirme

                //ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x=>x.ValidationState == ModelValidationState.Invalid).Errors[0].ErrorMessage;

                var messages = ModelState.ToList();
                
                return View(model);
            }
            //İşleme/Operasyona/Algoritmaya tabi tutulur.
            return View();
        }


    }
}
