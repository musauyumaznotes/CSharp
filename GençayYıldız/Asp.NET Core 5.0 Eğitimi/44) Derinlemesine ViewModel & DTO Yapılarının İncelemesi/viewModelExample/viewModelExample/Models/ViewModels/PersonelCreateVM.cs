using System.ComponentModel.DataAnnotations;

namespace viewModelExample.Models.ViewModels
{
    public class PersonelCreateVM
    {
        //ViewModel'da sadece taşınacak verinin propertleri temsil edilir.
        [Required]
        public string Adi { get; set; }
        [Required]
        public string Soyadi { get; set; }
    }
}
