using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Reflection;

ApplicationDbContext context = new();

#region Query Tags Nedir?
//EF Core ile Generate edilen sorgulara açıklama satırları eklememizi sağlayan bir özelliktir.
//EF Core ile Generate edilen sorgulara açıklama eklememizi sağlayarak; SQL Profiler, Query Log vs. gibi yapılarda bu açıklamalar eşliğinde sorgualrı gözlemlememizi sağlayan bir özelliktir.

await context.Persons.ToListAsync();
#endregion
#region TagWith Metodu
//TagWith metodu Query Tags özelliğinin işlevsel aparatıdır.
//Sorguyu oluşturuken, sorgu kısmındayken TagWith fonksiyonunu kullanabilirsiniz.
//ToListAsync fonksiyonu ilgili sorguyu Execute edeceğinden dolayı yani Execute edip sorgu neticesini yazılım/bellek kısmına alacağından dolayı TagWith fonksiyonunu bu metottan sonra kullanamazsınız.
//TagWith ya DbSet ya da IQueryable türleri üzerinde çağrılabilir bir niteliğe sahiptir.
//Yani sorgu sorgu aşamasındayken daha IQueryable'ken TagWith'i kullanabiliyorsunuz ki Execute ederken bu açıklama satırıyla birlikte Execute edebilesiniz.
//TagWith ile eklemiş olduğumuz açıklama satırını sorguları görselleştirdiğimiz tüm platformlarda rahatlıkla okuyabiliyoruz.

await context.Persons.TagWith("Örnek Bir Açıklama").ToListAsync();
#endregion
#region Multiple TagWith
//TagWith metodunu biz birden fazla noktada kullanabiliyoruz. Yani bir query'ye birden fazla açıklama satırı girebiliyoruz.
//TagWith'i çoklu şekilde kullanabilmekteyiz.Yani bir sorguya birden fazla açıklama satırı burada olduğu gibi ekleyebilmekteyiz.
//İdeal olan sorguyu yönetilebilirliğini çok fazla bölmeksizin TagWith'i mümkün mertebe az olacak şekilde kullanmaktır.

await context.Persons.TagWith("Tüm Personeller çekilmiştir.")
    .Include(p=>p.Orders).TagWith("Personellerin yaptığı satışlar sorguya eklenmiştir.")
    .Where(p=>p.Name.Contains("a")).TagWith("Adında 'a' harfi olan personeller filtrelenmiştir.")
    .ToListAsync();
#endregion
#region TagWithCallSite Metodu
//Oluşturulan sorguya bir açıklama satırı ekleyecektir. Bu sorgunun ilgili cs dosyasında hangi satırda üretildiğini bizlere bilgi olarak verecektir. Yani açıklama satırında ekstradan satır bilgisini de eklemiş olacaktır.
//Oluşturulan sorguya açıklama satırı ekler ve ek olarak bu sorgunun bu dosyada(.cs) hangi satırda üretildiğinin bilgisini de verir.

await context.Persons.TagWithCallSite("Tüm Personeller çekilmiştir.")
    .Include(p => p.Orders).TagWithCallSite("Personellerin yaptığı satışlar sorguya eklenmiştir.")
    .Where(p => p.Name.Contains("a")).TagWithCallSite("Adında 'a' harfi olan personeller filtrelenmiştir.")
    .ToListAsync();
#endregion

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
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<Person>()
            .HasMany(p => p.Orders)
            .WithOne(o => o.Person)
            .HasForeignKey(o => o.PersonId);
    }
    readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder
    .AddFilter((category,level) =>
    {
        return category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information;
    })
    .AddConsole());
    protected override async void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDB;User ID=SA;Password=1q2w3e4r!.;TrustServerCertificate=True");
        optionsBuilder.UseLoggerFactory(loggerFactory);
    }
}