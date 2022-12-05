using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Reflection;

ApplicationDbContext context = new();
#region Query Log Nedir?
//EF Core üzerinden yapmış olduğumuz sorguları loglamamızı sağlayan bir mekanizmadır. 
//Logu sorgu seviyesinde tutmamızı sağlayan bir mekanizmadır.
//LINQ sorguları neticesinde Generate edilen sorguları izleyebilmek ve olası teknik hataları ayıklayabilmek amacıyla bizler Query Log mekanizmasından istifade ederiz.
//EF Core üzerinden oluşturmuş olduğumuz sorguları bakıp, gözlemleyip, optimize etmek isteyebiliyoruz. Oluşturduğumuz sorguları optimize ederek daha az maliyetli ve daha yüksek performanslı bir hale getirmek istediğimiz durumlarda bu sorguları görebilmek için loglamamız gerekiyor.
//EF Core üzerinden yapmış olduğumuz çalışmalar neticesinde Generate edilen sorguları gözlemlemek istiyorsak bunları Query Log mekanizması sayesinde rahatlıkla loglayabiliriz.
#endregion
#region Nasıl Konfigüre Edilir?
//Query Log'u kullanabileceğimiz ortamı belirleyebilmek. Yani sen query'lerini nereye loglayacaksan o ortamı seçeceksin. 
//Örneğin Console'da loglayacaksan ona göre konfigürasyon gerçekleştireceksin.
//Microsoft.Extensions.Logging.Console

await context.Persons.ToListAsync();

await context.Persons
    .Include(p => p.Orders)
    .Where(p => p.Name.Contains("a"))
    .Select(p => new { p.Name, p.PersonId }).ToListAsync();
#endregion
#region Filtreleme Nasıl Yapılır?
//Query Loglama mekanizmasını kullanırken bazen bazı özellikleri filtreleyerek elemek isteyebiliriz. Ya da default olan konfigürasyonların dışına çıkarak kendimize göre bir filtre uygulayabiliriz.
//Filtreleme işlerini LoggerFactory üzerinden gerçekleştiririz.Hangi ortamda loglamayı gerçekleştiriyorsak gerçekleştirelim farketmiyor builder üzerinden AddFilter metodunu çağırmamız gerekiyor.
//AddFilter fonksiyonu ile hangi konfigürasyonun hangi filtrelerin yapıldığüını bildireceğiz bundan sonra hangi ortamda loglama gerçekleştirilecekse o filtreye uygun bir şekilde gerçekleştirilecektir.
//Yani filtreleme mekanizması ortamdan bağımsız bir şekilde çalışacaktır.
#endregion
//Buradaki önemli olan nokta oluşturulan/Generate edilen sorguları görebilmek/gözlemleyebilmek ve Optimize edebilmek gayesiyle bunları loglayarak çalışmalarımızı gerçekleştiriyoruz.

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
    .AddFilter((category, level) =>
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