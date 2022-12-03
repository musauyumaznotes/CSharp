using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

ApplicationDbContext context = new();

#region Generated Value Nedir?
//EF Core tarafından herhangi bir değer üretiliyorsa buradaki üretilen değerle ilgili yaklaşım burada incelenir.
//EF Core'da üretilen değerlerle ilgili çeşitli modellerin ayrıntılarını yapılandırmamızı sağlayan bir konfigürasyondur/özelliktir/yapılandırmadır.
//Bir veri üretiliyorsa EF Core'da genel yapılandırmayı sağlayan başlık budur.
#endregion

#region Default Values
//EF Core'da herahngi bir kolona veri gönderilmiyorsa o kolona bir veri üretip default olarak yerleştirmek istiyorsak default values'lar konuşur.
//EF Core herhangi bir tablonun herhangi bir kolonuna yazılım tarafından bir değer gönderilmediği taktirde bu kolona hangi değerin(default value) üretilip yazdırılacağını belirleyen yapılanmalardır.

#region HasDefaultValue
//Static veri veriliyor.
#endregion

#region HasDefaultValueSql
//SQL cümleciği veriyoruz.
#endregion
#endregion

#region Computed Columns
//Tablo içerisindeki kolonlar üzerinde yapılan aritmetik işlemler neticesinde üretilen kolondur.
#region HasComputedColumnSql

#endregion

#endregion

#region Value Generation

#region Primary Keys
//Herhangi bir tablodaki her bir satırı tanımlayan ve unique olan sütun veya sütunlardır.
//Herhangi bir tablodaki satırları kimlik vari şekilde tanımlayan, tekil(unique) olan sütun veya sütunlardır.
//Kimlik vari özellik gösterir.
#endregion

#region Identity
//Yalnızca otomatik olarak artan bir sütundur. Bir sütun primary key olmaksızın identity tanımlanabilir.
//Ardışık bir özellik gösterir.
//Bir tablo içerisinde identity kolonu tek bir tane olarak tanımlanabilir.
#endregion

//Bu iki özellik genellikle birlikte kullanılmaktadırlar. O yüzden EF Core Primary Key olan bir kolonu otomatik/direkt(sana bana sormadan) Identity olacak şekilde yapılandırmaktadır. Ancak böyle olması için bir gereklilik yoktur.

#region DatabaseGenerated

#region DatabaseGeneratedOption.None - ValueGeneratedNever
//Bir kolonda herhangi bir değer üretilmeyecekse bunu None ile işaretleyeceğiz.
//EF Core'un default olark Primary Key kolonlarda getirdiği Identity özelliğini kaldırmak istiyorsak eğer None'ı kullanabiliriz.
#endregion

#region DatabaseGeneratedOption.Identity - ValueGeneratedOnAdd
//Bir kolonda bir değer üretilecekse ve bunun ardışık bir şekilde artmasını bekliyorsak Identity ile işaretleyeceğiz.
//Herhangi bir kolona Identity(ardışık olarak artış özelliği gösteren değerler) özelliğini vermemizi sağlayan bir konfigürasyondur.
#region Sayısal Türlerde
//Eğer ki Identity özelliği bir tabloda sayısal olan bir kolonda kullanılacaksa o durumda ilgili tablodaki Primary Key olan kolondan özellikle/iradeli bir şekilde identity özelliğinin kaldırılması gerekmektedir.(None)
#endregion

#region Sayısal Olmayan Türlerde
//Madem sayısal olmayan bir türde çalışıyoruz sen artık Identity özelliğini Primary Key'den almana gerek yok.
//Identity özelliğini sayısal türlerin dışında kullanıyorsan bunun hangi değerle hangi yöntemle üretileceğini bana bildirmen lazım.
//Eğer ki Identity özelliği bir tabloda sayısal olmayan bir kolonda kullanılacaksa o durumda ilgili tablodaki Primary key olan kolondan iradeli bir şekilde Identity özelliğinin kaldırılmasına gerek yoktur.
#endregion
#endregion

#region DatabaseGeneratedOption.Computed - ValueGeneratedOnAddOrUpdate
//Bir kolonda computed bir değer üretilecekse ya da default bir değer üretilecekse bunu da Computed ile işaretleyeceğiz.
//EF Core üzerinde Computed Column ise ister Computed olarak belirleyebilirsiniz isterseniz de belirlemeden kullanmaya devam edebilirsiniz.
#endregion

#endregion
#endregion

//Person p = new()
//{
//    Name = "Musa",
//    Surname = "Uyumaz",

//    Premium = 10,
//    TotalGain = 100,
//    PersonCode = 1
//};
//await context.Persons.AddAsync(p);
//await context.SaveChangesAsync();

class Person
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int PersonId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Premium { get; set; }
    public int Salary { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int TotalGain { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PersonCode { get; set; }
}

class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDb;User ID=SA;Password=1q2w3e4r!.;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region HasDefaultValue
        modelBuilder.Entity<Person>()
            .Property(p => p.Salary)
            .HasDefaultValue(100);
        #endregion
        #region HasDefaultValueSql
        modelBuilder.Entity<Person>()
            .Property(p => p.Salary)
            .HasDefaultValueSql("FLOOR(RAND() * 1000)");
        #endregion
        #region HasComputedColumnSql
        modelBuilder.Entity<Person>()
            .Property(p => p.TotalGain)
            .HasComputedColumnSql("([Salary] + [Premium]) * 10")
            .ValueGeneratedOnAddOrUpdate();
        #endregion
        #region ValueGeneratedNever
        modelBuilder.Entity<Person>()
            .Property(p => p.PersonId)
            .ValueGeneratedNever();
        #endregion
        #region ValueGeneratedOnAdd
        #region Sayısal Olmayan Tür
        modelBuilder.Entity<Person>()
            .Property(p => p.PersonCode)
            .HasDefaultValueSql("NEWID()");
        modelBuilder.Entity<Person>()
            .Property(p => p.PersonCode)
            .HasDefaultValueSql("NEWID()")
            .ValueGeneratedOnAdd();
        #endregion
        #endregion
    }
}