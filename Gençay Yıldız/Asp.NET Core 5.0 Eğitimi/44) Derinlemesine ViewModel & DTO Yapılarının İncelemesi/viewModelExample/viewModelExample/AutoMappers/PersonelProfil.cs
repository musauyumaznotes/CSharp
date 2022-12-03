using AutoMapper;
using viewModelExample.Models;
using viewModelExample.Models.ViewModels;

namespace viewModelExample.AutoMappers
{
    public class PersonelProfil:Profile
    {
        public PersonelProfil()
        {
            CreateMap<Personel, PersonelCreateVM>();
            CreateMap<PersonelCreateVM, Personel>();
        }
    }
}
