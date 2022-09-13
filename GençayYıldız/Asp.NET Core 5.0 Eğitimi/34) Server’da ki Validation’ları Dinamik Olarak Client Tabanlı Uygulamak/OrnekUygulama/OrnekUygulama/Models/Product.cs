using System.ComponentModel.DataAnnotations;

namespace OrnekUygulama.Models
{
    public class Product
    {
       
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }
    }
}
