# One To Many Relationship
# Default Convention
- İki tablo arasındaki ilişkisel yapıyı entity sınıfları üzerinden navigation property'ler üzerinde yapmamızı sağlayan bir yöntemdir.

- Bireçok ilişkide birebir ilişkide olduğu gibi dependent entity'de özellikle bir foreign key falan tanımlama zorunluluğun yoktur.

- EF Core : navigation property üzerinden sen bireçok bir ilişkiyi default conventation ile sağladıysan eğer veritabanını generate ederken gerekli olan foreign key kolonunu buraya eklerim gerekli entity ile bunu eşleştiririm ama sen bu foreign key kolonunu temsil eden bir property'e sahip olmasanda olur.

- default convention yönteminde bire çok ilişkiyi kurarken foreign key kolonuna karşılık gelen bir property tanımlamak mecburiyetinde değiliz. Eğer tanımlamazsak EF Core bunu kendisi tanımlayacak yok eğer tanımlarsak, tanımladığımızı baz alacaktır.

```C#
class Calisan //Dependent Entity
{
   public int Id { get; set; }
   public int DepartmanId { get; set; }
   public string Adi { get; set; }

   public Departman Departman { get; set; }
}
class Departman
{
   public int Id { get; set; }
   public string DepartmanAdi { get; set; }

   public ICollection<Calisan> Calisanlar { get; set; }
}
```

# Data Annotations
- İki tablo arasındaki ilişkisel yapıyı entity sınıfları üzerinden attribute'lar ile yapmamızı sağlayan bir yöntemdir.

- Data Annotation'slarda foreign key kolonunu kullanmak zorundayız.

- Eğer ki dependent entity'lerde foreign key kolonuna karşılık gelen property'i tanımlayıp bu property'nin ismini default convention'ın dışında farklı bir isimlendirme ile tanımlamak istiyorsak burada data annotations'ları kullanabiliriz 

- Default convention yönteminde foreign key kolonuna karşılık gelen propertyi tanımladığımızda bu property ismi temel geleneksel entity tanımlama kurallarına uymuyorsa eğer data annotations'lar ile müdahalede bulunabiliriz.

```C#
class Calisan //Dependent Entity
{
   public int Id { get; set; }
   public string Adi { get; set; }
   [ForeignKey(nameof(Departman))]
   public int DId { get; set; }

   public Departman Departman { get; set; }
}
class Departman
{
   public int Id { get; set; }
   public string DepartmanAdi { get; set; }

   public ICollection<Calisan> Calisanlar { get; set; }
}
```

# Fluent API
- İki tablo arasındaki ilişkisel yapılanmayı bütün konfigürasyonel sorumluluğunu context sınıfına bırakan oradaki api fonksiyonları üzerinden yapmamızı sağlayan bir yöntemdir.

- Foreign key tanımlamasında bulunmamıza gerek yoktur. Bire çok ilişkide eğer ki foreign key'i siz tanımlamıyorsanız hangi yöntem olursa olsun EF Core buradaki ilişki yapılanmasına göre foreign key'i kendisi otomatik tanımlayacaktır. Ama eğer ki kendin tanımlıyorsan bildireceksin

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Calisan>()
        .HasOne(c => c.Departman)
        .WithMany(d => d.Calisanlar)
        .HasForeignKey(c=>c.DId);
}
```
```C#
class Calisan //Dependent Entity
{
    public int Id { get; set; }
    public int DId { get; set; }
    public string Adi { get; set; }


    public Departman Departman { get; set; }
}
class Departman
{
    public int Id { get; set; }
    public string DepartmanAdi { get; set; }

    public ICollection<Calisan> Calisanlar { get; set; }
}

class ESirketDbContext : DbContext
{
    public DbSet<Calisan> Calisanlar { get; set; }
    public DbSet<Departman> Departmanlar { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=ESirketDB;Trusted_Connection=true;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Calisan>()
            .HasOne(c => c.Departman)
            .WithMany(d => d.Calisanlar)
            .HasForeignKey(c=>c.DId);
    }
}
```