# EF Core'da Neden Yapılandırmalara İhtiyacımız Olur?

- Herhangi bir sınıfı/kütüphaneyi/ ya da herhangi bir davranış gösteren sistemi ele alırken bu sistemde her daim default değerlerde bir davranış söz konusu olacaktır. Bizler yeri geldiğinde o sistemi özelleştirmek isteyebiliriz. Bu özelleştirmeninde kendine göre usülleri kendine göre yapıları vardır.

- EF Core ORM aracıdır ve birçok yapılanmayı kendi bünyesinde dahili olarak default bir şekilde barındırmaktadır. Esasında biz EF Core ile ilgili orta düzey bir çalışma yapacaksak eğer hiçbir şeyi yapılandırmaya gerek kalmaksızın geri kalanı EF Core halledecektir.

- Default davranışları yeri geldiğinde geçersiz kılmak ve özelleştirmek isteyebiliriz. Bundan dolayı yapılandırmalara ihtiyacımız olacaktır.

# OnModelCreating Metodu

- Bizim modellerimizle ilgili yapmış olduğumuz konfigürasyonları barındıran bir metot.

- EF Core'da yapılandırma deyince akla ilk gelen metot OnModelCreating metodudur.

- Bu metot DbContext sınıfı içerisinde virtual olarak ayarlanmış bir metottur.

- Biz bu metodu kullanarak model'larımızla ilgili temel konfigürasyonel davranışları(FLuent API) sergileyebiliriz.

- Bir model'ın oluşturuluşuyla ilgili tüm konfigürasyonları burada gerçekleştirebilmekteyiz.

- Sen bir migration operasyonu gerçekleştiriyorsan eğer migration oluşturulmadan önce bu OnModelCreating metodu bir interceptor gibi araya giriyor ve model'larla alakalı temel konfigürasyonel yapılanmaları artık migration'a zorluyor/sunuyor.

- Sizin yapmış olduğunuz konfigürasyonel çalışmaların hepsi migration'dan önce devreye giriyor.

# GetEntityTypes

- EF Core'da kullanılan entity'leri elde etmek, programatik olarak öğrenmek, yazılımsal olarak bir koleksiyonda elde etmek istiyorsak eğer GetEntityTypes fonksiyonunu kullanabiliriz.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       var entities = modelBuilder.Model.GetEntityTypes();
        foreach (var entity in entities)
        {
           Console.WriteLine(entity.Name);
        }
    }
```

# Configurations | Data Annotations & Fluent API

- İkisi aynı anda kullanılsa bile Fluent API son kararı verir yani Fluent API daha baskındır. Fluent API'ın dediği olur.

# Table - ToTable

- Generate edilecek tablonun ismini belirlememizi sağlayan yapılandırmadır.

- EF Core'da bir entity'e karşılık table'ı migrate ederken default olarak o tablonun ismi DbSet Property'sinden gelir.

- EF Core normal şartlarda generate edeceği tablonun adını DbSet property'sinden almaktadır. Bizler eğer ki bunu özelleştirmek istiyorsak Table attribute'unu yahut ToTable api'ını kullanabiliriz.

```C#
================> Data Annotation - Table <================
[Table("Kisiler")]
class Person
{
    public int Id { get; set; }
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public decimal Salary { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}

================> Fluent API - ToTable <================

protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().ToTable("Kisiler");
    }
```

# Column - HasColumnName, HasColumnType, HasColumnOrder

- EF Core'da tabloların kolonları entity sınıfları içerisindeki property'lere karşılık gelmektedir.

- Default olarak property'lerin adı kolon adıyken, türleri/tipleri kolon türleridir.

- Eğer ki generate edilecek kolon isimlerine ve türlerine müdahale etmek istiyorsak bu konfigürasyon kullanılır.

```C#
================> Data Annotation - Column <================
class Person
{
    public int Id { get; set; }
    public int DepartmentId { get; set; }

    [Column("Adi",TypeName ="metin",Order = 7)]
    public string Name { get; set; }

    public string Surname { get; set; }
    public decimal Salary { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}
================> Fluent API - HasColumnType, HasColumnOrder <================
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .Property(p=>p.Name)
            .HasColumnName("Adi")
            .HasColumnType("metin")
            .HasColumnOrder(7);
    }
```

# Foreign Key - HasForeignKey

- İlişkisel tablolarda Dependent entity'nin Principal entity'e karşı olan ilişkisel verisini tutan kolondur.

- İlişkisel tablo tasarımlarında, bağımlı tabloda esas tabloya karşılık gelecek verilerin tutulduğu kolonu foreign key olarak temsil etmekteyiz.

- EF Core'da foreign key klonu genellikle Entity Tanımlama kuralları gereği default yapılanmalarla oluşturulur.

- EF Core diyor ki bir navigation property'nin isminin yanına Id geliyorsa eğer ben bunu foreign key olarak algılarım.

- Fluent API üzerinden foreign key'i bildirebilmek için ekstradan iki tablo arasındaki ilişkiyi de ortaya koymamız gerekiyor.

- Yani burada ilk olarak buradaki ilişkiyi modellemem gerekiyor ki o modele göre Fluent API üzerinden bir Foreign Key yapısının olacağını bildirmem gerekiyor.

- ForeignKey Data Annotations Attribute'unu direkt kullanabilirsiniz. Lakin Fluent API ile bu konfigürasyonu yapacaksanız iki entity arasındaki ilişkiyide modellemeniz gerekmektedir. Aksi taktirde HasForeignKey fonksiyonunu kullanamazsınız.

```C#
================> Data Annotation - Foreign Key <================
class Person
{
    public int Id { get; set; }

    [ForeignKey(nameof(Department))]
    public int DId { get; set; }

    public string Name { get; set; }
    public string Surname { get; set; }
    public decimal Salary { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}
================> Fluent API - HasForeignKey <================
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasOne(p => p.Department)
            .WithMany(d => d.Persons)
            .HasForeignKey(p => p.DId); 
    }
```
# NotMapped - Ignore
- EF Core'da herahngi bir property'nin migrate edilmesini istemiyorsan o property'i yazılımsal amaçlı entity sınıfının içinde bulundurmak istiyorsan ya da farklı bir niyetle oluşturduysan ama bu entity'e karşılık oluşturulacak tablodaki kolonlara karşılık gelen bir property olmayacaksa bunu senin göremezden gelmen gerekecek.

- EF Core entity sınıfları içerisindeki tüm property'leri default olarak modellenen tabloya kolon şeklinde migrate eder.

- Bazen bizler entity içerisinde tabloda bir kolona karşılık gelmeyen propertyler tanımlamak mecburiyetinde kalabiliriz.

- Bu property'lerin EF Core tarafından kolon olarak map edilmesini istemediğimizi bildirebilmek i.in NotMapped ya da Ignore kullanabiliriz.

```C#
================> Data Annotation - NotMapped <================
class Person
{
    public int Id { get; set; }
    public int DId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public decimal Salary { get; set; }

    //Yazılımsal amaçla oluşturduğum bir property
    [NotMapped]
    public string Laylaylom { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}
================> Fluent API - Ignore <================
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .Ignore(p => p.Laylaylom);
    }
```
# Key - HasKey
- EF Core'da, default conventation olarak bir entity'nin içerisindeki Id,ID,EntityId,EntityID vs. şeklinde tanımlanan tüm propertylere varsayılan olarak Primary Key constraint uygulanır.

- key ya da HasKey yapılanmalarıyla istediğimiz herhangi bir proeprty'e default conventation dışında Primary Key constraint uygulayabiliriz.

- EF Core'da illaki bir entity'nin içerisinde Primary Key kolonu olmalı yoksa eğer bunu bildirmek zorundasın. 

- EF Core'da bir entity içerisinde kesinlikle Primary Key'i temsil edecek olan property bulunmalıdır. Aksi taktirde EF Core migration oluştururken hata verecektir. Eğer ki tablonun Primary Key'i yoksa bunun bildirilmesi gerekir.

```C#
================> Data Annotation - Key <================
class Person
{
    [Key]
    public int Id { get; set; }

    public int DId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public decimal Salary { get; set; }
    public string Laylaylom { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}
================> Fluent API - HasKey <================
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasKey(p => p.Id);
    }
```

# Timestamp - IsRowVersion
- İleride/sonarki derslerde veri tutarlılığı ile ilgili bir ders yapacağız.

- Veri tutarlılığı sürecinde bir verinin tutarlılığını sağlayacak küçük bir değer oluşturabiliriz. Ve belirli senaryolara göre bir satırın üzerinde yapılan değişikliği biz takip etmek isteyebiliriz tutarlılığı sağlayabilmek için işte buradaki veri TimeStamp/IsRowVersion ile sağlanacak bir veri olabilir. Yani verinin versiyonunu tutuyormuşuz gibi düşünelim.

- Verinin versiyonunu tutuyorsak eğer bu veride anlık olarak belirli senaryolara göre bir değişiklik olursa eğer versiyon değişikliğinden dolayı tutarsızlığa mahal vermemek için hata fırlatıyoruz.

- Bir satırdaki verinin bütünsel olarak değişikliğini takip etmemizi sağlayacak olan version mantığını konuşuyor olacağız.

- İşte bir verinin versionunu oluşturmamızı sağlanayn yapılanma bu konfigürasyondur.

```C#
================> Data Annotation - Timestamp <================
class Person
{
    public int Id { get; set; }
    public int DId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public decimal Salary { get; set; }
    //public string Laylaylom { get; set; }
    [Timestamp]
    public byte[] RowVersion { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}
================> Fluent API - IsRowVersion <================
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
           .Property(p => p.RowVersion)
           .IsRowVersion();
    }
```
# Required - IsRequired
- Bir kolonun nullable ya da not null olup olmamasını bu konfigürasyonla belirleyebiliriz.

- Data Annotation'larda değeri nullable yapabilmek için ? operatöründen faydalanılır.

- EF Core'da bir property default olarak not null şeklinde tanımlanır. Eğer ki property'si nullable yapmak istiyorsak türü üzerinde ?(nullable) operatörü ile bildirimde bulunmamız gerekmektedir.

```C#
================> Data Annotation - Required <================
class Person
{
    public int Id { get; set; }
    public int DId { get; set; }
    public string Name { get; set; }
    [Required]
    public string? Surname { get; set; }
    public decimal Salary { get; set; }
    
    public string Laylaylom { get; set; }
    public byte[] RowVersion { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}
================> Fluent API - IsRequired <================
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .Property(p => p.Surname)
            .IsRequired();
    }
```

# StringLength - MaxLength - HasMaxLength
- Bir kolonun Max karakter sayısını belirlememizi sağlar.
#endregion

```C#
================> Data Annotation - StringLength - MaxLength <================
class Person
{
    public int Id { get; set; }
    public int DId { get; set; }
    [StringLength(14)]
    public string Name { get; set; }

    [MaxLength(13)]
    public string? Surname { get; set; }

    public decimal Salary { get; set; }
    public string Laylaylom { get; set; }
    public byte[] RowVersion { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}
================> Fluent API - HasMaxLength <================
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .Property(p => p.Surname)
            .HasMaxLength(13);
    }
```

# Precision - HasPrecision
- Sayısal değerlerde kesinliği ortaya koymamızı sağlayan bir özellik

- Küsüratlı sayılarda bir kesinlik belirtmemizi ve noktanın hanesini bildirmemizi sağlayan bir yapılanmadır.

```C#
================> Data Annotation - Precision <================
class Person
{
    public int Id { get; set; }
    public int DId { get; set; }
    public string Name { get; set; }
    public string? Surname { get; set; }

    [Precision(5, 3)]
    public decimal Salary { get; set; }

    public string Laylaylom { get; set; }
    public byte[] RowVersion { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}
================> Fluent API - HasPrecision <================
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .Property(p => p.Salary)
            .HasPrecision(5, 3);
    }
```

# Unicode - IsUnicode
- İlgili kolon içerisinde unicode karakterler kullanılacaksa bu yapılandıramadan bu özellik sayesinde istifade edilebilir.

```C#
================> Data Annotation - Unicode <================
class Person
{
    public int Id { get; set; }
    public int DId { get; set; }
    public string Name { get; set; }

    [Unicode]
    public string? Surname { get; set; }

    public decimal Salary { get; set; }

    public string Laylaylom { get; set; }
    public byte[] RowVersion { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}
================> Fluent API - IsUnicode <================
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .Property(p => p.Surname)
            .IsUnicode();
    }
```

# Comment - HasComment
- Yorum eklemek istiyorsanız yapmış olduğunuz EF Core üzerinden oluşturmuş olduğunuz veritabanı nesnelerine belirli yorumlarda/açıklamalarda/descriptionlarda bulunmak istiyorsanız bu özelliği kullanabilirsiniz.

- EF Core üzerinden oluşturulmuş olan veritabanı nesneleri üzerinde bir açıklama/yorum yapmak istiyorsanız bu özelliği kullanabilirsiniz.
```C#
================> Fluent API - Comment <================
class Person
{
    public int Id { get; set; }
    public int DId { get; set; }
    public string Name { get; set; }
    public string? Surname { get; set; }
    public decimal Salary { get; set; }
    public string Laylaylom { get; set; }

    [Timestamp]
    [Comment("Bu şuna yaramaktadır...")]
    public byte[] RowVersion { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}
================> Fluent API - HasComment <================
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasComment("Bu tablo şuna yaramaktadır...")
            .Property(p => p.Surname)
            .HasComment("Bu kolon şuna yaramaktadır.");
    }
```

# ConcurrencyCheck - IsConcurrencyToken
- İleride/sonraki derslerde veri tutarlılığı ile ilgili bir ders yapacağız.

- Bu derste bir satırdaki verinin bütünsel olarak tutarlılığını sağlayacak bir concurrency token yapıalanmasından bahsedeceğiz. 

```C#
================> Fluent API - ConcurrencyCheck <================
class Person
{
    public int Id { get; set; }
    public int DId { get; set; }
    public string Name { get; set; }
    public string? Surname { get; set; }
    public decimal Salary { get; set; }
    public string Laylaylom { get; set; }
    public byte[] RowVersion { get; set; }

    [ConcurrencyCheck]
    public int ConcurrencyCheck { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}
================> Fluent API - IsConcurrencyToken <================
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .Property(p => p.ConcurrencyCheck)
            .IsConcurrencyToken();
    }
```

# InverseProperty
- İki entity arasındaki ilişkiyi iki kere yapma durumunda kalabiliriz.

- Örneğin uçakla havaalanı arasındaki ilişkiyi değerlendirirsek eğer bir uçağın kalktığı havaalanı birde uçağın indiği havaalanı vardır. Bu yüzden uçakla havalanı arasında iki kere ilişki ortaya koyulur.

- Foreign Key kolonunun aynı principal entity'den alınan bir çift olmasından dolayı hata fırlatır.

- İki entity arasında birden fazla ilişki varsa eğer bu ilişkilerin hangi Navigation Property'ler üzerinden olacağını ayarlamamızı sağlayan bir konfigürasyondur.

```C#
================> Fluent API - InverseProperty <================
class Flight
{
    public int FlightID { get; set; }
    public int DepartureAirportId { get; set; }
    public int ArrivalAirportId { get; set; }
    public string Name { get; set; }
    public Airport DepartureAirport { get; set; }
    public Airport ArrivalAirport { get; set; }
}
class Airport
{
    public int AirportID { get; set; }
    public string Name { get; set; }

    [InverseProperty(nameof(Flight.DepartureAirport))]
    public virtual ICollection<Flight> DepartingFlights { get; set; }

    [InverseProperty(nameof(Flight.ArrivalAirport))]
    public virtual ICollection<Flight> ArrivingFlights { get; set; }

}
================> Fluent API - InverseProperty <================
Eklenecek
```


<h1 style="color : GreenYellow"> Yaralanılan Entity Ve DbContext</h1> 

```C#
class Person
{
    //[Key]
    public int Id { get; set; }
    //[ForeignKey(nameof(Department))]
    public int DId { get; set; }
    //[Column("Adi",TypeName ="metin",Order = 7)]
    public string Name { get; set; }
    //[Required]
    //[MaxLength(13)]
    //[StringLength(13)]
    [Unicode]
    public string? Surname { get; set; }
    //[Precision(5, 3)]
    public decimal Salary { get; set; }
    //Yazılımsal amaçla oluşturduğum bir property
    //[NotMapped]
    public string Laylaylom { get; set; }
    [Timestamp]
    [Comment("Bu şuna yaramaktadır...")]
    public byte[] RowVersion { get; set; }

    [ConcurrencyCheck]
    public int ConcurrencyCheck { get; set; }

    public DateTime CreatedDate { get; set; }
    public Department Department { get; set; }
}
class Department
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Person> Persons { get; set; }
}
class ApplicationDbContext : DbContext
{
    //public DbSet<Department> Departments { get; set; }
    //public DbSet<Person> Persons { get; set; }
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Airport> Airports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region GetEntityTypes
        //var entities = modelBuilder.Model.GetEntityTypes();
        //foreach (var entity in entities)
        //{
        //    Console.WriteLine(entity.Name);
        //}
        #endregion
        #region ToTable
        //modelBuilder.Entity<Person>().ToTable("Kisiler");
        #endregion
        #region Column
        //modelBuilder.Entity<Person>()
        //    .Property(p=>p.Name)
        //    .HasColumnName("Adi")
        //    .HasColumnType("metin")
        //    .HasColumnOrder(7);
        #endregion
        #region ForeignKey
        //modelBuilder.Entity<Person>()
        //    .HasOne(p => p.Department)
        //    .WithMany(d => d.Persons)
        //    .HasForeignKey(p => p.DId);
        #endregion
        #region Ignore
        //modelBuilder.Entity<Person>()
        //    .Ignore(p => p.Laylaylom);
        #endregion
        #region Primary Key
        //modelBuilder.Entity<Person>()
        //    .HasKey(p => p.Id);
        #endregion
        #region IsRowVersion
        //modelBuilder.Entity<Person>()
        //    .Property(p => p.RowVersion)
        //    .IsRowVersion();
        #endregion
        #region IsRequired
        modelBuilder.Entity<Person>()
            .Property(p => p.Surname)
            .IsRequired();
        #endregion
        #region HasMaxLength
        //modelBuilder.Entity<Person>()
        //    .Property(p => p.Surname)
        //    .HasMaxLength(13);
        #endregion
        #region HasPrecision
        modelBuilder.Entity<Person>()
            .Property(p => p.Salary)
            .HasPrecision(5, 3);
        #endregion
        #region IsUnicode
        modelBuilder.Entity<Person>()
            .Property(p => p.Surname)
            .IsUnicode();
        #endregion
        #region HasComment
        modelBuilder.Entity<Person>()
            .HasComment("Bu tablo şuna yaramaktadır...")
            .Property(p => p.Surname)
            .HasComment("Bu kolon şuna yaramaktadır.");
        #endregion
        #region IsConcurrencyToken
        modelBuilder.Entity<Person>()
            .Property(p => p.ConcurrencyCheck)
            .IsConcurrencyToken();
        #endregion
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDb;User ID=SA; Password=1q2w3e4r!.;");
    }
}

class Flight
{
    public int FlightID { get; set; }
    public int DepartureAirportId { get; set; }
    public int ArrivalAirportId { get; set; }
    public string Name { get; set; }
    public Airport DepartureAirport { get; set; }
    public Airport ArrivalAirport { get; set; }
}
class Airport
{
    public int AirportID { get; set; }
    public string Name { get; set; }
    [InverseProperty(nameof(Flight.DepartureAirport))]
    public virtual ICollection<Flight> DepartingFlights { get; set; }
    [InverseProperty(nameof(Flight.ArrivalAirport))]
    public virtual ICollection<Flight> ArrivingFlights { get; set; }
}
```