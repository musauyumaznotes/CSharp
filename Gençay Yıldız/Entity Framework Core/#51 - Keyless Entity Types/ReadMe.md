# Keyless Entity Types
- Normal entity typeler'a ek olarak primary key içermeyen query'lere karşı veritabanı sorguları yürütmek için kullanılan bir özelliktir Keyless Entity Types.

- EF Core üzerinde bir sorgulama yapıyorsak Entity'lere karşılık DbSet'ler üzerinden gerçekleştiririz.

- Normal Entity'lerdeki sorgulamalar bir yana bizler bazen yapmış olduğumuz çalışmalarda/yazılımlarda özel sorgular üretebiliyoruz. Bu sorgular group by, pivot table, aggregate sorguların kullanıldığı farklı sorgulardır, istatiksel çalışmalardır, yani yapmış olduğumuz bu tarz türlü türlü sorgular neticesinde herhangi bir entity'e karşılık gelmeyen sonuçlar elde edecek query'ler üretebiliyoruz.

- Bazen kendimize özel komleks sorgular üretip execute ettiğimizde böyle belirli formatlarda sonuçlar elde edebiliyoruz. İşte bu sonuçlar genellikle Primary Key içermeyen query'lerdir. İşte bu tarz sorguları yapmamızı sağlayan yapılardır.

- Genellikle aggregate operasyonların yapıldığı group by yahut pivot table gibi işlemler neticesinde elde edilen istatiksel sonuçlar primary key kolonu barındırmazlar. Bizler bu tarz sorguları Keyless Entity Types özelliği ile sanki bir entity'e karşılık geliyormuş gibi çalıştırabiliriz.

# Keyless Entity Types Tanımlama
1. Hangi sorgu olursa olsun EF Core üzerinden bu sorgunun bir entity'e karşılık geliyormuş gibi işleme/execute'a/çalıştırmaya tabi tutulabilmesi için o sorgunun sonucunda bir entity'nin yine de tasarlanması gerekmektedir.
2. Bu Entity'nin DbSet property'si olarak DbContext nesnesine eklenmesi gerekmektedir.
3. Tanımlamış olduğumuz entity'e OnModelCreating fonksiyonu içerisinde girip bunun bir Key'i olmadığını bildirmeli (HasNoKey) ve hangi sorgunun çalıştırılacağıda ToView vs. gibi işlemlerle ifade edilmelidir.

```C#
var datas = await context.PersonOrderCounts.ToListAsync();
Console.WriteLine();
```
```C#
protected override void Up(MigrationBuilder migrationBuilder)
{
    migrationBuilder.Sql($@"CREATE VIEW vm_PersonOrderCount
                            AS
                            SELECT p.Name,COUNT(*) [Count] FROM Persons p
                            JOIN Orders o 
                            	ON o.PersonId = p.PersonId
                            GROUP BY p.Name");
}

/// <inheritdoc />
protected override void Down(MigrationBuilder migrationBuilder)
{
    migrationBuilder.Sql($@"DROP VIEW vm_PersonOrderCount");
}
public class PersonOrderCount
{
    public string Name { get; set; }
    public int Count { get; set; }
}
class ApplicationDbContext : DbContext
{
    public DbSet<PersonOrderCount> PersonOrderCounts { get; set; }
}
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<PersonOrderCount>()
        .HasNoKey()
        .ToView("vm_PersonOrderCount");
}

```



# Keyless Attribute'u
- Yine aynı şekil kullandığın DbSet'e karşılık gelen yapılanmanın Keyless yani Primary Key'e sahip olmayacağını bildirir.

```C#
[Keyless]
public class PersonOrderCount
{
    public string Name { get; set; }
    public int Count { get; set; }
}
```

# HasNoKey Fluent API'ı
- Yine aynı şekil kullandığın DbSet'e karşılık gelen yapılanmanın HasNoKey yani Primary Key'e sahip olmayacağını bildirir.

```C#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<PersonOrderCount>()
        .HasNoKey()
        .ToView("vm_PersonOrderCount");
}
```

# Keyless Entity Types Özellikleri Nelerdir?
- Primary Key kolonu OLMAZ!

- Change Tracker mekanizması aktif olmayacaktır.

- Table Per Hierarchy(TPH) olarak entity hiyerarşisinde kullanılabilir lakin diğer kalıtımsal ilişkilerde kullanılamaz!