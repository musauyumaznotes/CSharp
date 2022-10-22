using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

Console.Read();
//İki tablo arasında çoka çok ilişki kuracaksak eğer bir üçüncü tabloya ihtiyacımız oluyor. İşte bu üçüncü tabloya cross table/ara tablo denilmektedir.
//Doğrudan bir çoka çok ilişki olmaz ara tabloyla her iki tabloyu bire çok ilişki türünden ilişkilendiriyoruz. Yani bu iki tablo ara tablo aracılığıyla onun üzerinden dolaylı yoldan çoka çok bir ilişkiye sahip oluyor.
//Cross table içerisinde primary key'i composite primary key olarak ayarlarız.
#region Default Convention
//Çoka çok ilişki kurmak için koleksiyonel çoğulluğu ifade eden Navigation property'ler kullanamamız lazım
//EF Core diyor ki iki entity arasında Navigation property aracılığıyla bir koleksiyonel bağ kuruluyorsa ben bunu çoka çok ilişki olduğunu anlarım Eğer ki bir cross table'ı temsil eden entity yoksa onuda ben kendim oluştururum
//Composite primary key bütünsel olarak tekrarı engeller.
//İki entity arasındaki ilişkiyi navigation propertyler üzerinden çoğul olarak kurmalıyız. (ICollection,List)
//Default Convention'da Cross'table'ı manuel oluşturmak zorunda değiliz. EF Core tasarımına uygun bir şekilde cross table kendisi otomatik basacak ve generate edecektir.
//Ve oluşturulan cross table'ın içerisinde composite primary key'i de otomatik oluşturmuş olacaktır.
//class Kitap
//{
//    public int Id { get; set; }
//    public string KitapAdi { get; set; }

//    public ICollection<Yazar> Yazarlar { get; set; }

//}
//class Yazar
//{
//    public int Id { get; set; }
//    public string YazarAdi { get; set; }

//    public ICollection<Kitap> Kitaplar { get; set; }
//}
#endregion
#region Data Annotations
//Cross table manuel olarak oluşturulmak zorundadır.
//Entity'lerde oluşturduğumuz cross table entity si ile bire çok ilişki kurulmalı.
//Data Annotations ile direkt olarak composite key tanımlaması yapamayız bu yüzden Fluent API yöntemini kullanmalıyız.
//Cross Table'da composite primary key'i daya annotations'(attributelar)lar ile manuel kuramıyoruzç Bunun için de Fluent API'da çalışma yapmamız gerekiyor.
//Cross table'a karşılık bir entity modeli oluşturuyorsak eğer bunu context sınıfı içerisinde DbSet prperty'si olarak bildirmek mecburiyetinde değiliz!
//class Kitap
//{
//    public int Id { get; set; }
//    public string KitapAdi { get; set; }

//    public ICollection<KitapYazar> Yazarlar { get; set; }

//}
////Cross Table
//class KitapYazar
//{
//    //[Key]
//    [ForeignKey(nameof(Kitap))]
//    public int KId { get; set; }
//    //[Key]
//    [ForeignKey(nameof(Yazar))]
//    public int YId { get; set; }

//    public Kitap Kitap { get; set; }
//    public Yazar Yazar { get; set; }
//}
//class Yazar
//{
//    public int Id { get; set; }
//    public string YazarAdi { get; set; }

//    public ICollection<KitapYazar> Kitaplar { get; set; }
//}
#endregion
#region Fluent API
//Cross table manuel oluşturulmalı 
//DbSet olarak eklenmesine lüzum yok
//Composite PK HasKey metodu ile kurulmalı!
class Kitap
{
    public int Id { get; set; }
    public string KitapAdi { get; set; }

    public ICollection<KitapYazar> Yazarlar { get; set; }

}
class KitapYazar
{
    public int KitapId { get; set; }
    public int YazarId { get; set; }

    public Kitap Kitap { get; set; }
    public Yazar Yazar { get; set; }
}
class Yazar
{
    public int Id { get; set; }
    public string YazarAdi { get; set; }

    public ICollection<KitapYazar> Kitaplar { get; set; }
}
#endregion



class EKitapDbContext : DbContext
{
    public DbSet<Kitap> Kitaplar { get; set; }
    public DbSet<Yazar> Yazarlar { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database= EKitapDB;User ID=SA;Password=1q2w3e4r!.");
    }

    //Data Annotations
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<KitapYazar>()
    //        .HasKey(ky => new { ky.KitapId, ky.YazarId });
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KitapYazar>()
            .HasKey(ky => new { ky.YazarId, ky.KitapId });

        modelBuilder.Entity<KitapYazar>()
            .HasOne(ky => ky.Kitap)
            .WithMany(k => k.Yazarlar)
            .HasForeignKey(ky => ky.KitapId);

        modelBuilder.Entity<KitapYazar>()
            .HasOne(ky => ky.Yazar)
            .WithMany(y => y.Kitaplar)
            .HasForeignKey(ky => ky.YazarId);
    }
}