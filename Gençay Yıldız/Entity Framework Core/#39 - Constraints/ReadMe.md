# Primary Key Constraint
- Herhangi bir tabloda bir kimlik görevi gören constraint yapılanması.

- Bir kolonu Primary Key constraint ile birincil anahtar yapmak istiyorsak eğer bunun için name convention'dan istifade edebiliriz. Id, ID, EntityNameId, EntityNameID şeklinde tanımlanan tüm property'ler default olarak EF Core tarafından Primary Key constraint olacak şekilde generate edilirler.

- Eğer ki farklı bir property'e Primark Key özelliğini atamak istiyorsan burada HasKey Fluent API'ı yahut Key Attribute'u ile bu bildirimi iradeli bri şekilde yapmak zorundasın.

```C#
=============> Data Annotations <=============
class Blog
{
    public int Id { get; set; }

    [Key]
    public string BlogName { get; set; }

    public string Url { get; set; }
    
    public ICollection<Post> Posts { get; set; }
}
=============> Fluent API <=============
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Blog>()
       .HasKey(b => b.BlogName);
}
```

# Alternate Keys - HasAlternateKey
- Primary Key'e ek olarak her entity instance'ı için alternatif bir benzersiz tanımlayıcı işlemine sahip olan Key'dir.

- Bir entity içerisinde Primary Key'e ek olarak her entity instance'ı için alternatif bir benzersiz tanımlayıcı işlevine sahip olan bir key'dir.

- EF Core'daki Alternate Key'in karşılığı veritabanı seviyesinde unique constraint'tir.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Blog>()
       .HasAlternateKey(b => b.Url);
}
```

# Composite Alternate Key
```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
   modelBuilder.Entity<Blog>()
       .HasAlternateKey(b => new {b.Url,b.BlogName });
}
```

# HasName Fonksiyonu İle Primary Key Constraint'e İsim Verme
```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
   modelBuilder.Entity<Blog>()
            .HasKey(b => b.Id)
            .HasName("ornek");
}
```

# Foreign Key Constraint
- İlişkisel tablo senaryolarında kullandığımız bir tablo çeşididir. Dependent table'daki herhangi bir verinin principal table'daki hangi veriye karşılık onunla ilişkili oluşturulacağının garantisini alan ilgili veriler üzerinden kısıtlamayı sağlayan bir constraint çeşidi.

```C#
=============> Data Annotations <=============
class Post
{
    public int Id { get; set; }
    //[ForeignKey(nameof(Blog))]
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string BlogUrl { get; set; }

    public Blog Blog { get; set; }
}
=============> Fluent API <=============
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Blog>()
        .HasMany(b => b.Posts)
        .WithOne(b => b.Blog)
        .HasForeignKey(p=>p.BlogId);
}
```

# Composite Foreign Key 
```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Blog>()
        .HasMany(b => b.Posts)
        .WithOne(b => b.Blog)
        .HasForeignKey(p => new { p.BlogId, p.BlogUrl });
}
```

# Shadow Property Üzerinden Foreign Key 
```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Blog>()
        .Property<int>("BlogForeignKeyId");
    modelBuilder.Entity<Blog>()
        .HasMany(b => b.Posts)
        .WithOne(b => b.Blog)
        .HasForeignKey("BlogForeignKeyId");
}
```
# HasConstraintName Fonksiyonu İle Primary Key Constraint'e İsim Verme
```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Blog>()
        .Property<int>("BlogForeignKeyId");
    modelBuilder.Entity<Blog>()
        .HasMany(b => b.Posts)
        .WithOne(b => b.Blog)
        .HasForeignKey("BlogForeignKeyId")
        .HasConstraintName("ornekforeignkey");
}
```
# Unique Constraint
- Unique constraint'in amacı Unique constraint'in uygulandığı kolonu tekilleştirmektir. Mükerrer kaydın girilmesini engellemektir.

```C#
=============> Data Annotations <=============
[Index(nameof(Blog.Url), IsUnique = true)]
class Blog
{
    public int Id { get; set; }
    public string BlogName { get; set; }
    public string Url { get; set; }

    public ICollection<Post> Posts { get; set; }
}
=============> Fluent API <=============
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Blog>()
        .HasIndex(b => b.Url)
        .IsUnique();
    modelBuilder.Entity<Blog>()
        .HasAlternateKey(b => b.Url);
}
```


# Alternate Key
```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Blog>()
        .HasAlternateKey(b => b.Url);
}
```

# Check Constraint
- Herhangi bir kolondaki veriyi çek etmemizi sağlayan belirli şartlara göre değerlendirip ona göre kabul etmemizi sağlayan ya da kabul eden bir kısıtlayıcıdır.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Post>()
        .HasCheckConstraint("a_b_check_const","[A] > [B]");
       
}
```