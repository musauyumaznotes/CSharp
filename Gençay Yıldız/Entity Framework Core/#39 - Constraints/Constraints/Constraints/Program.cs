using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

ApplicationDbContext context = new();

#region Primary Key Constraint
//Herhangi bir tabloda bir kimlik görevi gören constraint yapılanması.
//Bir kolonu Primary Key constraint ile birincil anahtar yapmak istiyorsak eğer bunun için name convention'dan istifade edebiliriz. Id, ID, EntityNameId, EntityNameID şeklinde tanımlanan tüm property'ler default olarak EF Core tarafından Primary Key constraint olacak şekilde generate edilirler.
//Eğer ki farklı bir property'e Primark Key özelliğini atamak istiyorsan burada HasKey Fluent API'ı yahut Key Attribute'u ile bu bildirimi iradeli bri şekilde yapmak zorundasın.
#region HasKey Fonksiyonu

#endregion
#region Key Attirbute'u

#endregion
#region Alternate Keys - HasAlternateKey
//Primary Key'e ek olarak her entity instance'ı için alternatif bir benzersiz tanımlayıcı işlemine sahip olan Key'dir.
//Bir entity içerisinde Primary Key'e ek olarak her entity instance'ı için alternatif bir benzersiz tanımlayıcı işlevine sahip olan bir key'dir.
//EF Core'daki Alternate Key'in karşılığı veritabanı seviyesinde unique constraint'tir.
#endregion
#region Composite Alternate Key

#endregion

#region HasName Fonksiyonu İle Primary Key Constraint'e İsim Verme

#endregion
#endregion

#region Foreign Key Constraint
//İlişkisel tablo senaryolarında kullandığımız bir tablo çeşididir. Dependent table'daki herhangi bir verinin principal table'daki hangi veriye karşılık onunla ilişkili oluşturulacağının garantisini alan ilgili veriler üzerinden kısıtlamayı sağlayan bir constraint çeşidi.

#region HasForeignKey Fonksyionu

#endregion
#region ForeignKey Attribute'u

#endregion
#region Composite Foreign Key 

#endregion

#region Shadow Property Üzerinden Foreign Key 

#endregion

#region HasConstraintName Fonksiyonu İle Primary Key Constraint'e İsim Verme

#endregion
#endregion

#region Unique Constraint
//Unique constraint'in amacı Unique constraint'in uygulandığı kolonu tekilleştirmektir. Mükerrer kaydın girilmesini engellemektir.

#region HasIndex - IsUnique Fonksiyonları

#endregion

#region Index, IsUnique Attribute'ları

#endregion

#region Alternate Key

#endregion
#endregion

#region Check Constraint
//Herhangi bir kolondaki veriyi çek etmemizi sağlayan belirli şartlara göre değerlendirip ona göre kabul etmemizi sağlayan ya da kabul eden bir kısıtlayıcıdır.
#region HasCheckConstraint

#endregion
#endregion


//[Index(nameof(Blog.Url), IsUnique = true)]
class Blog
{
    public int Id { get; set; }
    //[Key]
    public string BlogName { get; set; }
    public string Url { get; set; }

    public ICollection<Post> Posts { get; set; }
}
class Post
{
    public int Id { get; set; }
    //[ForeignKey(nameof(Blog))]
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string BlogUrl { get; set; }
    public int A { get; set; }
    public int B { get; set; }

    public Blog Blog { get; set; }
}
class ApplicationDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Primary Key
        //modelBuilder.Entity<Blog>()
        //    .HasKey(b => b.BlogName);
        //modelBuilder.Entity<Blog>()
        //    .HasAlternateKey(b=>b.Url);
        //modelBuilder.Entity<Blog>()
        //    .HasAlternateKey(b=> new { b.Url ,b.BlogName});
        //modelBuilder.Entity<Blog>()
        //    .HasKey(b => b.Id)
        //    .HasName("ornek");
        #endregion
        #region Foreign Key
        //modelBuilder.Entity<Blog>()
        //    .HasMany(b => b.Posts)
        //    .WithOne(b => b.Blog)
        //    .HasForeignKey(p=>p.BlogId);

        //modelBuilder.Entity<Blog>()
        //    .HasMany(b => b.Posts)
        //    .WithOne(b => b.Blog)
        //    .HasForeignKey(p => new { p.BlogId, p.BlogUrl });

        modelBuilder.Entity<Blog>()
            .Property<int>("BlogForeignKeyId");
        modelBuilder.Entity<Blog>()
            .HasMany(b => b.Posts)
            .WithOne(b => b.Blog)
            .HasForeignKey("BlogForeignKeyId")
            .HasConstraintName("ornekforeignkey");
        #endregion
        #region Unique Constraint
        //modelBuilder.Entity<Blog>()
        //    .HasIndex(b => b.Url)
        //    .IsUnique();
        modelBuilder.Entity<Blog>()
            .HasAlternateKey(b => b.Url);
        #endregion
        #region Check Constraint
        modelBuilder.Entity<Post>()
            .HasCheckConstraint("a_b_check_const","[A] > [B]");
        #endregion
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433; Database=ApplicationDb; User ID=SA; Password=1q2w3e4r!.;");
    }
}