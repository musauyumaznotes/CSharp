using Microsoft.EntityFrameworkCore;

Console.WriteLine();

#region Veri Nasıl Güncellenir?
//Önce hangi veriyi güncelleyeceksem bu veriyi veritabanından çağırmam gerekiyor ki ardından güncellemeye tabi tutabileyim.
//Veriyi güncelleyebilmek için öncelikle o veriyi  context üzerinden bir sorgulama neticesinde elde ediyoruz.
//Biz EF Core kullanarak bir güncelleme işlemi yapacaksak eğer o güncellemeyi de nesne üzerinde gerçekleştiriyoruz.
//ETicaretContext context = new();

//Urun urun = await context.Urunler.FirstOrDefaultAsync(u => u.Id == 3);
//FirstOrDefault(): Where şartıyla hedef veriyi getirmemizi ve ilk olan veriyi seçmemizi sağlar. Bir şart veriyoruz ve verdiğimiz şarta uygun verilerin arasından ilkini getiren fonksiyondur. Yani sorguda TOP komutundan yararlanır.
// Buradaki sorgu sonucunda elde edilen veri neyse bu veri yazılım kısmına geldiğinde entity türünden bir nesneye dönüştürülür.
//urun.UrunAdi = "H Ürünü";
//urun.Fiyat = 999;

//await context.SaveChangesAsync();

#endregion
#region ChangeTracker Nedir? Kısaca!
//ChangeTracker, context üzerinden gelen verilerin takibinden sorumlu bir mekanizmadır. Bu takip mekanizması sayesinde context üzerinden gelen verilerle ilgili işlemler neticesinde update yahut delete sorgularının oluşturulacağı anlaşılır! 
//EF Core context üzerinden gelen verileri ChangeTracker denilen mekanizma tarafından takibe alıyor. Bu mekanizma context'ten gelen veriyi durmadan takip ediyor.
//Buradaki takibin amacı context üzerinden gelen bu nesne üzerinde yapılan işleme uygun sorguyu oluşturabilmek
//Eğer ki bu nesne üzerinde belirli property'lerde değişiklikler yapılıyorsa işte bu değişiklikler neticesinde update sorgusu oluşturmamız gerektiğini anlıyoruz.Aynı şekilde bu nesne Remove ediliyorsa yani bir koleksiyondan DbSet'ten siliniyosa ChangeTracker sayesinde bir delete sorgusu oluşturulması gerektiği anlaşılıyor.
//Dolayısıyla EF Core yapılanmasında context'in context'ten gelen nesneler üzerinde  nasıl bir davranış sergileyeceği yani SaveChanges'ı çağırdığımızda hangi sorguyu oluşturacağını anlayabilmesi için ChangesTracker mekanizması üzerinden bir çalışma sergiler.
//SaveChanges'ı çağırdıktan sonra silinecek verilere uygun silme sorgusunu güncellenecek verilere uygun güncelleme sorgusunu bu mekanizma sayesinde oluşturuluyor.
//EF Core mekanizması bir veriyi güncellerken ya da silerken bu veri context'ten gelir ve bu veri default/varsayılan olarak ChangeTracker denilen bir mekanizmayla takip edilir. İşte bu mekanizma sayesinde yapılan davranışa uygun sorgunun Generate edilerek veritabanına gönderilip execute edildiğini öğrenmiş olduk 
#endregion
#region Takip Edilmeyen Nesneler Nasıl Güncellenir?
//Veri eğer ki context'ten gelmezse yani EF Core'da entity'ler üzerinden oluşturmuş olduğumuz nesneler direkt veritabanından elde edilmediği için veritabanındaki nesneyle direkt eşleştirilmez.
//Context üzerinden gelmediğinden dolayı ChangeTracker devreye girmemiştir.
//Yani takip edilmeyen nesneler(context üzerinden gelmeyen,ChangeTracker devre dışı) için EF Core tarafından Update fonksiyonu üretilmiştir.
//ETicaretContext context = new();
//Urun urun = new()
//{
//    Id = 3,
//    UrunAdi = "Yeni Ürün",
//    Fiyat = 123
//};

#region Update Fonksiyonu
//ChangeTracker mekanizması tarafından takip edilmeyen nesnelerin güncellenebilmesi için Update fonksiyonu kullanılır!
//Update fonksiyonunu kullanabilmek için kesinlikle ilgili nesnede Id değeri verilmelidir! Update sorgusu oluşturulacak verinin hangisi olduğunu ifade edecektir.
//context.Urunler.Update(urun);
//await context.SaveChangesAsync();
//ChangeTracker mekanizmasıyla takip edilmeyen bu nesneyi ben güncellemek istiyorum Bunu da takip olmadığından dolayı direkt SaveChanges() metodunu çağıramam Update fonksiyonuyla EF Core'a bildiriyorum Bu bildirme neticesinde SaveChanges() metodunu çağırıyorum
//Buradaki yapılan davranış yine EF Core tarafından ortaya koyuluyor ardından bu sorgu oluşturulup Execute ettiriliyor. Yani ne olursa olsun günün sonunda biz her daim SaveChanges'ı çağırmamız gerekiyor.
#endregion
#endregion

#region EntityState Nedir?
//Bir entity instance'ının durumunu ifade eden bir referanstır.
//Entity Instance : Bir veritabanındaki tabloya tablo içerisindeki bir satıra karşılık gelen bir nesne
//Bu nesne neye yarıyor siliyor muyuz?/güncelliyor muyuz?/ekliyor muyuz? ne gibi bir duruma tabi tutulacak bununla ilgili bize bilgi veren bir referanstır.
//Detached : Herhangi bir işleme tabi tutulmamış en sade halde 
//ETicaretContext context = new();
//Urun u = new();
//Console.WriteLine(context.Entry(u).State);
#endregion
#region EF Core Açısından Bir Verinin Güncellenmesi Gerektiği Nasıl Anlaşılıyor?
//ETicaretContext context = new();
//Urun urun = await context.Urunler.FirstOrDefaultAsync(x=>x.Id == 3);
//Console.WriteLine(context.Entry(urun).State);// Unchanged : Üzerinde herhangi bir değişiklik yapılmadı Veritabanından geldi yani tarafsız değil bu önceden vardı veritabanından geldi ama şu anda üzerinde herhangi bir değişiklik yok

//urun.UrunAdi = "Hilmi";
//Console.WriteLine(context.Entry(urun).State);// Modified : Yani güncellemeye hazırlandı

//await context.SaveChangesAsync();
//Console.WriteLine(context.Entry(urun).State);// Unchanged : Veritabanına gönderildikten sonra tekrardan unchanged oldu.Çünkü bu noktadan sonra da bir değişiklik yapılmadı En son halini üzerine bir daha değişiklik yapılmadı. 

#endregion
#region Birden Fazla Veri Güncellenirken Nelere Dikkat Edilmelidir?
//Burada her güncellemeden sonra mı SaveChanges metodunu çağırıyorsun yoksa tüm güncelleme işlemlerinden sonra bir kereye mahsus mu SaveChanges'ı çağırıyorsun buna dikkat edilmesi gerekir. Çünkü SaveChanges sorguyu transaction eşliğinde execute eder.

ETicaretContext context = new();

var urunler = await context.Urunler.ToListAsync();
//ToListAsync : İlgili DbSet'e karşılık gelen tabloya Select sorgusu çekmek demektir Salt bir select sorgusu execute eder.
//Select sorgusunu execute ettiğine göre bizse List olarak ürün koleksiyonu getirir. Yani bütün ürünleri InMemory'e yüklüyoruz/elde ediyoruz yani ürün entity'si referansı türünde instance'lar elde ediyoruz.

foreach (var urun in urunler)
{
    urun.UrunAdi += "*";
    //await context.SaveChangesAsync();//Bu metodu burada çağırırsak muazzam bir maliyete sebep olmuş oluruz.Yani her bir ürün güncellemesinde ayrı ayrı transaction oluşturmuş oluruz.
}
await context.SaveChangesAsync();
//Yapılan güncellemelerin hepsi bütün entity'lerde yapılsın daha sonra bir kereye mahsus bunu veritabanına gönder/yansıt yani tek bir transaction oluştur. 
#endregion


public class ETicaretContext : DbContext
{
    public DbSet<Urun> Urunler { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=ETicaretDb;Trusted_Connection = true;");
    }
}

public class Urun
{
    public int Id { get; set; }
    public string UrunAdi { get; set; }
    public float Fiyat { get; set; }
}