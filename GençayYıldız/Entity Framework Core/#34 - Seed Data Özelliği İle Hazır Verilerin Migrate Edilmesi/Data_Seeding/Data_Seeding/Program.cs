using Microsoft.EntityFrameworkCore;

ApplicationDbContext context = new();

//Seed Data'lar migration'şarın dışında eklenmesi ve değiştirilmesi beklenmeyen durumlar için kullanılan bir özelliktir.

#region Data Seeding Nedir?
//EF Core üzerinden migrate edeceğimiz veritabanında hazır verilerin oluşturulmasını sağlayan bir özelliktir.
//Veritabanını oluştururken bazen içerisinde belirli sebeplerden dolayı hazır verilerle bu vertiabanının tablolarının oluşturulmasını isteyebiliriz.
//Bu sebebler; Test için geçici veriler oluşturmak isteyebiliriz. Ya da yazılım için temel konfigürasyonel değerler oluşturmak isteyebiliriz.ASP.Net Core'daki identity rolleri gibi statik değerleri de direkt veritabanına migrate sürecinde yüklemek isteyebiliriz.
//Veritabanını migrate ederken hazır/belirli verilerle bu veritabanının inşa edilmesini istiyorsan Seed Data yapılanmasını kullanabilirsin.
//EF Core ile inşa edilen veritabanı içerisinde veritabanı nesneleri olabileceği gibi verilerinde migrate sürecinde üretilmesini isteyebiliriz.
//İşte bu ihtiyaca istinaden Seed Data özelliği ile EF Core üzerinden migrationlarda veriler oluşturabilir ve migrate ederken bu verileri hedef tablolarımıza basabiliriz.
//Seed Data'lar, migrate süreçlerinde hazır verileri tablolara basabilmek için bunları yazılım kısmında tutmamızı gerektirmektedirler. Böylece bu veriler üzerinde veritabanı seviyesinde istenilen manipülasyonlar gönül rahatlığıyla gerçekleştirilebilmektedir.
//Data Seeding özelliği şu noktalarda kullanılabilir;
//Test için geçici verilere ihtiyacın varsa,
//Asp.NET Core'daki Identity yapılanmasındaki roller gibi static değerler de tutulabilir.
//Yazılım için temel konfigürasyonel değerler.
#endregion
#region Seed Data Ekleme
//OnModelCreating metodunda entity'lerimize özel Seed Data'ları yapılandırabiliyoruz.
//OnModelCreating metodu içerisinde Entity fonksiyonundan sonra çağırılan HasData fonksiyonu ilgili entity'e karşılık Seed Data'ları eklememizi sağlayan bir fonksiyondur.
//Primary Key değerlerinin manuel olarak bildirilmesi/verilmesi gerekmektedir. Neden diye sorarsanız eğer, ilişkisel verileri de Seed Datalarla üretebilmek için...
#endregion
#region İlişkisel Tablolar İçin Seed Data Ekleme
//İlişkisel senaryolarda dependent table'a veri eklerken foreign key kolonunun property'si varsa eğer ona ilişkisel değerini vererek ekleme işlemini yapıyoruz.
#endregion
#region Seed Datanın Primary Key'ini Değiştirme
//Eğer ki migrate edilen herhangi bir seed datanın sonrasında Primary Key'i değiştirilirse bu datayla varsa ilişkisel başka veriler onlara cascade davranışı sergilenecektir.
//Eğer ki bir gün Seed Data'nın Primary Key'ini migration içinde güncellersen oluşturacağın yeni migration'a bu yansıyacaktır. bu migration'da bu data silinecek ve yeni bir data olarak eklenecektir. Eğer ki bu data diğer tablolarda ilişki kurmuşsa o verilerde cascade işlemine tutulacak ve silinecektir.
//Seed datalar 1 kere migrate edilirler. Bir kere migrate edildikleri için önceden migrate ettiğimiz/veritabanına işlediğimiz datalar haliyle sonraki oluşturacağımız migrationlarda insert edilmesiyle ilgili herhangi bir ibare olmayacağından dolayı geçmişte kaldığı için yani biz Seed Datalarla ilgili operasyonu bir önceki migrationda tamamlıyoruz ikinci migration devreye girerken bir tutarsızlık meydana gelmeyecektir.
#endregion



class Post
{
    public int Id { get; set; }
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public Blog Blog { get; set; }
}
class Blog
{
    public int Id { get; set; }
    public string Url { get; set; }

    public ICollection<Post> Posts { get; set; }
}
class ApplicationDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>()
            .HasData(
            new Blog() { Id = 1, Url = "www.gencayyildiz.com/blog", },
            new Blog() { Id = 2, Url = "www.bilmemne.com/blog", }
            );
        modelBuilder.Entity<Post>()
            .HasData(
            new Post() { Id = 1, BlogId = 1, Title = "A", Content = "..." },
            new Post() { Id = 2, BlogId = 1, Title = "B", Content = "..." },
            new Post() { Id = 3, BlogId = 2, Title = "B", Content = "..." }
            );
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDb; User ID=SA; Password=1q2w3e4r!.;");
    }
}