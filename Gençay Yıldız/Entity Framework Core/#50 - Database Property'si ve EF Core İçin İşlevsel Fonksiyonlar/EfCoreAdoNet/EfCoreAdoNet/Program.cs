using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Data.Common;
using System.Reflection;

ApplicationDbContext context = new();
#region Database Property'si
//EF Core çalışmalarında yazılım üzerinde DbContext nesnesi üzerinden operasyonlarımızı yürütüyoruz.
//Veritabanındaki transaction yapılanmasını EF Core bizim yerimize yönetiyor. Biz bazen bu transaction'a müdahale etmek isteyebiliriz. İşte buna müdahale edebilememiz için bize anahtarı sağlayan property Database property'sidir.
//Database property'si veritabanını temsil eden ve EF Core'un bazı işlevlerinin detaylarına erişmemizi sağlayan bir property'dir.
//Bir yazılımı runtime'da ayağa kaldırırken veritabanıyla ilgili operasyonları gerçekleştirmek istiyorsan bu property'den yararlanıyorsun.
#endregion
#region BeginTransaction
//EF Core transaction kontrolünü kendisi üstlenir.
//EF Core'da çalışma gerçekleştirirken transaction'ı manuel bir şekilde yönetmek istiyorsanız burada begin transaction fonksiyonu üzerinden ipleri elinize alabilirsiniz.

//IDbContextTransaction transaction =  context.Database.BeginTransaction();

//Burada ne yapıyorsam artık bu transaction üzerinden gerçekleştirmiş olacağım
//Artık EF Core'un otomatik olarak yönetmiş olduğu transaction yapılanmasını manuel olarak ele almış olduk. Yani biz buradaki transaction üzerinde herhangi bir veriyi veritabanına eklediysem bunu commit etmem gerekiyor. Ya da bunu geri almam gerekiyorsa Rollback etmem gerekiyor. Yani buradaki süreçlerin hepsini bizim manuel bir şekilde gerçekleştirmemiz gerekiyor.
//EF Core transaction yönetimini otomatik bir şekilde kendisi gerçekleştirmektedir. Eğer ki transaction yönetimini manuel olarak anlık ele almak istiyorsak BeginTransaction fonksiyonunu ele kullanabiliriz..
#endregion
#region CommitTransaction
//Başarılı bir yapılan işlem neticesinde transaction'ı başarılı kılmamızı yani commit etmemizi sağlayan bir fonksiyondur.

//context.Database.CommitTransaction();

//Database üzerinden yapılan operasyonlarda bir commit işlemine ihtiyacımız varsa eğer bunun için CommitTransaction metodunu kullanabiliriz.
// Transaction'ın tamamlandığını ve gerçekleştirilen transaction işlemlerinin kalıcı olarak veritabanına yansıtılması için kullanılır.
//EF Core üzerinde yapılan çalışmaların commit edilebilmesi için kullanılan bir fonksiyondur.
#endregion
#region RollbackTransaction
//EF Core üzerinde yapmış olduğumuz çalışmaları geri almamızı geri almak istiyorsak RollbackTransaction metodunu kullanabiliriz.
//Transaction’ın gerçekleştirdiği tüm işlemleri geri almak için kullanılır. Yani, yapılan tüm işlemler transaction’ın başlangıcındaki haline geri döner.
//EF Core üzerinde yapılan çalışmaların rollback edilebilmesi için kullanılan bir fonksiyondur.

//context.Database.RollbackTransaction();

#endregion
#region CanConnect
//EF Core'da veritabanı bağlantı kısmı, bu bağlantının açılması/kontrol edilmesi gibi operasyonları otomatize eder.
//Arka planda bir bağlantı/connection açılıyor. İşte bu connection'ın sağlanıp sağlanmadığına dair bilgiyi biz CanConnect fonksiyonu üzerinden elde edebiliyoruz.

//bool connect = context.Database.CanConnect();
//Console.WriteLine(connect);

//Bu kontrolden sonra bağlantı operasyonlarını devreye sokabilirsin.Buradaki bağlantı sorumluluğunu üstlenmek istiyorsan.
//Verilen connection string'e karşılık bağlantı kurulabilir bir veritabanı var mı yok mu bunun bilgisini bool türde veren bir fonksiyondur.
#endregion
#region EnsureCreated
//DbContext üzerinden yapmış olduğumuz veritabanı tasarımını veritabanı sunucusuna migration'lar üzerinden gönderiyoruz. Eğer ki sen migration kullanmayıp kod üzerinden ilgili veritabanını tasarımını direkt veritabanı sunucusuna yansıtmak istiyorsan burada EnsureCreated fonksiyonunu kullanabilirsin.
//Migrate işlemi yapmaksızını migration'ları kullanmaksızın context nesnesinin yapısına uygun tasarımına uygun bir veritabanı oluşturmak istiyorsam ve bunu kod üzerinden gerçekleştirmek istiyorsam runtime'da yapmak istiyorsam bunun için EnsureCreated fonksiyonunu kullanabilirim.

//context.Database.EnsureCreated();
//Console.WriteLine();
//DbContext nesnemizin içerisindeki veritabanı tasarımı her neyse ona uygun bir veritabanı arkada create edecektir. Yani bunu veritabanında oluşturacaktır.

//EF Core'da tasarlanan veritabanını migration kullanmaksızın, runtime'da yani kod üzerinde veritabanı sunucusuna inşa edebilmek için kullanılan bir fonksiyondur.
#endregion
#region EnsureDeleted
//Veritabanı sunucusunda inşa etmiş olduğumuz veritabanını silmek istiyorsak/kaldırmak istiyorsak ve bunu runtime'da gerçekleştirmek istiyorsak burada da EnsureDeleted fonksiyonunu kullanabiliriz.

//context.Database.EnsureDeleted();

//İnşa edilmiş bir veritabanını runtime'da silmemizi sağlayan bir fonksiyondur.
#endregion
#region GenerateCreateScript
//Context nesnesinin veritabanı tasarımı neyse ona uygun bir script'i bizlere verecektir.
//Context nesnesinde yapılmış olan veritabanı tasarımı her ne ise ona uygun bir SQL Script'ini string olarak veren metottur.

//var script = context.Database.GenerateCreateScript();
//Console.WriteLine(script);

//Veritabanını tasarlayabilmek için EF Core üzerinde ne yaptıysanız bunların hepsinin özetini sizlere SQL olarak vermiş olacaktır.
#endregion
#region ExecuteSql
//Bildiğiniz herhangi bir SQL sorgusunu Execute etmemizi sağlayan bir fonksiyondur.
//Insert, Update, Delete sorgularını hızlı bir şekilde yürütmemizi sağlayan bir fonksiyondur.
//Execute edeceğin veritabanında herhangi bir değişikliğe mahal vereceğin fonksiyonların çalışmalarını bu fonksiyon üzerinden işlenebilir.

//var result = context.Database.ExecuteSql($"INSERT Persons VALUES('Hüseyin')");

//Insert, Update, Delete fonksiyonlarını biz genellikle parametreler üzerinden yürütüyoruz.Haliyle parametrenin kullanıldığı fonksiyonlarda SQL Injection gibi açık durumları söz konusu olabiliyor. İşte ExecuteSql üzerinden sen bir Insert, Update ya da Delete operasyonu gerçekleştirirken SQL Injection'a maruz kalma diye burada Formattable String kullanılmaktadır.

//string name = Console.ReadLine();
//var result = context.Database.ExecuteSql($"INSERT Persons VALUES('{name}')");//Burada dışarıdan gelen verileri String Interpolation kullanarak içeriye basıyoruz. İşte burada kullanmış olduğun yapılanma ExecuteSql'de arka planda SQL Parameter'a dönüştürülüp o şekilde sorguya işleniyor. Haliyle bu şekilde yapılan çalışma neticesinde SQL Injection açıklarıda mimari tarafından kapatılmış oluyor. Eğer ki sen ExecuteSql değilde ExecuteSqlRaw fonksiyonu kullanıyorsan burada Sql Injection açıklarından sen sorumlu oluyorsun.
//Yani ExecuteSql burada String Interpolation'ı zorunlu tuttuğundan dolayı SQL Injection saldırılarına karşı önlemi kendisi default bir şekilde almış oluyor.
//Veritabanına yapıalcak Insert, Update, Delete sorgularını yazdığımız bir metottur. Bu metot işlevsel olarak alacağı parametreleri SQL Injection saldıralarına karşı korumaktadır.
#endregion
#region ExecuteSqlRaw
//Veritabanına yapıalcak Insert, Update, Delete sorgularını yazdığımız bir metottur. Bu metotta ise sorguyu SQL Injection saldıralarına karşı koruma görevi geliştiricinin sorumluluğundadır.
//string name = Console.ReadLine();
//var result = context.Database.ExecuteSqlRaw("INSERT Persons VALUES('{name}')");
//Burada String Polation zorunluluğu yok. Amma vealakin burada vermiş olduğum parametre artık arka planda güvenli bir çalışmaya tabi tutulmayacaktır. Buradaki SQL Injection açıklarına karşı gerekli önlemleri alma sorumuluğu geliştiriciye aittir.
#endregion
#region SqlQuery
//Select sorgularını metinsel olarak çalıştırmamızı sağlayan bir fonksiyondur.
//Bu fonksiyon ile EF Core'un DbSet property'leri üzerinden yapmış olduğu sorgulama davranışlarının dışına çıkıp anlık olarak kullandığımız uygulamanın genelinde kullanmayacağımız sorguları hızlıca veritabanında execute edip sonuçlarını elde edebiliyorduk. Çünkü SqlQuery ve SqlQueryRaw fonksiyonları EF Core'un eski sürümlerinde kaldırılıp bunların yerine DbSet property'leri üzerinden erişebildiğimiz FromSql fonksiyonları getirildi. Artık kullanılmamaktadır.
//SqlQuery fonksiyonu her ne kadar erişilebilir olsada artık desteklenmemektedir. Bunun yerine DbSet property'si üzerinden erişilebilen FromSql fonksiyonu gelmiştir/kullanılmaktadır.
#endregion
#region SqlQueryRaw
//SqlQueryRaw fonksiyonu her ne kadar erişilebilir olsada artık desteklenmemektedir. Bunun yerine DbSet property'si üzerinden erişilebilen FromSqlRaw fonksiyonu gelmiştir/kullanılmaktadır.
#endregion
#region GetMigrations
//EF Core üzerinden çalışma gerçekleştirirken veritabanıyla ilgili gelişimsel süreci Migration yapılanmaları üzerinden takip ediyoruz.
//Veritabanıyla ilgili yapmış olduğum kritik inşaların her birini bir migration'a aktararak programatik kayda alıyorum. İşte burada ne kadar migration oluşturduysak o migration'ların hepsini programatik olarak elde etmek istiyorsanız bu fonksiyonu kullanabilirsiniz.
//var migs = context.Database.GetMigrations();
//Console.WriteLine();
//Uygulamada üretilmiş olan tüm migration'ları runtime'da programatik olarak elde etmemizi sağlayan metottur.
#endregion
#region GetAppliedMigrations
//Uygulamada Migrate edilmiş olan tüm migrationları elde etmemizi sağlayan bir fonksiyondur.
//var appliedMigs = context.Database.GetAppliedMigrations();
//Console.WriteLine();
//O anda aktif olan en güncel olan uygulanmış olan migrationlar hangisiyse bize onları getirecektir.
#endregion
#region GetPendingMigrations
//Uygulamada Migrate edilmemiş olan tüm migrationları elde etmemizi sağlayan bir fonksiyondur.
//var appliedMigs = context.Database.GetPendingMigrations();
//Console.WriteLine();
#endregion
#region Migrate
//Runtime'da migration'ları Migrate etmek istiyorsanız bu fonksiyonu kullanabilirsiniz.
//Migration'ları programatik olarak runtime'da migrate etmek i.in kullanılan fonksiyondur.
//context.Database.Migrate();
//Migrate fonksiyonunu çağırdığınızda ne kadar migration varsa alayını sonuna kadar gönderecektir.
//Migrate fonksiyonu EnsureCreated fonksiyonuna benzerlik gösteriyor ama dikkat! EnsureCreated fonksiyonu migration'ları kapsamıyor yani Migration içinde tanımlamış olduğunuz View/Stored Procedure gibi yapılar EnsureCreated'da geçerli olmayacaktır.Amma vealkin Migrate'de geçerli olacaktır.
//EnsureCreated fonksiyonu migration'ları kapsamamaktadır. O yüzden migration'lar içerisinde yapılan çalışmalar ilgili fonksiyonda geçerli olmayacaktır.
#endregion
#region OpenConnection
//Bağlantıyı açmamızı sağlayan bir fonksiyondur.
//Veritabanı bağlantısını manuel açar.
context.Database.OpenConnection();
#endregion
#region CloseConnection
//Bağlantıyı kapatmamızı sağlayan bir fonksiyondur.
//Veritabanı bağlantısını manuel kapatır.
context.Database.CloseConnection();
#endregion
#region GetConnectionString
//EF Core ORM yapılanmasının kullanmış olduğu ConnectionString'i elde etmek istiyorsanız programatik olarak bu fonksiyondan istifade edebilirsiniz.
//İlgili context nesnesinin o anda kullandığı  ConnectionString değeri neyse onu elde etmenizi sağlar.
//Console.WriteLine(context.Database.GetConnectionString());
#endregion
#region GetDbConnection
//EF Core'un kullanmış olduğu Ado.NET altyapısının kullandığı DbConnection nesnesini elde etmemizi sağlayan bir fonksiyondur. Yaniiiiiiiii  bizleri Ado.NET kanadına götürür.
//Ado.NET'te yaptığınız tüm çalışmaları burada gerçekleştirebilirsiniz.
//Hangi provider'ı kullanıyorsan ona göre Connection'ın değişkenlik gösterecektir.

//SqlConnection connection = (SqlConnection)context.Database.GetDbConnection();
//Console.WriteLine();

//Kullandığınız veritabanının connection yapılanmasını/nesnesini getiren ve ondan sonra da onun üzerinden Ado.NET mimarisini kullanarak çalışma gerçekleştirmenizi sağlayan bir fonksiyondur.
//Connection nesnesini bu şekilde elde edip artık EF Core'u aradan çıkarıp temel seviyede operasyonlarımızı bu nesne üzerinden gerçekleştirebiliriz.
#endregion
#region SetDbConnection
//Kendine göre özelleştirdiğin bir DbConnection'ının varsa eğer ve EF Core yapılanmasının o connection üzerinden davranışı sergilemesini istiyorsun buradan ilgili connection'ı devreye sokabiliyorsun.
//Özelleştirilmiş connection nesnelerini EF Core mimarisine dahil etmemizi sağlayan bir fonksiyondur.

//context.Database.SetDbConnection(new NpgsqlConnection());
#endregion
#region ProviderName Property'si
//EF Core kullanırken arka planda hangi provider'ı kullandığımız esasında pek önemli değil. Amma velakin provider'ı öğrenmek istiyorsak ProviderName property'sinden istifade edebiliriz.
//EF Core'un kullanmış olduğu provider neyse onun bilgisini getiren bir property'dir.

//Console.WriteLine(context.Database.ProviderName);
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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDB;User ID=SA;Password=1q2w3e4r!.;TrustServerCertificate=True");
    }
}