using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class SatisHareket
    {
        [Key]
        public int SatisId { get; set; }
        //ürün
        //cari
        //personel
        public DateTime MyProperty { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }
        public ICollection<Urun> Uruns { get; set; }
        public ICollection<Cari> Caris { get; set; }
        public ICollection<Personel> Personels { get; set; }
    }
}