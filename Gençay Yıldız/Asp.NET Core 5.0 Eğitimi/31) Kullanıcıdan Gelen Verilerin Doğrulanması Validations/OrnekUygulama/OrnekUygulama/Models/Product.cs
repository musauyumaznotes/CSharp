using System.ComponentModel.DataAnnotations;

namespace OrnekUygulama.Models
{
    public class Product
    {
        [Required(ErrorMessage ="Lütfen product name'i giriniz.")]
        [StringLength(100,ErrorMessage ="Lütfen product name'i en fazla 100 karakater giriniz")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        [EmailAddress(ErrorMessage ="Lütfen doğru bir email adres giriniz.")]
        public string Email { get; set; }
    }
}
