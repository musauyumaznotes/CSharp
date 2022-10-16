# GroupBy Fonksiyonu
- Gruplama yapmamızı sağlayan bir fonksiyondur.
## Method Syntax
```C#
var datas = context.Urunler.GroupBy(u => u.Fiyat).Select(group => new
{
   Count = group.Count(),
   Fiyat = group.Key
}).ToListAsync();
```
## Query Syntax
```C#
var datas = await (from urun in context.Urunler
           group urun by urun.Fiyat
           into @group 
           select new
           {
               Fiyat = @group.Key,
               Count = @group.Count()
           }).ToListAsync();
```

# Foreach Fonksiyonu
- Bir sorgulama fonksiyonu değildir!
- Sorgulama neticesinde elde edilen koleksiyonel veriler üzerinde iterasyonel olark dönmemizi ve teker teker verileri elde edip işlemler yapabilmemizi sağlayan bir fonksiyondur.Foreach döngüsünün metot halidir.

```C#
foreach (var item in datas)
{

}
datas.ForEach(x =>
{
    
});
```

```C#
public class ETicaretContext : DbContext
{
    public DbSet<Urun> Urunler { get; set; }
    public DbSet<Parca> Parcalar { get; set; }
    public DbSet<UrunParca> UrunParca { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=ETicaretDB;Trusted_Connection=true;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UrunParca>().HasKey(up => new { up.UrunId, up.ParcaId });
    }
}
public class Urun
{
    public int Id { get; set; }
    public string UrunAdi { get; set; }
    public float Fiyat { get; set; }
    public ICollection<Parca> Parcalar { get; set; }

}
public class Parca
{
    public int Id { get; set; }
    public string ParcaAdi { get; set; }
}
public class UrunParca
{
    public int UrunId { get; set; }
    public int ParcaId { get; set; }

    public Urun Urun { get; set; }
    public Parca Parca { get; set; }
}

public class UrunDetay
{
    public int Id { get; set; }
    public float Fiyat { get; set; }
}
```