using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp13
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<Urunler> Urunlers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.Urunlers)
                .WithOptional(e => e.Kategori)
                .HasForeignKey(e => e.Kategori_Id);
        }
    }
}
