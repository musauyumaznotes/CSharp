# One to One İlişkisel Senaryolarda Veri Ekleme
- Önce principal entity nesnesi oluşturursunuz ve ardından bu principal entity'sini oluşturduktan sonra bu nesnenin içerisinde bizim navigation property'imiz üzerinden de dependent entity verisinide otomatik bir şekilde ekleme işlemine ilişkisel bir vaziyette gerçekleştirebiliriz.

- Foreign key hangisinde tanımlanmışsa o dependent entity'dir.

- EF Core diyor ki sen bir person ekliyorsun ve bu person'ın navigation property'sine vermiş olduğun bu nesneyi de ekliyorsun ama bu nesne addresses tablosuna gidecek Person'da Persons tablosuna gidecek Haliyle ben bu ikisini ilişkilendirerek direkt ekleme işlemini gerçekleştireceğim bilgin olsun.

- EF Core ekleme işlemini gerçekleştirirken ister dependent entity üzerinden ister principal entity üzerinden ekleme yapalım ilk Principal Entity sonrasında ise Dependent entity şeklinde eklemeyi gerçekleştiriyor. Çünkü Dependent entity'de bulunan foreign key kolonunu doldurabilmek için bir adet principal entity'e ihtiyacı var.

- Principal entity üzerinden bir ekleme işlemi gerçekleştiriyorsanız illaki bir dependent entity vermek zorunda değilsiniz.

- Amma velakin dependent entity üzerinden bir ekleme işlemi gerçekleştiriyorsanız zaten dependent entity'desin haliyle bunun bir karşılığı zoraki olmalı çünkü burada foreign key var O foreign key'e bir tane değer koyman gerekiyor. İşte o değeri koyabilmek için dependent entity üzerinden yapılan eklemelerde Principal entity'nin nesnesini zoraki vermek zorundasın.

- Eğer ki principal entity üzerinden ekleme gerçekleştiriliyorsa dependent entity nesnesi verilmek zorunda değildir! Amma velakin dependent entity üzerinden ekleme işlemi gerçekleştiriliyorsa eğer burada principal entity'nin nesnesine ihtiyacımız zaruridir.

- Navigation property dediğimiz yapılanmalar hem ilişki türlerini ortaya koyuyor yani iki tablo arasında herahngi bir ilişki oluşturacaksanız bunları navigation property'ler üzerinden tasarlıyorsunuz. Hem de bu navigation property'lerin veri ekleme süreçlerinde de ihtiyacımızı giderdiğini görmüş olduk.

```C#
#region 1. Yöntem -> Principal Entity Üzerinden Dependent Entity Verisi Ekleme
Person person = new();
person.Name = "Hüseyin";
person.Address = new() { PersonAddress = "Etimesgut/ANKARA"};

await context.Persons.AddAsync(person);
await context.SaveChangesAsync();
#endregion
#region 2. Yöntem -> Dependent Entity Üzerinden Principal Entity Verisi Ekleme
Address address = new() { PersonAddress="Papaz Deresi/Ankara",Person = new() { Name ="Şuayip"} };

await context.Addresses.AddAsync(address);
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
class ApplicationDbContext : DbContext
{
   public DbSet<Address> Addresses { get; set; }
   public DbSet<Person> Persons { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
       optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDB;User ID = SA; Password = 1q2w3e4r!.");
   }
   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
       modelBuilder.Entity<Address>()
           .HasOne(a => a.Person)
           .WithOne(p => p.Address)
           .HasForeignKey<Address>(a => a.Id);
   }
}
```

# One to Many İlişkisel Senaryolarda Veri Ekleme
- Bu yöntemde de aynı kural geçerlidir. Yani eğer ki bire çok ekleme yapıyorsak ilk önce Principal entity sonrasında ise Dependent entity eklenir.
## 1. Yöntem -> Principal Entity Üzerinden Dependent Entity Verisi Ekleme
### Nesne Referansı Üzerinden Ekleme
- OOP'de herhangi bir referans null'sa bu referans üzerinden herhangi bir member'a erişmeye çalışmak null reference exception hatası verecektir. Haliyle blog nesnesi üzerinden Post'a erişirken bu post'un null olmadığından emin olmalıyız. İşte bundan emin olabilmek için EF Core çalışmalarında bu koleksiyonel Navigation Property'leri biz ilgili entity içerisinde Constructor'da direkt new'liyoruz. 

- O yüzden entity'ler içerisindeki koleksiyonel Navigation property'leri Constructor ile başlatırız.

- Bu yapılanmalarda genellikle HashSet kullanılır bunun sebebi HashSet unique bir yapılanmaya sahiptir hem de daha az maliyetli yüksek performanslı çalışmaktadır.

```C#
Blog blog = new() { Name = "Gencayyildiz.com Blog" };
blog.Posts.Add(new() { Title = "Post 1" });
blog.Posts.Add(new() { Title = "Post 2" });
blog.Posts.Add(new() { Title = "Post 3" });

await context.Blogs.AddAsync(blog);
await context.SaveChangesAsync();
#endregion
#region Object Initializer Üzerinden Ekleme
Blog blog2 = new()
{
   Name = "A Blog",
   Posts = new HashSet<Post>() { new() { Title = "Post4" }, new() { Title = "Post 5" } }
};
await context.Blogs.AddAsync(blog2);
await context.SaveChangesAsync();

#endregion
```

# 2. Yöntem -> Dependent Entity Üzerinden Principal Entity Verisi Ekleme
- Bu yöntemi hiçbir zaman kullanmayacağız. Bu da mümkündür ama kısıtlıdır yani yanlış yapağın şeyleride görmekte fayda var. Bunu yapma

- Dependent Entity üzerinden Principal Entity verisini eklemek bire çok davranışına aykırı bir model.

- Bu durumda bir tane principal entity ekleyebilirsiniz. ve bu dependent entity'de ilgili principal entity'e karşılık bir tane olacaktır. Ekstradan 2., 3., 5. n'inci dependent entity'i bu yöntemle ekleyemezsiniz.

- Bire çok ilişkinin söz konusu olduğu senaryolarda veri ekleyecekseniz dependent entity'den mümkün mertebe başlamayın!

- Eğer ki bu yöntemle ekleme yapıyorsak illaki bir adet principal entity nesnesi vermemiz gerekmektedir.
```C#
Post post = new()
{
   Title = "Post 6",
   Blog = new() { Name = "Blog" }
};
await context.Posts.AddAsync(post);
await context.SaveChangesAsync();
```

# 3. Yöntem -> Foreign Key Kolonu Üzerinden Veri Ekleme
- Eğer istersek direkt Principal Entity nesnesinin Id değerini vererekte ekleme işlemi gerçekleştirebiliriz.

- [1. ve 2. Yöntemler hiç olmayan verilerin ilişkisel olarak eklenmesini sağlarken Bu yöntem ise önceden eklenmiş olan bir principal entity verisiyle yeni dependent entity'lerin ilişkisel olarak eşleştirilmesini sağlamaktadır.

```C#
Post post = new()
{
   Title = "Post 7",
   BlogId = 1
};
await context.Posts.AddAsync(post);
await context.SaveChangesAsync();
#endregion
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
   public int BlogId { get; set; }
   public string Title { get; set; }

   public Blog Blog { get; set; }
}
class ApplicationDbContext : DbContext
{
   public DbSet<Blog> Blogs { get; set; }
   public DbSet<Post> Posts { get; set; }
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
       optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDB;User ID=SA;Password=1q2w3e4r!.");
   }
}
```

# Many to Many İlişkisel Senaryolarda Veri Ekleme
## 1. Yöntem
- Many to Many ilişkisi eğer ki Default Convention ile tasarlanmışsa kullanılan bir yöntemdir.

- Çoka çok yapılanmada hangi tablodan çıkarak ekleme yaptığın önemli değil Çünkü her iki tabloda principal entity'dir.

```C#
Book book = new()
{
   BookName = "A Kitabı",
   Authors = new HashSet<Author>() 
   {
       new(){AuthorName = "Hilmi"},
       new(){AuthorName = "Ayşe"},
       new(){AuthorName = "Fatma"},
   }
};
await context.Books.AddAsync(book);
await context.SaveChangesAsync();

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
```

## 2. Yöntem
- Many to Many ilişkisi eğer ki Fluent Api ile tasarlanmışsa kullanılan bir yöntemdir.

- Eğer ki fluent api'yi kullanıyorsak bir başka deyişle eğer ki cross table elimizdeyse erişebiliyorsak buna cross table üzerinden de biz mevcut verilerle ilişkisel farklı yeni veri türlerini ortaya koyabiliyoruz.

- Cross table elimizde olduğu/buna erişebildiğimiz sürece hem bu cross table'ın foreign key kolonlarına karşılık gelen property'lere değerler verip var olan verilerle ilişkisel çoka çok operasyonlar gerçekleştirebiliyoruz ya da yine bu cross table içerisindeki Navigation property'leri kullanarak olmayan verileride var olan verilerle bir şekilde ilişkilendirebiliyoruz. Yani buradaki yapılanma bize inanılmaz manevra kazandırıyor.

```C#
Author author = new()
{
    AuthorName = "Mustafa",
    Books = new HashSet<AuthorBook>()
    {
        new(){BookId = 1},
        new(){Book = new(){ BookName = "B Kitap"} },
    }
};
await context.Authors.AddAsync(author);
await context.SaveChangesAsync();

class Book
{
    public Book()
    {
        Authors = new HashSet<AuthorBook>();
    }
    public int Id { get; set; }
    public string BookName { get; set; }

    public ICollection<AuthorBook> Authors { get; set; }
}
class Author
{
    public Author()
    {
        Books = new HashSet<AuthorBook>();
    }
    public int Id { get; set; }
    public string AuthorName { get; set; }

    public ICollection<AuthorBook> Books { get; set; }
}
class AuthorBook
{
    public int BookId { get; set; }
    public int AuthorId { get; set; }

    public Author Author { get; set; }
    public Book Book { get; set; }
}
#endregion


class ApplicationDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDB; User ID = SA; Password= 1q2w3e4r!.");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthorBook>()
            .HasKey(ab => new { ab.AuthorId, ab.BookId });

        modelBuilder.Entity<AuthorBook>()
            .HasOne(ab => ab.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(ab => ab.AuthorId);

        modelBuilder.Entity<AuthorBook>()
            .HasOne(ab => ab.Book)
            .WithMany(b => b.Authors)
            .HasForeignKey(ab => ab.BookId);
    }
}
```
