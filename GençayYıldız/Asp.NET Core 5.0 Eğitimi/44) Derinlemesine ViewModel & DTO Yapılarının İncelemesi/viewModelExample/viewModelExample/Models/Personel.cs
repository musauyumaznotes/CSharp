using System.ComponentModel.DataAnnotations;
using viewModelExample.Models.ViewModels;

namespace viewModelExample.Models
{
    //Entity Model
    public class Personel
    {
        public int Id { get; set; }
        [Required]
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        [Required]
        [StringLength(13)]
        public string Pozisyon { get; set; }
        public int Maas { get; set; }
        public bool MedeniHal { get; set; }

        #region implicit/Gizli/Bilinçsiz
        //public static implicit operator PersonelCreateVM(Personel model)
        //{
        //    return new PersonelCreateVM
        //    {
        //        Adi = model.Adi,
        //        Soyadi = model.Soyadi
        //    };
        //}
        //public static implicit operator Personel(PersonelCreateVM model)
        //{
        //    return new Personel
        //    {
        //        Adi = model.Adi,
        //        Soyadi = model.Soyadi
        //    };
        //}
        #endregion
        #region Explicit/Açık/Bilinçli
        public static explicit operator PersonelCreateVM(Personel model)
        {
            return new PersonelCreateVM
            {
                Adi = model.Adi,
                Soyadi = model.Soyadi
            };
        }
        public static explicit operator Personel(PersonelCreateVM model)
        {
            return new Personel
            {
                Adi = model.Adi,
                Soyadi = model.Soyadi
            };
        }
        #endregion
    }
}
