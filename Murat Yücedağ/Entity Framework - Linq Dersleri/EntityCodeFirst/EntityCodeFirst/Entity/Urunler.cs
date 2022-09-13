using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Urunler
    {
        [Key]
        public int Id { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public string  UrunKategori { get; set; }
        public int UrunStok { get; set; }
        public Kategori Kategori { get; set; }
    }
}
