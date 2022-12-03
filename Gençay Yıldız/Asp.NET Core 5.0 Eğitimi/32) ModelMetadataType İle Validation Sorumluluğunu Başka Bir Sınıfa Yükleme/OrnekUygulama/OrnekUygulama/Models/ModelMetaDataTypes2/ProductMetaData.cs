using System.ComponentModel.DataAnnotations;

namespace OrnekUygulama.Models.ModelMetaDataTypes2
{
    public class ProductMetaData
    {
        [Required(ErrorMessage = "Lütfen product name'i giriniz.")]
        [StringLength(100, ErrorMessage = "Lütfen product name'i en fazla 100 karakater giriniz")]
        public string ProductName { get; set; }
        [EmailAddress(ErrorMessage = "Lütfen doğru bir email adres giriniz.")]
        public string Email { get; set; }
    }
}
