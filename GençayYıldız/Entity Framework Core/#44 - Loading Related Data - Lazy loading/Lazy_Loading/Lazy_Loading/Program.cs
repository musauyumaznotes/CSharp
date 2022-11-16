using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Reflection;
using System.Runtime.CompilerServices;

ApplicationDbContext context = new();

#region Lazy Loading Nedir?
//Biz sorguyu oluşturyoruz verilerimizi çekiyoruz. Ne zamanki ilişkisel tabloları temsil eden Navigation Property'ler üzerinde bir işlem yapıyoruz işte o zaman ilgili tabloya özel bir sorgu oluşturuluyor veritabanında execute ediliyor ve bize sonuçlar geliyor. Yani anlayacağınız biz Lazy Loading'te İlişkisel tabloları temsil eden Navigation Property'lerde programatik olarak bir işlem yapmaya karar verdiğimiz anda sorgu arka planda oluşturuluyor execute ediliyor daha sonra olduğu için lazy/tembel bir süreç geçiriliyor. Ondan sonra veriler yüklenip Navigation Property üzerinden bize işlem yapma hakkı tanıyor.
//Bizler ne zaman ki herhangi bir sorgu neticesinde elde ettiğimiz verilerin üzerinden ilişkisel verileri kullanmak istiyorsak o anda o verilerin sorgularının oluşturulup execute edilip bu tarafa yüklenmesini sağlayan bir yaklaşım.
//Navigation Property'ler üzerinde bir işlem yapılmaya çalışıldığı taktirde ilgili property'nin/ye temsil ettiği/karşılık gelen tabloya özel bir sorgu oluşturulup execute edilmesini ve verilerin yüklenmesini sağlayan bir yaklaşımdır.

#endregion

//var employee = await context.Employees.FindAsync(2);
//Console.WriteLine(employee.Region.Name);

#region Proxy'lerle Lazy Loading?
//Microsoft.EntityFrameworkCore.Proxies
//Proxy ile ya da değil herahngi bir yaklaşımla Lazy Loading kullanıyorsanız Debug süreçlerinde yanılmaya düşebilirsiniz. Biz sorgulamayı yaptığımızda debug sürecinde bunlara baktığımızda Navigation Property'lere ait veriler bodoslama yüklenmiş oluyor.Demek ki biz Navigation Property üzerinden herhangi bir talepte bulunmasak dahi bu veriler yükleniyor diye düşünebilirsiniz/zannedebilirsiniz ki yanlıştır.
//Debug yaparken ilgili objenin içindeki property'lere bakıyorsun ya buradaki Navigation Proeprty'leri tetiklemiş oluyorsun işte bunlar tetiklendiği için aslında buradaki yapılanmanın esas sebebi, virtual'la alakalı runtime'da karar veriliyor bunun tetiklenmesi  haliyle sen property'lere bakarken bunları tetiklediğin için bunlarla ilgili sorgular arka planda oluşmuş oluyor.
//Lazy Loading'te tüm veriler top yekün belleğe yüklenmiyor sen Navigation Property'i tetikledikçe oradaki ihtiyacını belirttikçe verilerin belleğe yüklenmiş olacaktır. O verilere karşılık sorgular oluşturulacak execute edilecek ve yüklenmiş olacaktır.
#region Property'lerin Virtual Olması
//Eğer ki Proxy üzerinden Lazy Loading operasyonu gerçekleştiriyorsan Navigation Property'lerinizin virtual ile işaretlenmesi gerekmektedir. Aksi taktirde patlama meydana gelecektir.

#endregion
//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//{
//    optionsBuilder
//        .UseLazyLoadingProxies()
//        .UseSqlServer("Server=localhost, 1433;Database=ApplicationDb;User ID=SA;Password=1q2w3e4r!.;TrustServerCertificate=True");

//    //optionsBuilder.UseLazyLoadingProxies();
//}

//public class Employee
//{
//    public int Id { get; set; }
//    public int RegionId { get; set; }
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public int Salary { get; set; }
//    public virtual List<Order> Orders { get; set; }

//}
//public class Region
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public virtual ICollection<Employee> Employees { get; set; }
//}
//public class Order
//{
//    public int Id { get; set; }
//    public int EmployeeId { get; set; }
//    public DateTime OrderDate { get; set; }
//    public virtual Employee Employee { get; set; }
//}

//class ApplicationDbContext : DbContext
//{
//    public DbSet<Employee> Employees { get; set; }
//    public DbSet<Order> Orders { get; set; }
//    public DbSet<Region> Regions { get; set; }
//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
//    }
//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder
//            .UseLazyLoadingProxies()
//            .UseSqlServer("Server=localhost, 1433;Database=ApplicationDb;User ID=SA;Password=1q2w3e4r!.;TrustServerCertificate=True");

//        //optionsBuilder.UseLazyLoadingProxies();
//    }
//}
#endregion

#region Proxy Olmaksızın Lazy Loading?
//Proxy yapılanmasıyla Lazy Loading'i hızlıca kullanbiliyoruz amma velakin bazen proxy'leri desteklemeyen platformlarda çalışmamız gerekebilir işte böyle bir durumda manuel bir şekilde uygulamamız gerekebilir.Sen eğer ki ben Lazy Loading'i kullanacam uygulayacam diyorsan eğer bunu proxy'nin dışında da uygulamayabilmektesin.
//Proxy'ler tüm platformlarda desteklenmeyebilir. Böyle bir durumda manuel bir şekilde Lazy Loading uygulamak mecburiyetinde kalabiliriz. 
//Manuel yapılan Lazy Loading operasyonlarında Navigation Property'lerin virtual ile işaretlenmesine gerek yoktur.

#region ILazyLoaderInterface'i İle Lazy Loading
//Microsoft.EntityFrameworkCore.Abstractions

//var employee2 = await context.Employees.FindAsync(2);
// Console.WriteLine();
//public class Employee
//{
//    ILazyLoader _lazyLoader;
//    Region _region;
//    List<Order> _orders;
//    public Employee() { }
//    public Employee(ILazyLoader lazyLoader)
//        => _lazyLoader = lazyLoader;
//    public int Id { get; set; }
//    public int RegionId { get; set; }
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public int Salary { get; set; }
//    public List<Order> Orders
//    {
//        get => _lazyLoader.Load(this, ref _orders);
//        set => _orders = value;
//    }
//    public Region Region
//    {
//        get => _lazyLoader.Load(this, ref _region);
//        set => _region = value;
//    }
//}
//public class Region
//{
//    ILazyLoader _lazyLoader;
//    ICollection<Employee> _employees;
//    public Region() { }
//    public Region(ILazyLoader lazyLoader)
//        => _lazyLoader = lazyLoader;
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public ICollection<Employee> Employees
//    {
//        get => _lazyLoader.Load(this, ref _employees);
//        set => _employees = value;
//    }
//}
//public class Order
//{
//    ILazyLoader _lazyLoader;
//    Employee _employee;
//    public Order(ILazyLoader lazyLoader)
//        => _lazyLoader = lazyLoader;
//    public Order(){}

//    public int Id { get; set; }
//    public int EmployeeId { get; set; }
//    public DateTime OrderDate { get; set; }
//    public Employee Employee { 
//        get => _lazyLoader.Load(this,ref _employee);
//        set => _employee = value; }
//}

//class ApplicationDbContext : DbContext
//{
//    public DbSet<Employee> Employees { get; set; }
//    public DbSet<Order> Orders { get; set; }
//    public DbSet<Region> Regions { get; set; }
//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
//    }
//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder
//            .UseLazyLoadingProxies(false)
//            .UseSqlServer("Server=localhost, 1433;Database=ApplicationDb;User ID=SA;Password=1q2w3e4r!.;TrustServerCertificate=True");


//    }
//}


#endregion
#region Delegate İle Lazy Loading

//var employee = await context.Employees.FindAsync(2);
//Console.WriteLine();
//public class Employee
//{
//    Action<object, string> _lazyLoader;
//    Region _region;
//    List<Order> _orders;
//    public Employee() { }
//    public Employee(Action<object, string> lazyLoader)
//        => _lazyLoader = lazyLoader;
//    public int Id { get; set; }
//    public int RegionId { get; set; }
//    public string? Name { get; set; }
//    public string? Surname { get; set; }
//    public int Salary { get; set; }
//    public List<Order> Orders
//    {
//        get => _lazyLoader.Load(this, ref _orders);
//        set => _orders = value;
//    }
//    public Region Region
//    {
//        get => _lazyLoader.Load(this, ref _region);
//        set => _region = value;
//    }
//}
//public class Region
//{
//    Action<object, string> _lazyLoader;
//    ICollection<Employee> _employees;
//    public Region() { }
//    public Region(Action<object, string> lazyLoader)
//        => _lazyLoader = lazyLoader;
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public ICollection<Employee> Employees
//    {
//        get => _lazyLoader.Load(this, ref _employees);
//        set => _employees = value;
//    }
//}
//public class Order
//{
//    ILazyLoader _lazyLoader;
//    Employee _employee;
//    public Order(ILazyLoader lazyLoader)
//        => _lazyLoader = lazyLoader;
//    public Order() { }

//    public int Id { get; set; }
//    public int EmployeeId { get; set; }
//    public DateTime OrderDate { get; set; }
//    public Employee Employee
//    {
//        get => _lazyLoader.Load(this, ref _employee);
//        set => _employee = value;
//    }
//}
//static class LazyLoadingExtension
//{
//    public static TRelated Load<TRelated>(this Action<object, string> loader, object entity, ref TRelated navigation, [CallerMemberName] string navigationName = null)
//    {
//        loader.Invoke(entity, navigationName);
//        return navigation;
//    }
//}

//class ApplicationDbContext : DbContext
//{
//    public DbSet<Employee> Employees { get; set; }
//    public DbSet<Order> Orders { get; set; }
//    public DbSet<Region> Regions { get; set; }
//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
//    }
//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder
//            .UseLazyLoadingProxies(false)
//            .UseSqlServer("Server=localhost, 1433;Database=ApplicationDb;User ID=SA;Password=1q2w3e4r!.;TrustServerCertificate=True");


//    }
//}
#endregion
#endregion

#region N+1 Problemi
//Hangi LazyLoading mekanizmasını uygularsan uygula N+1 Problemi ortaya çıkar.
//Lazy Loading maliyetli bir yapılanmadır. Her bir tetiklenmeye karşılık tekrardan sorguyu üretip gönderdiğine şahit olacaksınız. Haliyle bu da ekstradan bir maliyet demektir. İşte bu maliyeti N+1 problemi olarak değerlendirilmektedir.
//Mümkün mertebe Lazy Loading'i kullanmamaya özen göstermeniz gerekir.
//Lazy Loading mümkün mertebe kaçınılması gereken bir ilişkisel veri yükleme operasyonudur. Çünkü maliyetlidir. Çünkü her bir Navigation Property'nin tetiklenmesinde arkada sorgu üretip bunları execute etmektedir.

var region = await context.Regions.FindAsync(1);
foreach (Employee employee in region.Employees)
{
    var orders = employee.Orders;
    foreach (var order in orders)
    {
        Console.WriteLine(order.OrderDate);
    }
}
#endregion

//Lazy Loading, kullanım açısından oldukça maliyetli ve performans düşürücü bir etkiye sahip yöntemdir. O yüzden kullanırken mümkün mertebe dikkatli olmalı ve özellikle navigation propertylerin döngüsel tetiklenme durumlarında Lazy Loading'i tercih etmemeye odaklanmalıyız. Aksi taktirde her bir tetikleme ye karşılık aynı sorguları üretip execute edecektir. Bu durumu N+1 Problemi olarak nitelendirmekteyiz.
//Mümkün mertebe, ilişkisel verileri eklerken Lazy Loading kullanmamaya özen göstermeliyiz.
public class Employee
{
    public int Id { get; set; }
    public int RegionId { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Salary { get; set; }
    public virtual List<Order> Orders { get; set; }
    public virtual Region Region { get; set; }
}
public class Region
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Employee> Employees { get; set; }
}
public class Order
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public DateTime OrderDate { get; set; }
    public virtual Employee Employee { get; set; }
}

class ApplicationDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Region> Regions { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies()
            .UseSqlServer("Server=localhost, 1433;Database=ApplicationDb;User ID=SA;Password=1q2w3e4r!.;TrustServerCertificate=True");

        //optionsBuilder.UseLazyLoadingProxies();
    }
}