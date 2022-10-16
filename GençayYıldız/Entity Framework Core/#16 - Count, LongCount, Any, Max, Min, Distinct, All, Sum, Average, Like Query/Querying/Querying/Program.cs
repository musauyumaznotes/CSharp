using Microsoft.EntityFrameworkCore;


ETicaretContext context = new();

#region Diğer Sorgulama Fonksiyonları
#region CountAsync
//Oluşturulmuş bir sorgunun execute neticesinde kaç tane verinin/satırın geleceğini bizlere sayısal olarak (int) bildiren bir fonksiyon
//Count tetiklendiği anda generate edilecek sorguya count fonksiyonu ekleyecek ve bunu execute edecek.Execute neticesinde elde edilecek sayısal değeri bizlere geri döndürecektir.
//Veritabanındaki verilerin/satırların hepsini burada saymaktansa direkt veritabanı kısmında bu verilerde/satırlarda sorgu neticesinde kaç tane verinin/satırın döneceğini sayısal olarak almam muazzam derece de maliyetten bizleri kurtarmış olacaktır. 

//var urunler = (await context.Urunler.ToListAsync()).Count(); //Burada tüm ürünleri çektik ardından bellekte kaç tane olduğunu hesapladık.
//var urunler = await context.Urunler.CountAsync();
#endregion

#region LongCountAsync
//Oluşturulmuş bir sorgunun execute neticesinde kaç tane verinin/satırın geleceğini bizlere sayısal olarak (long) bildiren bir fonksiyon

//var urunler = await context.Urunler.LongCountAsync(u => u.Fiyat > 5000);
#endregion

#region AnyAsync
//Sorgu neticesinde verinin gelip gelmediğini bool türünde dönen fonksiyondur.
//var urunler = await context.Urunler.Where(u => u.UrunAdi.Contains("1")).AnyAsync();
//var urunler = await context.Urunler.AnyAsync(u => u.UrunAdi.Contains("1"));
#endregion

#region MaxAsync
//Oluşturulan sorguda verilen kolonda en yüksek olan değer hangisiyse sayısal olarak en yüksek olan değer hangisiyse bizlere onu getirir.
//Verilen kolondaki max değeri getirir.

//var fiyat = await context.Urunler.MaxAsync(u => u.Fiyat);
#endregion

#region MinAsync
//Oluşturulan sorguda verilen kolonda en küçük olan değer hangisiyse sayısal olarak en küçük olan değer hangisiyse bizlere onu getirir.
//Verilen kolondaki min değeri getirir.

//var fiyat = await context.Urunler.MinAsync(u => u.Fiyat);
#endregion

#region Distinct
//Sorguda mükerrer/tekrarlı kayıtları tekilleştiren bir işleve sahip bir fonksiyondur.
//Çağırdığımızda IQueryable olarak dönüş sağladığı için bizim bu sorguyu execute etmemiz gerekir
//var urunler = await context.Urunler.Distinct().ToListAsync();
#endregion

#region AllAsync
//Bir sorgu neticesinde gelen verilerin, verilen şarta uyup uymadığını kontrol etmektedir. Eğer ki tüm veriler şarta uyuyorsa true, uymuyorsa false döndürecektir.

//var m = await context.Urunler.AllAsync(u => u.Fiyat < 15000);
var m = await context.Urunler.AllAsync(u => u.UrunAdi.Contains("a"));
#endregion

#region SumAsync
//Vermiş olduğumuz sayısal property'inin toplamını alan fonksiyonudur.

//var fiyatTOplam = await context.Urunler.SumAsync(u => u.Fiyat);
#endregion

#region AvarageAsync
//Vermiş olduğumuz sayısal property'inin aritmetik ortalamasını alan fonksiyonudur.
var aritmetikOrtalama = await context.Urunler.AverageAsync(u => u.Fiyat);
#endregion

#region ContainsAsync
//Like ('%...%') sorgusu oluşturmamızı sağlar
//Generate edilecek sorguya like şartını/parametresini/keywordünü yerleştrimek istiyorsanız bunu Where ile gerçekleştirmelisiniz.
//var urunler = await context.Urunler.Where(u=>u.UrunAdi.Contains("7")).ToListAsync();
#endregion

#region StartsWith
//Like ('...%') sorgusu oluşturmamızı sağlar
//Generate edilecek sorguya like şartını/parametresini/keywordünü yerleştrimek istiyorsanız bunu Where ile gerçekleştirmelisiniz.
//var urunler = await context.Urunler.Where(u => u.UrunAdi.StartsWith("7")).ToListAsync();
#endregion

#region EndsWith
//Like ('%...') sorgusu oluşturmamızı sağlar
//Generate edilecek sorguya like şartını/parametresini/keywordünü yerleştrimek istiyorsanız bunu Where ile gerçekleştirmelisiniz.
var urunler = await context.Urunler.Where(u => u.UrunAdi.EndsWith("7")).ToListAsync();
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