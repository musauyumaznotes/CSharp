using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection;

Console.WriteLine();

#region OnModelCreating
//Genel anlamda veritabanı ile ilgili konfigürasyonel operasyonların dışında entity'ler üzerinde konfigürasyonel çalışmalar yapmamızı sağlayan bir fonksiyondur.
#endregion

#region IEntityTypeConfiguration<T> Arayüzü
//Entity'ler üzerinde yapmış olduğumuz konfigürasyonların her birini entity'e özel ayrı/harici dosyalarda tutup daha profesyonel çalışmalara imza atabilmekteyiz.
//OnModelCreating'te entity bazlı yapılan konfigürasyonları her bir entity'e özel bir dosyada yapmamızı sağlayacak olan arayüzdür.
//Entity bazlı yapılacak olan konfigürasyonları o entity'e özel harici bir dosya üzerinde yapmamızı sağlayan bir arayüzdür.
//Harici bir dosyada konfigürasyonların yürütülmesi merkezi bir yapılandırma noktası oluşturmamızı sağlamaktadır.
//Harici bir dosyada konfigürasyonların yürütülmesi entity sayısının fazla olduğu senaryolarda yönetilebilirliği arttıracak ve yapılandırma ile ilgili geliştiricinin yükünü azaltacaktır.
#endregion

#region ApplyConfiguration Metodu
//Bu metot bizim IEntityTypeConfiguration<T> arayüzünden türetip özelleştirilmiş konfigürasyonel sınıfların DbContext nesnesine bildirmek için kullandığımız bir metot.
//Bu metot harici konfigürasyonel sınıflarımızı EF Core'a bildirebilmek için kullandığımız bir metottur.
#endregion

#region ApplyConfigurationsFromAssembly Metodu
//Birden çok entity'e sahip olduğun çalışmalarda her bir entity için oluşturmuş olduğumuz Configuration sınıflarını gelip tek tek OnModelCreating metoduna eklemektense bu entitylerin oluşturulduğu Configuration sınıflarının Assembly'si hangisi ise bunu ApplyConfigurationsFromAssembly metoduyla bir kereye mahsus OnModelCreating metoduna bildiriyoruz bundan sonra ilgili assembly içinde IEntityTypeConfiguration<T> interface'ini implemente eden tüm sınıflar otomatik olarak yakalanıyor ve bunların hangi entity'e karşılıksa o entity'e konfigürasyon olarak kabul edilmesini sağlıyor.
//Uygulama bazında oluşturulan harici konfigürasyonel sınıfların her birini OnModelCreating metodunda ApplyConfiguration ile tek tek bildirmek yerine bu sınıfların bulunduğu Assembly'i bildirerek IEntityTypeConfiguration<T> arayüzünden türeyen tüm sınıfları ilgili entity'e karşılık konfigürasyonel değer olarak baz almasını tek kalemde gerçekleştirmemizi sağlayan bir metottur.
#endregion

class Order
{
    public int OrderId { get; set; }
    public string Description { get; set; }
    public DateTime OrderDate { get; set; }
}

class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(x => x.OrderId);
        builder.Property(p => p.Description)
            .HasMaxLength(13);
        builder.Property(p => p.OrderDate)
            .HasDefaultValueSql("GETDATE()");
    }
}
class ApplicationDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDB;User ID=SA;Password=1q2w3e4r!.;");
    }
}