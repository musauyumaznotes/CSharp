# Stored Procedure Nedir?
- View yapılanması gibi kompleks sorgularımızı daha kolay bir şekilde sorgulayabilmemizi sağlayan bir fonksiyonalite özelliğine sahip veritabanı nesnesidir.

- View bir tablo gibi davranış sergilerken Stored Procedure ise bir prosedürdür. parametreli bir yapıya sahiptir bir fonksiyon gibi davranış gösterir.

- Yapmış olduğumuz sorgularda daha az maliyetli sorgulamalar yapmamızı sağlayan bir veritabanı nesnesidir.

- Stored Procedure view'lar gibi kompleks sorgularımız daha basit bir şekilde tekrar kullanılabilir bir hale getirmemizi sağlayan veritabanı nesnesidir.

- View'ler tablo misali bir davranış sergilerken Stored Procedur'ler ise fonksiyonel bir davranış sergilerler.

-  Ve türlü türlü artılarıda vardır.

# Stored Procedure Oluşturma 
- Ef Core Stored Procedure ve View ile ilgili hazır bir oluşturucu yapılanmaya sahip değildir. Çünkü bu yapılanmaların içindeki sorguları bizlerin oluşturması gerekiyor EF Core bunu bilemez.ü
1. adım : Boş bir migration oluştururuz.
2. adım : Migration içindeki Up fonksiyonunda Stored Procedure'ı oluşturan create komutlarını yazıyoruz.
3. adım : Migration içindeki Down fonksiyonunda oluşturmuş olduğumuz Stored Procedure'ü drop eden komutlarımızı yazıyoruz.
4. adım : Migrate ediniz

```C#
public partial class mig_2 : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql($@"CREATE PROCEDURE sp_PersonOrders
                                AS
                                    SELECT p.Name,COUNT(*) FROM Persons p
                                    Join Orders o
                                    	ON p.PersonId = o.PersonId
                                    GROUP BY p.Name
                                    ORDER BY COUNT(*) DESC");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql($@"DROP PROC sp_PersonOrders");
    }
}
```

# Stored Procedure'ü Kullanma 
- FromSql komutu ile Stored Procedure'ü kullanabiliriz. Lakin bu komutu kullanabilmek için bizlere DbSet Property'si gerekmektedir.

- FromSql ilgili procedure yapılanmasını execute edeceğinden dolayı burada sonuç olarak bir tablo alırız. İşte bu tablo sonucunu ORM'in yapısı gereği kod tarafında eşleştirebilmemiz için bir entity karşılığına ihtiyacı vardır. İşte bunu yapabilmek için bizim illaki bir DbSet property'sine ihtiyacımız olacak.

- Dikkat Stored Procedure yapılanmasını direkt DbSet property'si üzerinden kullanmayacaksın. DbSet'in üzerinden dolaylı olarak FromSql ile StoredProcedure'ı tetikleyeceksin/execute edeceksin gelen verileri o DbSet'in entity türünde elde edeceksin.

- Stored Procedure'ü kullanabilmek için bir entity'e ihtiyacımız vardır. Bu entity'nin DbSet property'si olarak context nesnesine de eklenmesi gerekmektedir.

- Bu DbSet proeprty'si üzerinden FromSql fonksiyonunu kullanarak 'EXEC ....' komutu eşliğinde Stored Procedure yapılanmasını çalıştırıp sorgu neticesini elde edebilirsiniz.
# FromSql
- Temel yapılanmayı oluşturduktan sonra yani Stored Procedure'ü karşılayacak olan entity'yi tasarlayıp bunu da DbSet olarak ekledikten sonra  ve bu DbSet ile ilgili temel konfigürasyonları gerçekleştirdikten sonra artık sorgulamayı gönül rahatlığıyla yapabiliriz.

- Bir ORM yapılanması kullanıyoruz tabiki de bu ORM Dapper'da olduğu gibi salt sorgularla çalışmaya çok yatkın değil ama yapamıyor değiliz. EF Core salt sorgularımızı oluştururken illa ki bir entity türünden o sorgu neticesini karşılayacaksın diye bize zorunlu bir kural dayatıyor.

```C#
public class PersonOrder
{
    public string Name { get; set; }
    public int Count { get; set; }
}

public DbSet<PersonOrder> PersonOrders { get; set; }

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<PersonOrder>()
        .HasNoKey();
}

```
```C#
var datas = await context.PersonOrders.FromSql($"EXEC sp_PersonOrders").ToListAsync();
```

# Geriye Değer Döndüren Stored Procedure'ü Kullanma 
- Sadece sayısal değerler döndürülebilir.

```C#
SqlParameter countParameter = new()
{
    ParameterName = "count",
    SqlDbType = System.Data.SqlDbType.Int,
    Direction = System.Data.ParameterDirection.Output,
};
await context.Database.ExecuteSqlRawAsync($"EXEC @count = sp_bestSellingStaff", countParameter);
Console.WriteLine(countParameter.Value);
```
# Parametreli Stored Procedure Kullanımı 
# Input Parametreli Stored Procedure'ü Kullanma
# Output Parametreli Stored Procedure'ü Kullanma
```C#
SqlParameter nameParameter = new()
{
    ParameterName = "name",
    SqlDbType = System.Data.SqlDbType.NVarChar,
    Direction = System.Data.ParameterDirection.Output,
    Size= 1000
};

await context.Database.ExecuteSqlRawAsync($"EXECUTE sp_PersonOrders2 7, @name OUTPUT",nameParameter);
Console.WriteLine(nameParameter.Value);
```

