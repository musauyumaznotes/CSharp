# View Nedir?
- View oluşturmuş olduğumuz komplex sorguları her ihtiyaç olduğu zamanlarda her ihtiyaç noktasında tekrar tekrar oluşturmaktansa bunları bir view haline getirip rahat bir şekilde sorgulanabilir bir kıvama getirmemizi sağlayan veritabanı objesidir.

- View yapısal olarak bir tablo değildir. Ama tablosal işlemler yapmamızı sağlayan bir objedir.

- Oluşturduğumuz kompleks sorguları ihtiyaç durumlarında daha rahat b,r şekilde kullanabilmek için basitleştiren bir veritabanı objesidir.

- View yapılanması projelerde genellikle rapor yapılanmaları amaçlı kullanılır. 

- Yani biz veritabanından bir rapor elde etmek istiyorsak, Veritabanının bizzat MsSql'in raporlama mekanizmasını kullanacaksak buralarda view'lerden istifade ediliyor. 

- Çünkü rapor dediğimiz çıktı ağır bir sorgu neticesinde elde edildiği için her ihtiyaç olduğu durumlarda bu sorguları ağır olan sorguları tekrar tekrar çalıştırmaktansa bunları bir view haline getiriyorsunuz/ küçük sorgular haline getiriyorsunuz. Direkt o zaten arka planda devasa büyük boyuttaki sorguyu temsil eden küçük bir sorgu aracılığıyla çalışmalarınıza,istatiksel verilerinize,raporlama çalışmalarınıza devam edebiliyorsunuz.


# View Oluşturma
- 1. adım : Boş bir migration oluşturulmalıdır.

- 2. adım : Migration içerisindeki Up fonksiyonunda view'in create komutları, down fonksiyonunda ise drop komutları yazılmalıdır.

- 3. adım : Migrate ediniz.

```C#
protected override void Up(MigrationBuilder migrationBuilder)
{
    migrationBuilder.Sql($@"
                            CREATE VIEW vm_PersonOrders
                            AS
                            SELECT TOP 100 p.Name, COUNT(*) [Count] FROM Persons p 
                            Inner Join Orders o ON o.PersonId = p.PersonId
                            GROUP BY p.Name
                            ORDER BY [Count] DESC
                        ");
}

protected override void Down(MigrationBuilder migrationBuilder)
{
    migrationBuilder.Sql($@"DROP VIEW vm_PersonOrders");
}
```

# View'ı DbSet Olarak Ayarlama
- Veritabanından gelecek sonucu senin sorgulayabilipte karşılayabilmen için yani sorgu neticesinde gelecek olan verileri burada bir ORM mantığı gereği nesnelerle karşılayabilmen için o sonuca uygun entity'i oluşturmamız gerekiyor

- View'i EF Core üzerinden sorgulayabilmek için view neticesini karşılayabilecek bir entity oluşturulması ve bu entity türünden DbSet property'sinin eklenmesi gerekmektedir.

# DbSet'in Bir View Olduğunu Bildirmek

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    modelBuilder.Entity<PersonOrder>()
        .ToView("vm_PersonOrders")
        .HasNoKey();
}
```

# EF Core'da View'ların Özellikleri
- View üzerinde bizler LINQ sorgularını kullanarak sorguya katkıda bulunabiliriz.

- View'lerde Primary Key olmaz! Bu yüzden ilgili DbSet'in HasNoKey ile işaretlenmesi gerekmektedir.

- View neticesinde gelen veriler Change Tracker ile takip edilmezler. Haliyle üzerlerinde yapılan değişiklikleri EF Core veritabanına direkt SaveChanges metodu ile yansıtmaz.

# Entity & DbContext
```C#
public class Person
{
    public int PersonId { get; set; }
    public string Name { get; set; }

    public ICollection<Order> Orders { get; set; }
}
public class Order
{
    public int OrderId { get; set; }
    public int PersonId { get; set; }
    public string Description { get; set; }

    public Person Person { get; set; }
}

public class PersonOrder
{
    public string Name { get; set; }
    public int Count { get; set; }
}

class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<PersonOrder> PersonOrders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<PersonOrder>()
            .ToView("vm_PersonOrders")
            .HasNoKey();

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDb;User Id=SA;Password=1q2w3e4r!.;");
    }

}
```