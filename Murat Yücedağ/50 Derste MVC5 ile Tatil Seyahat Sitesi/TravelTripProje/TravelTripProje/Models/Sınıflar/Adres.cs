using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class Adres
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Mail { get; set; }
        public string AcikAdres { get; set; }
        public string Konum { get; set; }
        public string GitHub { get; set; }
        public string LinkedLn { get; set; }
        public string Instagram { get; set; }
        public string WebSite { get; set; }
    }
}