using Microsoft.EntityFrameworkCore;
using System.Reflection;

ApplicationDbContext context = new();


#region Keyless Entity Types
//Normal entity typeler'a ek olarak primary key içermeyen query'lere karşı veritabanı sorguları yürütmek için kullanılan bir özelliktir Keyless Entity Types.
//EF Core üzerinde bir sorgulama yapıyorsak Entity'lere karşılık DbSet'ler üzerinden gerçekleştiririz.
//Normal Entity'lerdeki sorgulamalar bir yana bizler bazen yapmış olduğumuz çalışmalarda/yazılımlarda özel sorgular üretebiliyoruz. Bu sorgular group by, pivot table, aggregate sorguların kullanıldığı farklı sorgulardır, istatiksel çalışmalardır, yani yapmış olduğumuz bu tarz türlü türlü sorgular neticesinde herhangi bir entity'e karşılık gelmeyen sonuçlar elde edecek query'ler üretebiliyoruz.
//Bazen kendimize özel komleks sorgular üretip execute ettiğimizde böyle belirli formatlarda sonuçlar elde edebiliyoruz. İşte bu sonuçlar genellikle Primary Key içermeyen query'lerdir. İşte bu tarz sorguları yapmamızı sağlayan yapılardır.
//Genellikle aggregate operasyonların yapıldığı group by yahut pivot table gibi işlemler neticesinde elde edilen istatiksel sonuçlar primary key kolonu barındırmazlar. Bizler bu tarz sorguları Keyless Entity Types özelliği ile sanki bir entity'e karşılık geliyormuş gibi çalıştırabiliriz.
#endregion

#region Keyless Entity Types Tanımlama
//1. Hangi sorgu olursa olsun EF Core üzerinden bu sorgunun bir entity'e karşılık geliyormuş gibi işleme/execute'a/çalıştırmaya tabi tutulabilmesi için o sorgunun sonucunda bir entity'nin yine de tasarlanması gerekmektedir.
//2. Bu Entity'nin DbSet property'si olarak DbContext nesnesine eklenmesi gerekmektedir.
//3. Tanımlamış olduğumuz entity'e OnModelCreating fonksiyonu içerisinde girip bunun bir Key'i olmadığını bildirmeli (HasNoKey) ve hangi sorgunun çalıştırılacağıda ToView vs. gibi işlemlerle ifade edilmelidir.

var datas = await context.PersonOrderCounts.ToListAsync();
Console.WriteLine();

#region Keyless Attribute'u
//Yine aynı şekil kullandığın DbSet'e karşılık gelen yapılanmanın Keyless yani Primary Key'e sahip olmayacağını bildirir.
#endregion
#region HasNoKey Fluent API'ı
//Yine aynı şekil kullandığın DbSet'e karşılık gelen yapılanmanın HasNoKey yani Primary Key'e sahip olmayacağını bildirir.
#endregion
#endregion
#region Keyless Entity Types Özellikleri Nelerdir?
//Primary Key kolonu OLMAZ!
//Change Tracker mekanizması aktif olmayacaktır.
//Table Per Hierarchy(TPH) olarak entity hiyerarşisinde kullanılabilir lakin diğer kalıtımsal ilişkilerde kullanılamaz!
#endregion

[Keyless]
public class PersonOrderCount
{
    public string Name { get; set; }
    public int Count { get; set; }
}
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
    public int Price { get; set; }

    public Person Person { get; set; }
}
class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<PersonOrderCount> PersonOrderCounts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<Person>()
            .HasMany(p => p.Orders)
            .WithOne(o => o.Person)
            .HasForeignKey(o => o.PersonId);

        modelBuilder.Entity<PersonOrderCount>()
            .HasNoKey()
            .ToView("vm_PersonOrderCount");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDB;User ID=SA;Password=1q2w3e4r!.;TrustServerCertificate=True");
    }
}