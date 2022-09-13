namespace WindowsFormsApp13
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Urunler
    {
        public int Id { get; set; }

        public string UrunAd { get; set; }

        public string UrunMarka { get; set; }

        public string UrunKategori { get; set; }

        public int UrunStok { get; set; }

        public string Aciklama { get; set; }

        public int? Kategori_Id { get; set; }

        public virtual Kategori Kategori { get; set; }
    }
}
