using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Skill_CodeFirstEntity.Models.Siniflar
{
    public class YETENEKLER
    {
        [Key]
        public int Id { get; set; }
        public string ACIKLAMA { get; set; }
        public byte Deger { get; set; }
    }
}