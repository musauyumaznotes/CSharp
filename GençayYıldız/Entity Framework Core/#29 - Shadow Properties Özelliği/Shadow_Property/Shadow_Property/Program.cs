
using Microsoft.EntityFrameworkCore;

ApplicationDbContext context = new();

#region Shadow Properties - Gölge Özellikler
//Bir entity'nin içinde bizler tabloda var olan kolonlardan entity instance'ı üzerinde gösterilmesini ve işlenmesini istemediğimiz kolonlar var ise biz bunu property ile temsil etmek istemeyiz ve aynı zamanda kullanacaksak bunlara shadow properties diyoruz.
//Entity instance'ında kullnamayacaksın ama Entity'i insert ederken bu değeri çalıştırma ihtiyacı olacak ya da yeri gelecek bu değer üzerinden sıralam yapman gerekecek olmayan property üzerinde bunu yapamazsın işte bunu yapabilmeni sağlayabilecek bir gölge özelliğe ihtiyacın olacak
//Entity sınıflarında fiziksel olarak tanımlanmayan/modellenmeyen ancak EF Core tarafından ilgili entity için var olan/var olduğu kabul edilen property'lerdir.
//Tabloda gösterilmesini istemediğimiz/lüzumlu görmediğimiz/entity instance'ı üzerinde işlem yapmayacağımız kolonlar için shadow property'ler kullanılabilir.
//Entity instance'ında olmayacak ama arka planda olacak property'ler.
//Shadow property'lerin değerleri ve stateleri Change Tracker tarafından kontrol edilir.
#endregion

#region Foreign Key - Shadow Properties
//ilişkisel senaryolarda foreign key property'sini tanımlamadığımız halde EF Core tarafıdan Dependent Table'a eklenmektedir. İşte bu shadow Property'dir.
//Eğer ki ilişkisel senaryolarda dependent entity'lerde biz foreign key bir şekilde/fiziksel/property olarak tanımlamıyorsak/modellemiyorsak demek ki aslında shadow property'i tercih ediyoruz anlamına gelir.

//var blogs = await context.Blogs.Include(b => b.Posts).ToListAsync();
//Console.WriteLine();
#endregion

#region Shadow Property Oluşturma
//Shadow Property'i oluşturmanın tek yolu Fluent API'ı kullanmaktır.
//Bir entity üzerinde shadow property oluşturmak istiyorsanız eğer Fluent API'ı kullanmanız gerekmektedir.

//modelBuilder.Entity<Blog>()
//           .Property<DateTime>("CreatedDate");
#endregion

#region Shadow Property'e Erişim Sağlama
#region ChangeTracker İle Erişim
//Shadow property'e erişim sağlayabilmek için Change Tracker'dan istifade edilebilir.

//var blog = await context.Blogs.FirstAsync();
//var createdDate = context.Entry(blog).Property("CreatedDate");
//Console.WriteLine(createdDate.CurrentValue);
//Console.WriteLine(createdDate.OriginalValue);

//createdDate.CurrentValue = DateTime.Now;
//await context.SaveChangesAsync();
#endregion

#region EF.Property İle Erişim
//Özellikle LINQ sorgularında Shawdow Property'lerine erişim için EF.Property static yapılanmasını kullanabiliriz
//var blogs = await context.Blogs.OrderBy(b => EF.Property<DateTime>(b, "CreatedDate")).ToListAsync();

//var blogs2 = await context.Blogs.Where(b => EF.Property<DateTime>(b, "CreatedDate").Year > 2020).ToListAsync();
//Console.WriteLine();
#endregion
#endregion

#region Kullanım Durumları
//CreatedDate,tarihsel işlemleri yapıyorsak, son güncelleme tarihi LastUpdated bunların entity üzerinden yönetmektense property'lerle kirletmektense shadow propertyler kullanarak tasarlıyoruz ki developer açısından bir entity'i kullanırken bir kirlilik olmasın,developer'ı yanıltacak herhangi bir operasyon olmasın LastUpdated gibi operasyonlar developerların müdahale edeceği değil sadece entityframework core'un ilgileneceği kolonlardır. Onların değerleri de yapılacak işlemlere bağlı olacak şekilde güncellenir. İşte biz bunu developer'dan soyutlayabilmek için shadow property olarak tasarlarız ki daha güvenli bir şekilde operasyonlarımız işliyor olsun.
#endregion

class Blog
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public ICollection<Post> Posts { get; set; }
}
class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool LastUpdated { get; set; }

    public Blog Blog { get; set; }
}

class ApplicationDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433; Database=ApplicationDb;User ID= SA; Password=1q2w3e4r!.;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>()
            .Property<DateTime>("CreatedDate");
    }
}