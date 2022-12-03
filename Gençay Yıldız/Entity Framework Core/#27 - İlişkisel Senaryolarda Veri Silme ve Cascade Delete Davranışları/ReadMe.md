# İlişkisel Senaryolarda Veri Silme
- Veritabanı seviyesinde herhangi bir Principal Table'da bir veriyi sildiğimizde bu veriye karşılık Dependent Table'da bulunan ilişkisel verilerde nasıl bir operasyon yapılması gerektiğinin davranışını cascade delete dediğimiz yapılanmayla bildiriyoruz. Yani Principal Table'da herahngi bir veriyi sildiğimde Dependent Table'da buna karşılık gelen verileri sil diyorum.Silmek demek fazlasıyla veri kaybı demektir. Veri kaybına uğramak istemiyorsam null değer ata diyorum. Çünkü bunun Principal tablodaki karşılığı silinmiştir. Veyahut engelle/kısıtla diyebiliyorum.




# One to One İlişkisel Senaryolarda Veri Silme

```C#
Person? person = await context.Persons.Include(p=>p.Address).FirstOrDefaultAsync(p=>p.Id == 1);

context.Addresses.Remove(person.Address);
await context.SaveChangesAsync();
```

# One to Many İlişkisel Senaryolarda Veri Silme

```C#
Blog? blog = await context.Blogs.Include(b => b.Posts).FirstOrDefaultAsync(b => b.Id == 1);
Post? post =blog.Posts.FirstOrDefault(p => p.Id == 2);
context.Posts.Remove(post);
await context.SaveChangesAsync();
```

# Many to Many İlişkisel Senaryolarda Veri Silme
- Biz herhangi bir silme işlemi gerçekleştirirken çok çok tablolarda cross table üzerinden gerçekleşecektir.

```C#
Book? book = await context.Books.Include(b => b.Authors).FirstOrDefaultAsync(b=>b.Id == 1);

Author? author = book.Authors.FirstOrDefault(a=>a.Id ==2);
//context.Authors.Remove(author);// Yazarı silmeye kalkar
book.Authors.Remove(author);
await context.SaveChangesAsync();
```

# Cascade Delete
- Bu davranış modelleri Fluent API ile konfigüre edilebilmektedir.
- Eğer ki principal table'daki veriyi silmeye çalışırsak dependent table'daki verilerin tutarsız hale getirmememiz gerekir.
# Cascade
- Esas tablodan(Principal Table) silinen veriyle karşı/bağımlı tabloda(Dependent Table) bulunan ilişkili verilerin silinmesini sağlar.

```C#
Blog? blog = await context.Blogs.FindAsync(1);
context.Blogs.Remove(blog);
await context.SaveChangesAsync();
```
```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{   
    modelBuilder.Entity<Post>()
        .HasOne(p => p.Blog)
        .WithMany(b => b.Posts)
        .HasForeignKey(p => p.BlogId)
        .OnDelete(DeleteBehavior.Cascade);
}
```

# SetNull
- Esas tablodan(Principal Table) silinen veriyle karşı/bağımlı tabloda(Dependent Table) bulunan ilişkili verilere null değerin atanmasını sağlar.
- Birebir ilişkisel senaryolarda SetNull kullanılmaz Çünkü Id değerini hem PrimaryKey hemde foreign key olark kullandığımız için.
- One to One senaryolarda eğer ki Foreign Key ve Primary Key kolonları aynı ise o zaman SetNull davranışını KULLANAMAYIZ!!!

```C#
Blog? blog = await context.Blogs.FindAsync(1);
context.Blogs.Remove(blog);
await context.SaveChangesAsync();
```
```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{   
    modelBuilder.Entity<Post>()
        .HasOne(p => p.Blog)
        .WithMany(b => b.Posts)
        .HasForeignKey(p => p.BlogId)
        .OnDelete(DeleteBehavior.SetNull)
        .IsRequired(false);
}
```


# Restrict
- Esas tablodan(Principal Table) herhangi bir veri silinmeye çalışıldığında o veriye karşılık dependent table'da ilişkisel veri(ler) varsa eğer bu serffer bu silme işlemini engellemesini sağlar. Yani burada direkt constraint devreye girecektir.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{   
    modelBuilder.Entity<Post>()
        .HasOne(p => p.Blog)
        .WithMany(b => b.Posts)
        .HasForeignKey(p => p.BlogId)
        .OnDelete(DeleteBehavior.Restrict)
        .IsRequired(false);
}
```


```C#
#region SavingData
Person person = new()
{
   Name = "Gençay",
   Address = new()
   {
       PersonAddress = "Yenimahalle/ANKARA"
   }
};

Person person2 = new()
{
   Name = "Hilmi"
};

await context.AddAsync(person);
await context.AddAsync(person2);

Blog blog = new()
{
   Name = "Gencayyildiz.com Blog",
   Posts = new List<Post>
   {
       new(){ Title = "1. Post" },
       new(){ Title = "2. Post" },
       new(){ Title = "3. Post" },
   }
};

await context.Blogs.AddAsync(blog);

Book book1 = new() { BookName = "1. Kitap" };
Book book2 = new() { BookName = "2. Kitap" };
Book book3 = new() { BookName = "3. Kitap" };

Author author1 = new() { AuthorName = "1. Yazar" };
Author author2 = new() { AuthorName = "2. Yazar" };
Author author3 = new() { AuthorName = "3. Yazar" };

book1.Authors.Add(author1);
book1.Authors.Add(author2);

book2.Authors.Add(author1);
book2.Authors.Add(author2);
book2.Authors.Add(author3);

book3.Authors.Add(author3);

await context.AddAsync(book1);
await context.AddAsync(book2);
await context.AddAsync(book3);
await context.SaveChangesAsync();
#endregion

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Address Address { get; set; }
}
class Address
{
    public int Id { get; set; }
    public string PersonAddress { get; set; }

    public Person Person { get; set; }
}
class Blog
{
    public Blog()
    {
        Posts = new HashSet<Post>();
    }
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Post> Posts { get; set; }
}
class Post
{
    public int Id { get; set; }
    public int? BlogId { get; set; }
    public string Title { get; set; }

    public Blog Blog { get; set; }
}
class Book
{
    public Book()
    {
        Authors = new HashSet<Author>();
    }
    public int Id { get; set; }
    public string BookName { get; set; }

    public ICollection<Author> Authors { get; set; }

}
class Author
{
    public Author()
    {
        Books = new HashSet<Book>();
    }
    public int Id { get; set; }
    public string AuthorName { get; set; }

    public ICollection<Book> Books { get; set; }
}

class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDB; User ID=SA; Password=1q2w3e4r!.;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>()
            .HasOne(a => a.Person)
            .WithOne(p => p.Address)
            .HasForeignKey<Address>(a => a.Id);

        modelBuilder.Entity<Post>()
            .HasOne(p => p.Blog)
            .WithMany(b => b.Posts)
            .HasForeignKey(p => p.BlogId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired(false);
        modelBuilder.Entity<Author>()
            .HasMany(a => a.Books)
            .WithMany(b => b.Authors);
    }
}
```

