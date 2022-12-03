# Scalar Functions Nedir?
- Geriye herhangi bir türde değer döndüren fonksiyonlardır.

# Scalar Function Oluşturma
1. adım : boş bire migration oluşturulmalı.

2. adım : bu migration içerisinde Up metodunda Sql metodu eşliğinde fonksiyonun create kodları yazılacak, Down metodu içerisinde de Drop kodları yazılacaktır.

3. adım : migrate edilmeli.

```C#
protected override void Up(MigrationBuilder migrationBuilder)
{
    migrationBuilder.Sql($@"CREATE FUNCTION getPersonTotalOrderPrice(@personId INT)
                            RETURNS INT
                        AS
                        BEGIN
                            DECLARE @totalPrice INT
                            SELECT @totalPrice = SUM(o.Price) FROM Persons p 
                            JOIN Orders o 
                            ON p.PersonId = o.PersonId
                            Where p.PersonId = 3
                            RETURN @totalPrice
                        END");
}

/// <inheritdoc />
protected override void Down(MigrationBuilder migrationBuilder)
{
    migrationBuilder.Sql($@"DROP FUNCTION getPersonTotalOrderPrice");
}

```
# Scalar Function'ı EF Core'a Entegre Etme
- Bir Scalar Function'ı EF Core üzerinde fonksiyonelite niteliğinde temsil edebilmek için yapmanız gereken birinci hamle Bu fonksiyonu Context içinde temsil edecek bir imza oluşturmanız gerekiyor. İmzayı oluşturduktan sonra bu imza ile veritabanındaki Function'ı bind edebilmek için OnModelCreating fonksiyonunun içinde HasDbFunction fonksiyonuyla gerçekleştireceğim.
# HasDbFunction
- Veritabanı seviyesindeli herhangi bir fonksiyonu EF Core/yazılım kısmında bir metoda bind etmemizi sağlayan fonksiyondur.
```C#
public int GetPersonTotalOrderPrice(int personId)
    => throw new Exception();

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.HasDbFunction(typeof(ApplicationDbContext).GetMethod(nameof(ApplicationDbContext.GetPersonTotalOrderPrice), new[] {typeof(int)}))
        .HasName("getPersonTotalOrderPrice");
}
```
```C#

var persons = await (from person in context.Persons
              where context.GetPersonTotalOrderPrice(person.PersonId) > 500
              select person).ToListAsync();

Console.WriteLine();
```

# Inline Functions Nedir?
- Geriye bir değer değil tablo döndüren fonksiyonlardır.

# Inline Function Oluşturma
1. adım : boş bire migration oluşturulmalı.

2. adım : bu migration içerisinde Up metodunda Sql metodu eşliğinde fonksiyonun create kodları yazılacak, Down metodu içerisinde de Drop kodları yazılacaktır.

3. adım : migrate edilmeli.

```C#
protected override void Up(MigrationBuilder migrationBuilder)
{
    migrationBuilder.Sql($@"CREATE FUNCTION bestSellingStaff(@totalOrderPrice INT = 0)
                                RETURNS TABLE
                            AS
                            RETURN
                            SELECT TOP 1 p.Name, COUNT(*) OrderCount, SUM(o.Price) TotalOrderPrice FROM Persons p 
                            JOIN Orders o
                                ON p.PersonId = o.PersonId
                            GROUP BY p.Name
                            HAVING SUM(o.Price) > @totalOrderPrice
                            ORDER BY OrderCount DESC ");
}

/// <inheritdoc />
protected override void Down(MigrationBuilder migrationBuilder)
{
    migrationBuilder.Sql($@"DROP FUNCTION bestSellingStaff");
}
```

# Inline Function'ı EF Core'a Entegre Etme
- Inline FUnction'lar geriye bir tablo döndürdüğü için bu tablo sonucunu karşılayacak bir model'e ihtiyacımız olacak.

```C#
var persons = await context.BestSellingStaff(3000).ToListAsync();
foreach (var person in persons)
{
    Console.WriteLine($"Name : {person.Name} | Order Count : {person.OrderCount} | Total Order Price : {person.TotalOrderPrice}");
}
```

```C#
1. Adım
public class BestSellingStaff
{
    public string Name { get; set; }
    public int OrderCount { get; set; }
    public int TotalOrderPrice { get; set; }
}

2. Adım
public IQueryable<BestSellingStaff> BestSellingStaff(int totalOrderPrice = 0)
    => FromExpression(()=> BestSellingStaff(totalOrderPrice));

3. Adım
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.HasDbFunction(typeof(ApplicationDbContext).GetMethod(nameof(ApplicationDbContext.BestSellingStaff),new[] { typeof(int) })).HasName("bestSellingStaff");

    modelBuilder.Entity<BestSellingStaff>()
        .HasNoKey();
}
```


# Entity & DbContext
```C#
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
public class BestSellingStaff
{
    public string Name { get; set; }
    public int OrderCount { get; set; }
    public int TotalOrderPrice { get; set; }
}

class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Order> Orders { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Scalar
        modelBuilder.HasDbFunction(typeof(ApplicationDbContext).GetMethod(nameof(ApplicationDbContext.GetPersonTotalOrderPrice), new[] {typeof(int)}))
            .HasName("getPersonTotalOrderPrice");
        #endregion
        #region Inline
        modelBuilder.HasDbFunction(typeof(ApplicationDbContext).GetMethod(nameof(ApplicationDbContext.BestSellingStaff),new[] { typeof(int) })).HasName("bestSellingStaff");


        modelBuilder.Entity<BestSellingStaff>()
            .HasNoKey();
        #endregion

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<Person>()
            .HasMany(p=>p.Orders)
            .WithOne(o=>o.Person)
            .HasForeignKey(o=>o.PersonId);
    }

    #region Scalar Functions
    public int GetPersonTotalOrderPrice(int personId)
        => throw new Exception();
    #endregion
    #region Inline Functions
    public IQueryable<BestSellingStaff> BestSellingStaff(int totalOrderPrice = 0)
        => FromExpression(()=> BestSellingStaff(totalOrderPrice));
    #endregion
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=ApplicationDb;User ID=SA;Password=1q2w3e4r!.;TrustServerCertificate=True;");
    }
} 
```