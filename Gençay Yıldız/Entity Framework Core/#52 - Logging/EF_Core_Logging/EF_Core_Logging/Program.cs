using Microsoft.EntityFrameworkCore;
using System.Reflection;


ApplicationDbContext context = new();
var datas = await context.Persons.ToListAsync();
#region Neden Loglama Yaparız?
//Hangi sistem olursa olsun ilgili sistemin runtime'da/çalışam zamanında/operasyon süreçlerinde nasıl davrandığını takip edebilmek/gözlemleyebilmek istiyorsanız burada loglama mekanizmalarından istifade ediyoruz.
//Çalışan bir sistemin runtime'da nasıl davranış gerçekleştirdiğini gözlemleyebilmek için log mekanizmalarından istifade ederiz.
//Log deyince aklımıza yaşamsal takip mekanizması gelecek.
//Yazılımında herhangi bir zaman dilimindeki/zarfındaki günlüğünü tutan mekanizmadır.
#endregion
#region Neleri Loglarız?
//Hemen hemen her şeyi loglamaya çalışırız.
//Herhangi bir uygulamada loglama yapıyorsak ne zaman ki bu uygulama açıldı/ne zaman bu uygulamada herhangi bir istek yapıldı/ne zaman hata alındı/kullanıcı yetkisiz erişim göstermeye çalıştığı bir davranışta bulundu bunun gibi bütün davranışları loglamaya çalışırız.
//Mümkün mertebe log bize süreçte bu yazılımla ilgili nasıl bir iz bırakılmış neler yapılmış bunları bize verebilecek kadar detaylı olabilmesi için çabalarız. 
//Burdaki detayın sınırı yoktur. Yapılacak işe ve işin hassasiyetine bağlıdır.
//Yapılan sorguların çalışma süreçlerindeki davranışları/Sorgu süreçlerinde alınan hataları/Hangi verilerin EF Core mekanizması tarafından takibe alındığını vs bunları logluyoruz.
//Gerekirse hassas veriler üzerinde de loglama işlemleri gerçekleştiriyoruz.
#endregion
#region Basit Olarak Loglama Nasıl Yapılır?
//Minimum yapılandırma gerektirmesi.
//Herhangi bir nuget paketine ihtiyaç duyulmaksızın loglamanın yapılabilmesi.
//EF Core'da loglama ile ilgili konfigürasyonu OnConfiguring metodunda gerçekleştiriyoruz.
#region Debug Penceresine Log Nasıl Atılır?
//Uygulamayı bu vaziyette çalıştırdığınızda kullanmış olduğunuz IDE'nin Debug penceresinde gerekli logları görebilirsiniz.
#endregion
#region Bir Dosyaya Log Nasıl Atılır?
//Normalde console yahut debug pencerelerine atılan loglar pek takip edilebilir nitelikte olmamaktadır.
//Logları kalıcı hale getirmek istediğimiz durumlarda en basit haliyle bu logları harici bir dosyaya atmak isteyebiliriz.
//Stream yapıları kullanırken bunları kapatmayı unutmamalıyız. Çünkü bir dosyayı Stream ile tüketiyorsak eğer farklı bir uygulama ya da işletim sistemi ya da kullanıcı tarafından bu dosyanın kullanılabilir kılınması için bu stream'den kopması gerekecek. Bunu dispose etmemiz gerekecektir.
#endregion
#endregion
#region Hassas Verilerin Loglanması - EnableSensitiveDataLogging
//EF Core varsayılan/default ayarlarda herhangi bir veriyi log'a işlemez. Çünkü EF Core hangi verinin bizim için hassasiyet/kritik arz ettiğini bilemiyecektir. Dolayısıyla bunlardan herhangi birisini log'a işleyip dış dünyaya açarak bizi bu şekilde riske sürmek istemecektir. Bundan dolayı default bir şekilde herhangi bir veriyi dışa aktarmayacaktır.
//Haliyle bizler bazen loglama da hangi noktalarda verilerle işlemler yapıldığına dair bilgiler elde etmek isteyebiliriz. İşte bunu istiyorsak bununla ilgili talimatı iradeli bir şekilde bildirmemiz gerekiyor.
//Default olarak EF Core logm mesajlarında herhangi bir verinin değerinin içermemektedir. Bunun nedeni, gizlilik teşkil edebilecek verilerin loglama sürecinde yanlışlıkla da olsa açığa çıkmamasıdır.
//Verileri yetkili kişiler görebilir ama logu o veriden bağımsız yetkiye sahip bir kişi de görebilir dolayısıyla biz loga herhangi bir hassas veriyi işlemek istemeyiz.
//Bazen alınan hatalarda verinin değerini bilmek hatayı debug edebilmek için oldukça yardımcı olabilmektedir. Bu durumda hassas verilerinde loglamasını sağlayabiliriz.
//Hangi verinin ChangeTracker mekanizması tarafından takip edildiğini log üzerinde görebiliriz.Bu veri debug süercinde benim işimi kolaylaştırabilir amma velakin tehlikelidir. 
#endregion
#region Exception Ayrıntısını Loglama - EnableDatailedErrors
//Hata durumlarında da gerekli loglama işlemlerini gerçekleştirebiliyoruz.
//Exceptionları detaylı loglama yapmak istiyorsak eğer EnableDatailedErrors metodunu kullanmalıyız.
//Log mekanizmasında veritabanına erişimeme durumu söz konusu olduğunda bunu loglardan daha rahat bir şekilde algılayabiliyoruz. Bazen veritabanı ile ilgili bağlantı kopuklukları söz konusu olabiliyor/veritabanı sunucusunda problem olabiliyor yaptığımız herhangi bir hata söz konusu olabiliyor/bağlantıyı etkileyen hatalarda olabiliyor bunları loglardan takip edebiliyoruz.
#endregion
#region Log Levels
//EF Core default olarak debug'ın üstündeki bütün levellardaki hata durumlarını/davranışların hepsini loglamaktadır.
//Hangi seviyede ki logları görmek istediğimizi belirleyebiliyoruz. Böylece loglama süreçlerinde bir filtreleme de gerçekleştirebiliyoruz.
//Bu filtreleme önemlidir. Logu sade tutmak anlık müdahale sreçlerinde gerektiği taktirde hızlıca problemi algılayıp aksiyon almanızı sağlayacaktır. Onun için ne var ne yok her şeyi loglamanın bir manası yok.
//Hatta bazen bazı uygulamalarda EF Core'da log seviyesini hata ya da warning seviyesine çektik ki direkt varsa bir hata böyle kritik seviyede ilgilendiren bir durum söz konusuysa onu logla kardeşim diğerleri önemli değil.
//Hızlı aksiyon alabilmek için LogLevel'ı iyi ayarlamak önemli.
//EF Core default olarak Debug seviyesinin üstündeki(debug dahil) tüm davranışları loglar.
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
public class ApplicationDbContext : DbContext
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
    StreamWriter _log = new("logs.txt", append: true);


    protected override async void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDB;User ID=SA;Password=1q2w3e4r!.;TrustServerCertificate=True");

        //optionsBuilder.LogTo(Console.WriteLine);
        //optionsBuilder.LogTo(message => Debug.WriteLine(message));
        optionsBuilder.LogTo(async message => await _log.WriteLineAsync(message),Microsoft.Extensions.Logging.LogLevel.Information).EnableSensitiveDataLogging().EnableDetailedErrors();
        //optionsBuilder.LogTo(message =>  _log.WriteLine(message));
    }

    public override void Dispose()
    {
        base.Dispose();
        _log.Dispose();
    }
    public override async ValueTask DisposeAsync()
    {
        await _log.DisposeAsync();
        await base.DisposeAsync();

    }
}