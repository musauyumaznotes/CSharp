using Microsoft.AspNetCore.Mvc;
using ModulerTasarim.Models;
using System.Collections.Generic;

namespace ModulerTasarim.ViewComponents
{
    public class PersonellerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Personel> datas = new List<Personel>
            {
                new Personel{Adi = "Şuayip",Soyadi="Abi"},
                new Personel{Adi = "Hüseyin",Soyadi="Sümer"},
                new Personel{Adi = "Rıfkı",Soyadi="Bilmemneoğlu"},
                new Personel{Adi = "Şakir",Soyadi="Çorumlu"},
                new Personel{Adi = "Hilmi",Soyadi="Celayir"}
            };
            return View(datas);
        }
    }
}
