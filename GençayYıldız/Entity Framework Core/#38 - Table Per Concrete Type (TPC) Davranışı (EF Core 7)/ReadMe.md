
# Table Per Concrete Type (TPC) Nedir?
- Hiyerarşik ilişkiye sahip olan entity yapılanmalarında sadece concrete type'lara karşılık bir tablo oluşturan davranıştır.

- TPC davranışı kalıtımsal ilişkiye sahip olan entitylerin olduğu çalışmalarda sadece concrete/somut olan entity'lere karşılık bir tablo oluşturacak davranış modelidir.

- TPC, TPT'nin daha performanslı versiyonudur.

- TPC'de super/ata class'ların/sınıfların memberlarının her biri alt/subclass/derived class'lar için tanımlanan veritabanı tablolarına kayıt gerçekleşecektir. Yani her bir member için bir kolon oluşacaktır Tüm tablolarda.

- EF core kalıtılmış entitylerin Primary key(Id) alanı için Base classın adında bir "sequence" oluşturuyor. (PersonSequence) 

- Concrete Typelar için oluşturulan tabloların Id fieldlarında da default value için  "NEXT VALUE FOR [PersonSequence]" diyerek kullanıyor. 

- Bu  yüzden her tablonun Id fieldı sıralı artan bir şekilde olmuyor. Aslında tek bir sıralı artan kaynaktan besleniyor. Sequencelerin amacı da bu.

# TPC Nasıl Uygulanır?
- Hiyerarşik düzlemde abstract olan yapılar üzerinden OnModelCreating Entity fonksiyonuyla kanfigürasyona girip ardından UseTpcMappingStrategy fonksiyonu eşiliğinde davranışın TPC olacağını belirleyebiliriz.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Person>().UseTpcMappingStrategy();
}
```

# TPC'de Veri Ekleme

```C#
await context.Technicians.AddAsync(new() { Name="Musa",Surname="Uyumaz", Branch="Yazılım",Department="Yazılım Departmanı"});
await context.Technicians.AddAsync(new() { Name = "Mustafa", Surname = "Uyumaz", Branch = "Yazılım", Department = "Yazılım Departmanı" });
await context.Technicians.AddAsync(new() { Name = "Hilmi", Surname = "Uyumaz", Branch = "Yazılım", Department = "Yazılım Departmanı" });
await context.SaveChangesAsync();
```

# TPC'de Veri Silme
```C#
Technician? silinecek = await context.Technicians.FindAsync(2);
context.Technicians.Remove(silinecek);
await context.SaveChangesAsync();
```

# TPC'de Veri Güncelleme
```C#
Technician? guncellenecek = await context.Technicians.FindAsync(3);
guncellenecek.Name = "Ahmet";
await context.SaveChangesAsync();
```

# TPC'de Veri Sorgulama
```C#
var datas = await context.Technicians.ToListAsync();
```

# DbContext Ve Entities
```C#
abstract class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }

}
class Employee : Person
{
    public string? Department { get; set; }

}
class Customer : Person
{
    public string? CompanyName { get; set; }

}
class Technician : Employee
{
    public string Branch { get; set; }
}
class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Technician> Technicians { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //TPT
        //modelBuilder.Entity<Person>().ToTable("Persons");
        //modelBuilder.Entity<Employee>().ToTable("Employees");
        //modelBuilder.Entity<Customer>().ToTable("Customers");
        //modelBuilder.Entity<Technician>().ToTable("Technicians");
        modelBuilder.Entity<Person>().UseTpcMappingStrategy();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDB;User ID=SA;Password=1q2w3e4r!.;TrustServerCertificate=True");
    }
}
```