- Oluşturmak istediğin bir kompleks sorgu vardır ve sen bunu linq ile ifade edemiyorsundur ya da linq ile ifade edilmiş bir sorgunun daha da optimize edilmiş kendi tarafımızdan daha da optimize edilerek üretilmiş farklı bir varyasyonu vardır bunu da kullanmak isteyebiliriz.

- Eğer ki sorgunuzu LINQ ile ifade edemiyorsanız yahut LINQ'in ürettiği sorguya nazaran daha optimize bir sorguyu manuel geliştirmek ve EF Core üzerinden execute etmek istiyorsanız EF Core'un bu davranışı desteklediğini bilmelisiniz.

- Bir sorgu oluşturacaksanız eğer manuel olarak oluşturacağınız sorguyu execute edebilmek için bu sorguya karşılık bir entity'nizin olması gerekiyor. Bu sorgunun sonucu karşılayacak bir entity'niz olması gerekiyor. 

- Manuel bir şekilde/tarafımızca oluşturulmuş olan sorguları EF Core tarafından execute edebilmek için o sorgunun sonucunu karşılayacak bir entity model'ın tasarlanmış ve bunun DbSet olarak context nesnesine tanımlanmış olması gerekiyor.

- Herhengi bir sorguyu çalıştırmak istiyorsanız bu sorgu sizin manuel de yazmış olduğunuz sorgu olsa dahi EF Core bu sorgu sonucunda gelecek yapıya uygun bir entity'nin kendisine DbSet olarak tanımlanmış olmasını ister.

- Manuel/Ham olarak yazmış olduğumuz sorgulara/SQL cümleciklerine direkt LINQ fonksiyonlarını kullanarak katkıda bulunabiliriz. 

# FromSqlInterpolated
- EF Core 7.0 sürümünden önce ham sorguları execute edebildiğimiz fonksiyondur.

```C#
var persons = await context.Persons.FromSqlInterpolated($"Select * From Persons")
   .ToListAsync();
```


#region FromSql - EF Core 7.0
- EF Core 7.0 ile gelen metottur.

# Query Execute
```C#
var persons = await context.Persons.FromSql($"Select * from Persons")
   .ToListAsync();
```

# Stored Procedure Execute
```C#
var persons = await context.Persons.FromSql($"EXECUTE dbo.sp_GetAllPersons 4").ToListAsync();
```

# Parametreli Sorgu Oluşturma
- SQL cümlecikleri dışarıdan kod üzerinde/o anda/runtime'da oluşturulan veriler üzerinde parametre değerlerini veritabanına göndermek istiyor olabilir.
- Sorguları yazarken alınan değeri direkt olarak parametre olarak verirsek bu değer arka planda ilk baş Dbparameter nesnesine dönüştürür. Bunu yaptıktan sonra default tanımlamaları yapar ardından sorguyu veritabanına yollayarak execute ediyor.
- Biz bir sorguda parametre kullanacaksak eğer bu parametreleri Dbparameter şeklinde tanımlamalı ve ardından execute etmek için parametre olarak sorguya vermeliyiz Bu da bizlere mikro düzeyde optimizasyon sağlamış oluyor.
### Ornek 1
```C#
int personId = 3;
var persons = await context.Persons.FromSql($"Select * From Persons Where PersonId = {personId}").ToListAsync();
```

- Burada sorguya geçirilen personId değişkeni arkaplanda bir Dbparameter türüne dönüştürülerek o şekilde sorguya dahil edilmektedir.

### Ornek 2
```C#
int personId = 3;
var persons = await context.Persons.FromSql($"EXECUTE dbo.sp_GetAllPersons {personId}").ToListAsync();
```

### Ornek 3
```C#
SqlParameter personId = new("PersonId","3");
personId.DbType = DbType.Int32;
personId.Direction = ParameterDirection.Input;
var persons = await context.Persons.FromSql($"Select * from Persons Where PersonId = {personId}").ToListAsync();
```

### Ornek 4
```C#
SqlParameter personId = new("PersonId", "3");
personId.DbType = DbType.Int32;
personId.Direction = ParameterDirection.Input;
var persons = await context.Persons.FromSql($"EXECUTE dbo.sp_GetAllPersons {personId}").ToListAsync();
```

### Ornek 5
```C#
SqlParameter personId = new("PersonId", "3");
personId.DbType = DbType.Int32;
personId.Direction = ParameterDirection.Input;
var persons = await context.Persons.FromSql($"EXECUTE dbo.sp_GetAllPersons @PersonId = {personId}").ToListAsync();
```

- Parametreleri verirken hangi parametreye geldiğini sorgu içinde belirtmekte fayda vardır.

# Dynamic SQL Oluşturma Ve Parametre Girme - FromSqlRaw
- Bizler her daim sorgularımızı direkt oluşturamıyoruz. Bazı çalışmalarda sorguları yazılım üzerinden üretmemiz gerekebiliyor. İşte bu sorguların tablo bilgileri olsun kolon bilgileri olsun ve sorgunun genel gramatik yapılanmasındaki kritik keywordler olsun bunların hepsini biz yazılım üzerinden generate etmek zorunda kalabiliyoruz. Bu yöntemi bu gibi durumlarda kullanırız.

- EF Core'da herhangi bir sorguyu dinamik olarak oluşturuyorsak özellikle o sorgunun kolon isimleri parametreleştirilmişse EF Core generate edilen o sorguyu Execute etmez.

```C#
string columnName = "PersonId";
SqlParameter value = new("PersonId", "3");
var persons = await context.Persons.FromSqlRaw($"Select * From Persons Where {columnName} = @PersonId", value)
   .ToListAsync();
```

- FromSql ve FromSqlInterpolated metotlarında SQL Injection vs. gibi güvenlik önlemleri alınmış vaziyettedir. Lakin dinamik olarak sorguları oluşturuyorsanz eğer burada güvenlikten geliştirici sorumludur. Yani gelen sorguda/veride yorumlar, noktalı virgüller yahut SQL'e özel karakterlerin algılanması ve bunların temizlenmesi geliştirici tarafından gerekmektedir.

# SqlQuery - Entity Olmayan Scalar Sorguların Çalıştırılması - Non Entity - EF Core 7.0
- Entity olmayan scalar sorguların çalıştırılmasını gerçekleştiriyoruz. Yani burada kastedilen tek gbir kolon olarak verilerin geldiği sorgular vardır. İşte bu sorguları durduk yere bir entity üzerinden çalıştırmaktansa direkt bunları herhangi bir entity tanımlamaya gerek kalmaksızın çalıştırabilmemizi sağlayacak bir fonksiyondur.

- Entity'si olmayan scalar sorgualrın çalıştırılıp sonucunu elde etmemizi sağlayan yeni bir fonksiyondur.

```C#
var data = await context.Database.SqlQuery<int>($"Select PersonId From Persons")
   .ToListAsync();

var persons = await context.Persons.FromSql($"Select * From Persons")
   .Where(p => p.Name.Contains("a")).ToListAsync();

var data = await context.Database.SqlQuery<int>($"Select PersonId Value From Persons")
   .Where(x => x > 5)
   .ToListAsync();
```

- SqlQuery ile vermiş olduğumuz sorgu arka planda bir subquery olarak üretiliyor.Dolayısıyla bu subquery üzerinden şart ekliyorsunuz. Burada EF Core şöyle bir kabul üzerinden bu şartı alabiliyor. Eğer ki sen üretmiş olduğun Subquery içerisindeki kolonun adını value olarak isimlendirirsen vereceğin şart ifadesi arka planda default olarak value'ya göre şekillendirilir.

- SqlQuery'de LINQ operatörleriyle sorguya ekstradan katkıda bulunmak istiyorsanız eğer bu sorgu neticesinde gelecek olan kolonun adını Value olarak bildirmeniz gerekmektedir. Çünkü SqlQuery metodu sorguyu bir subquery olarak generate etmektedir. Haliyle bu durumdan dolayı LINQ ile verilen şart ifadeleri statik olarak Value kolonuna göre tasarlanmıştır. O yüzden bu şekilde bir çalışma zorunlu gerekmektedir.

# ExecuteSql
- Burada sorgulamanın dışında yapmış olduğumuz çalışmaları bu fonksiyon üzerinden yürütüyoruz. Insert,Update,Delete operasyonları gibi

```C#
await context.Database.ExecuteSqlAsync($"Update Persons Set Name = 'Fatma' Where PersonId = 1");
```

- ExecuteSql operasyonu gerçekleştiriyorsanız SaveChanges metodunu çağırmak zorunda değilsiniz. Amma velakin EF Core üzerinden yapılacak Update sorgulamalarını manuel değil mümkün mertebe ORM'in tip güvenli bir şekilde sağlamış olduğu yöntemlerle gerçekleştirmeye ve SaveChanges fonksiyonu üzerinden execute etmeye özen göstermeliyiz. 

# Sınırlılıklar
### Queryler entity türünün tüm özellikleri için kolonlarda değer döndürmelidir.

- Yapmış olduğun query'de hangi entity'de çalışıyorsan ona uygun tüm property'lerine karşılık değerleri döndürmen gerekiyor aksi taktirde dönülen sorgunun sonucu o Entity olmuyor başka bir entity oluyor o zaman git onun üzerinde sorgulamayı yap demiş oluyor bize.

```C#
var persons = await context.Persons.FromSql($"Select Name from Persons")
   .ToListAsync();
var persons = await context.Persons.FromSql($"Select Name,PersonId from Persons")
   .ToListAsync();
```

### Sütun isimleri property isimleriyle aynı olmalıdır.
```C#
var persons = await context.Persons.FromSql($"Select Id from Persons")
   .ToListAsync();
var persons = await context.Persons.FromSql($"Select PersonID from Persons")
   .ToListAsync();
```

### SQL sorgusu join yapısı İÇEREMEZ!!! Haliyle bu tarz ihtiyaç noktalarında Include fonksiyonu KULLANILMALIDIR!

```C#
var persons = await context.Persons.FromSql($"Select * from Persons Join Orders ON Persons.PersonId = Orders.PersonId")
   .ToListAsync();
var persons = await context.Persons.FromSql($"Select * from Persons")
   .Include(p => p.Orders)
   .ToListAsync();
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
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ApplicationDb;User ID=SA; Password=1q2w3e4r!.;TrustServerCertificate=True;");
    }
}
```