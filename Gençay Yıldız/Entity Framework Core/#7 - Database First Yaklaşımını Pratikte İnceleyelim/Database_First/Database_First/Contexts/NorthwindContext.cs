using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Example.Entities;

namespace Example.Context
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
        }

        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Satislar> Satislars { get; set; } = null!;
        public virtual DbSet<Urunler> Urunlers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server = localhost;Database = Northwind;Trusted_Connection = true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Satislar>(entity =>
            {
                entity.HasKey(e => e.SatisId);

                entity.ToTable("Satislar");

                entity.HasIndex(e => e.MusteriId, "MusteriID");

                entity.HasIndex(e => e.MusteriId, "MusterilerSatislar");

                entity.HasIndex(e => e.ShipVia, "NakliyecilerSatislar");

                entity.HasIndex(e => e.PersonelId, "PersonelID");

                entity.HasIndex(e => e.PersonelId, "PersonellerSatislar");

                entity.HasIndex(e => e.SatisTarihi, "SatisTarihi");

                entity.HasIndex(e => e.SevkPostaKodu, "SevkPostaKodu");

                entity.HasIndex(e => e.SevkTarihi, "SevkTarihi");

                entity.Property(e => e.SatisId).HasColumnName("SatisID");

                entity.Property(e => e.MusteriId)
                    .HasMaxLength(5)
                    .HasColumnName("MusteriID")
                    .IsFixedLength();

                entity.Property(e => e.NakliyeUcreti)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OdemeTarihi).HasColumnType("datetime");

                entity.Property(e => e.PersonelId).HasColumnName("PersonelID");

                entity.Property(e => e.SatisTarihi).HasColumnType("datetime");

                entity.Property(e => e.SevkAdi).HasMaxLength(40);

                entity.Property(e => e.SevkAdresi).HasMaxLength(60);

                entity.Property(e => e.SevkBolgesi).HasMaxLength(15);

                entity.Property(e => e.SevkPostaKodu).HasMaxLength(10);

                entity.Property(e => e.SevkSehri).HasMaxLength(15);

                entity.Property(e => e.SevkTarihi).HasColumnType("datetime");

                entity.Property(e => e.SevkUlkesi).HasMaxLength(15);
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.HasKey(e => e.UrunId);

                entity.ToTable("Urunler");

                entity.HasIndex(e => e.KategoriId, "KategoriID");

                entity.HasIndex(e => e.KategoriId, "KategorilerUrunler");

                entity.HasIndex(e => e.TedarikciId, "TedarikciID");

                entity.HasIndex(e => e.TedarikciId, "TedarikcilerUrunler");

                entity.HasIndex(e => e.UrunAdi, "UrunAdi");

                entity.Property(e => e.UrunId).HasColumnName("UrunID");

                entity.Property(e => e.BirimFiyati)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BirimdekiMiktar).HasMaxLength(20);

                entity.Property(e => e.EnAzYenidenSatisMikatari).HasDefaultValueSql("((0))");

                entity.Property(e => e.HedefStokDuzeyi).HasDefaultValueSql("((0))");

                entity.Property(e => e.KategoriId).HasColumnName("KategoriID");

                entity.Property(e => e.TedarikciId).HasColumnName("TedarikciID");

                entity.Property(e => e.UrunAdi).HasMaxLength(40);

                entity.Property(e => e.YeniSatis).HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
