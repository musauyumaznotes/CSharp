using Microsoft.EntityFrameworkCore;

ETicaretContext context = new();

#region Sorgu Sonucu Dönüşüm Fonksiyonları
//Elde edilen verileri farklı şekilde projeksiyon yapabilmemizi sağlayacak olan yahut başka bir deyişle elde ettiğimiz verileri farklı türlere dönüştürmemizi sağlayacak olan fonksiyonlardır.
//Bu fonksiyonlar ile sorgu neticesinde elde edilen verileri isteğimiz doğrultusunda farklı türlerde projeksiyon edebiliyoruz.
//Tüm hepsinde aynı sorgu oluşturulur. Sadece yazılım kısmında bunların elde edileceği türler/referanslar değişiyor
#region ToDictionaryAsync
//Veritabanından elde edeceğiniz değerleri bir dictionary olarak elde etmeniz gerekirse bu fonksiyonu kullanabilirsiniz. 
//Sorgu neticesinde gelecek olan veriyi bir dictionary olarak elde etmek/tutmak/karşılamak istiyorsak eğer kullanılır.
//ToList ile aynı amaca hizmet etmektedir. Yani oluşturlan sorguyu execute edip neticesini alırlar.
//ToList : Gelen sorgu neticesini entity türünde bir koleksiyona(List<TEntity>) dönüştürmektedir.
////ToDictionary : Gelen sorgu neticesini Dictionary türünden bir koleksiyona dönüştürecektir.
//var urunler = await context.Urunler.ToDictionaryAsync(u => u.UrunAdi, u => u.Fiyat);
#endregion

#region ToArrayAsync
//Oluşturulan sorguyu dizi olarak elde eder.
//ToList ile muadil amaca hizmet eder. Yani sorguyu execute eder lakin gelen sonucu entity dizisi olarak elde eder.
//var urunler = await context.Urunler.ToArrayAsync();
#endregion

#region Select
//Select fonksiyonunun işlevsel olark birden fazla davranışı söz konusudur.
//1. Select fonksiyonu generate edilecek sorgunun çekildecek kolonlarını ayarlamamızı sağlamaktadır. 
//2. Select fonksiyonu gelen verileri farklı türlerde karşılamamızı sağlar T, anonim
//var urunler = await context.Urunler.Select(u => new Urun
//{
//    Id = u.Id,
//    Fiyat = u.Fiyat
//}).ToListAsync();
//var urunler = await context.Urunler.Select(u=> new
//{
//    Id = u.Id,
//    Fiyat = u.Fiyat
//}).ToListAsync();
//var urunler = await context.Urunler.Select(u => new UrunDetay
//{
//    Id = u.Id,
//    Fiyat = u.Fiyat
//}).ToListAsync();
#endregion

#region SelectMany
//Select ile aynı amaca hizmet eder. Lakin ilişkisel tablolar neticesinde gelen koleksiyonel verileri de tekilleştirip projeksiyon etmemizi sağlar. 
var urunler = await context.Urunler.Include(u => u.Parcalar).SelectMany(u => u.Parcalar, (u, p) =>
new
{
    u.Id,
    u.Fiyat,
    p.ParcaAdi
}).ToListAsync();
#endregion
#endregion

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