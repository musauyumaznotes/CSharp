using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class Yorum
    {
        [Key]
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Icerik { get; set; }
        public bool IsActive { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }

    }
}