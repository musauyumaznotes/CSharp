using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string KullaniciAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Sifre { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string Yetki { get; set; }

    }
}