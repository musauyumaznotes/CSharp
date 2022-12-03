using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models.ModelMetaDataTypes2;
using System.ComponentModel.DataAnnotations;

namespace OrnekUygulama.Models
{
    [ModelMetadataType(typeof(ProductMetaData))]
    public class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        
        public string Email { get; set; }
    }
}
