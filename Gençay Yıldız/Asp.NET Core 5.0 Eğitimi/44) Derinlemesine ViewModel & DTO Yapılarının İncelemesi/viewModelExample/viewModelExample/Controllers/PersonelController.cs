using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using viewModelExample.Business;
using viewModelExample.Models;
using viewModelExample.Models.ViewModels;

namespace viewModelExample.Controllers
{
    public class PersonelController : Controller
    {
        public IMapper Mapper { get; }

        public PersonelController(IMapper mapper)
        {
            Mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PersonelCreateVM personelCreateVM)
        {
            #region Ameleus Manuel

            //Personel p = new Personel()
            //{
            //    Adi = personelCreateVM.Adi,
            //    Soyadi = personelCreateVM.Soyadi
            //};
            #endregion
            #region Implicit

            //Personel personel = personelCreateVM;
            //PersonelCreateVM vm = personel;

            #endregion
            #region Explicit

            //Personel personel =(Personel) personelCreateVM;
            //PersonelCreateVM vm =(PersonelCreateVM) personel;

            #endregion
            #region Reflection
            TypeConversion.Conversion<PersonelCreateVM, Personel>(personelCreateVM);

            PersonelListeVM personelListeVM = TypeConversion.Conversion<Personel, PersonelListeVM>(new Personel
            {
                Adi = "asfsafdsaf",
                Soyadi = "asfasfsa"
            });
            #endregion
            #region AutoMapper
            Personel p = Mapper.Map<Personel>(personelCreateVM);
            PersonelCreateVM p2 = Mapper.Map<PersonelCreateVM>(p);
            #endregion
            return View();
        }
        public IActionResult Listele()
        {
            List<PersonelListeVM> personeller = new List<Personel>
            {
                new Personel{Adi="A" ,Soyadi="B"},
                new Personel{Adi="A1" ,Soyadi="B"},
                new Personel{Adi="A2" ,Soyadi="B"},
                new Personel{Adi="A3" ,Soyadi="B"},
                new Personel{Adi="A4" ,Soyadi="B"},
                new Personel{Adi="A5" ,Soyadi="B"}
            }.Select(p => new PersonelListeVM
            {
                Adi = p.Adi,
                Pozisyon = p.Pozisyon,
                Soyadi = p.Soyadi
            }).ToList();
            return View(personeller);
        }
        public IActionResult Get()
        {
            var nesne = (new Personel(), new Urun(), new Musteri());
            return View();
        }
    }
}
