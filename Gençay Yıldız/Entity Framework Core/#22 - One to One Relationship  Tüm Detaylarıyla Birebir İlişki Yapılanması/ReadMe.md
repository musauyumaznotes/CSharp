# Default Convention
- Birebir ilişkiyi sağlayabilmek için öncelikle Navigation Property'leri tanımlamamız gerekiyor.

- Navigation Property'leri tanımlarken tekil referans verecek şekilde tanımlamalıyız.

- İlgili property'nin türü entity türünden ise bu navigtion property'dir.

- EF Core hangisinin dependent olduğuna karar veremiyor bu yüzden bizler dependent entity'e bir adet foreign key tanımlamalıyız.

- Her iki entity'de Navigation Property ile birbirlerini tekil olarak referans ederek fiziksel bir ilişkinin olacağı ifade edilir. 

- One To One ilişki türünde, dependent entity'nin hangisi olduğunu default olarak belirleyebilmek pek kolay değildir. Bu durumda fiziksel olarak bir foreign key'e karşılık property/kolon tanımlayarak çözüm getirebiliyoruz.

- Böylece foreign key'e karşılık property tanımlayarak lüzumsuz bir kolon oluşturmuş oluyoruz.
- Normalde bireçok olacak olan ilişkinin Birebir olduğunun aslında tanımlanan Unique index sayesinde garantisini sağlamış oluyor. Yani bir index oluşturuyor.

- Navigation propertyler tanımlanmalıdır.

- Foreign key kolonunun ismi default convention'ın dışında bir kolon olacaksa eğer Foreign Key attribute ile bunu bildirebiliriz.

- Foreign key kolonu oluşturulamk zorunda değildir.

- Birebir ilişkide ekstradan foreign key kolonuna ihtiyaç olmayacağından dolayı dependent entity'deki id kolonunun hem foreign key hem de primary key olarak tercih ediyoruz. ve bu duruma özenm gösterilmelidir.

```C#
class Calisan
{
   public int Id { get; set; }
   public string Adi { get; set; }

   public CalisanAdresi CalisanAdresi { get; set; }
}
class CalisanAdresi
{
   public int Id { get; set; }
   public int CalisanId { get; set; }
   public string Adres { get; set; }

   public Calisan Calisan { get; set; }
}
```

# Data Annotations
- İki entity arasında kurulacak ilişkinin nasıl olacağını attribute'lar üzerinden belirliyorsunuz.

- Default Convention'a nazaran daha kullanışlı bir yapıdır.

- Öncelikle Navigation property'leri yine kullanıyoruz. Çünkü navigation property'ler tüm yöntemlerde olması gerekiyor.

- Entity'ler üzerinde kurulan Navigation Property'ler entity'ler arasında ilişkinin fiziksel tanımlamasını sağlıyor.

- Burada kullandığımız ForeignKey attribute'una ise parametre olarak navigation property adını veririz.

- ForeignKey("Navigation Property Name")] | [ForeignKey(nameof(Navigation Property Name))]

- Normalde bireçok olacak olan ilişkinin Birebir olduğunun aslında tanımlanan Unique index sayesinde garantisini sağlamış oluyor. Yani bir index oluşturuyor.

- Bizler herhangi bir foreign key kolonuna ihtiyaç duymadan direkt dependent entity'deki Id kolonunu hem Primary Key Hem de Foreign Key olarak kullanabiliriz. Böylece primary key olduğundan dolayı Unique özelliğini kullanabiliriz. Hem de foreign key sayesinde diğer entity ile one to one ilişkilendirebiliriz.

- Böylelikle daha az maliyet olacaktır. Çünkü bu özellik sayesinde hem ekstradan constraint index vs tanımlamaksızın maliyeti düşürmüş olacağız hem de ekstradan bir kolona gerek duymaksızın verisel maliyeti düşürmüş olacağız

- Birebir ilişkilerde dependent entity'nin Id'sini mümkün mertebe primary key ve foreign key olarak kullanmaya özen göstermekte fayda var 

- Birebir ilişkilerde direkt Id bazlı ilişki kurmaya özen gösterin
```C#
class Calisan
{
    public int Id { get; set; }
    public string Adi { get; set; }

    public CalisanAdresi CalisanAdresi { get; set; }
}
class CalisanAdresi
{
    [Key,ForeignKey(nameof(Calisan))]
    public int Id { get; set; }
    public string Adres { get; set; }

    public Calisan Calisan { get; set; }
}
```
***

<img src ="1.png" width ="auto">

***

# Fluent API
- Yine navigation property'ler tanımlı olmalıdır.

- Fluent API yönteminde entity'ler arasındaki ilişki context sınıfı içersinde OnModelCreating fonksiyonunun override edilerek metotlar aracılığıyla tasarlanması gerekmektedir. Yani tüm sorumluluk bu fonksiyon içerisindeki çalışmalardadır.

```C#
 //Model'ların(entity) veritabanında generate edilecek yapıları bu fonksiyonda içerisinde konfigüre edilir
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CalisanAdresi>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<Calisan>()
             .HasOne(c => c.CalisanAdresi)
             .WithOne(c => c.Calisan)
             .HasForeignKey<CalisanAdresi>(c => c.Id);
    }
```


```C#
class Calisan
{
    public int Id { get; set; }
    public string Adi { get; set; }

    public CalisanAdresi CalisanAdresi { get; set; }
}
class CalisanAdresi
{
    public int Id { get; set; }
    public string Adres { get; set; }

    public Calisan Calisan { get; set; }
}
```
```C#
class ESirketDbContext : DbContext
{
    public DbSet<Calisan> Calisanlar { get; set; }
    public DbSet<CalisanAdresi> CalisanAdresleri { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=ESirketDB;Trusted_Connection = true;");
    }
    //Model'ların(entity) veritabanında generate edilecek yapıları bu fonksiyonda içerisinde konfigüre edilir
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CalisanAdresi>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<Calisan>()
             .HasOne(c => c.CalisanAdresi)
             .WithOne(c => c.Calisan)
             .HasForeignKey<CalisanAdresi>(c => c.Id);
    }
}
```