using Microsoft.EntityFrameworkCore;
ETicaretContext context = new();
#region Change Tracking Neydi?
//Context üzerinden sorgulama neticesinde gelen bütün veriler bir takip mekanizması tarafından otomatik izlenmektedir. Bu takip mekanizması tarafından izlenen veriler üzerinde yapılan işlemler her neyse o işlemin fıtratına uygun sorgular generate edilerek işlemlerimizi gerçekleştirebilmekteyiz. Buradaki yapılan işleme göre uygun sorguyu generate ettiren yapılanmadır.
//Elimizdeki nesnelerin durumlarını kontrol edip onlara göre işlem gerçekleştiren mekanizmadır.
//Context nesnesi üzerinden gelen tüm nesneler/veriler otomatik olarak bir takip mekanizması tarafından izlenirler. İşte bu takip mekanizmasına Change Tracker denir. Change Tracker ile nesneler üzerindeki değişiklikler/işlemler takip edilerek netice itibariyle bu işlemlerin fıtratına uygun sql sorgucukları generate edilir. İşte bu işleme de Change Tracking denir.
#endregion

#region ChangeTracker Propertysi
//Takip edilen nesnelere erişebilmemizi sağlayan ve gerektiği taktirde işlemler gerçekleştirmemizi sağlayan bir property'dir.
//Context sınıfının base class'ı olan DbContext sınıfının bir member'ıdır.
//Yani ChangeTracker yapılanması benim yapmış olduğum değişikliklere uygun bir şekilde nesnelerin karşılığında statelerini tutmaktadır ki ben günün sonunda context.SaveChanges'ı çağırdığımda oradaki statelere uygun sorguları generate edebilsin ve edecektirde.
//var urunler = await context.Urunler.ToListAsync();//Bu işlemi yaptığımızda ürünlere karşılık sorgu oluşturulacak execute edilecek ve execute neticesinde gelecek olan bütün veriler in memory'de entity instance'ları olarak tutulacak işte buradaki entity instance'ları otomatik olarak bir takip mekanizması tarafından izlenecek bu yüzden artık ChangeTracker mekanizması üzerinden erişilebilir durum kontrolü yapılabilir ve gerektiği taktirde müdahale edilebilir nesneler olacaktır.
//urunler[6].Fiyat = 123;//Update
//context.Urunler.Remove(urunler[7]);//delete
//urunler[8].UrunAdi = "asdsadsa"; //Update 


//var datas = context.ChangeTracker.Entries();

#region DetectChanges Metodu
//Yapılan operasyonlarda güncel tracking verilerinden emin olmak için DetectChanges metodundan istifade edebiliriz.
//EF Core, ontext nesnesi tarafından izlenen tüm nesnelerdeki değişiklikleri Change Tracker sayesinde takip edebilmekte ve nesnelerde olan verisel değişiklikler yakalanarak bunların anlık görüntüleri (snapshot)'ini oluşturabilir.
//Yapılan değişikliklerin veritabanına gönderilemden önce algılandığından emin olmak gerekir. SaveChanges fonksiyonu çağırıldığı anda nesneler EF Core tarafından otomatik olarak kontrol edilirler.
//Ancak yapılan operasyonlarda güncel tracking verilerinden emin olabilmek için değişikliklerin algılanmasını opsiyonel olarak gerçekleştirmek isteyebiliriz. İşte bunun için DetectChanges fonksiyonu kullanıbilir ve her ne kadar EF Core değişiklikleri otomatik algılıyor olsa da siz yine de iradenizle kontrole zorlayabilirsiniz.
//Sistemde yapılan değişiklikleri iradeli bir şekilde tekrardan kontrol et ve Change Tracker mekanizmasındaki State'leri ona göre güncelle
//SaveChanges metodunu çağırdığınızda/tetiklediğinizde DetectChanges metodu otomatik çağrılıyor/tetikleniyor yani SaveChanges bunu yapıyor 
//EF Core her ne kadar buradaki Change Tracker mekanizmasının değerlerini kontrol ediyor olsun her ne kadar SaveChanges'ı çağırdığımızda/tetiklediğimizde arkada DetectChanges metodu tetikleniyor/çağırılıyor olsa da biz yine de bazı durumlarda güvenmiyorsak son verilerin güncel verilerin kesinlikle Detect edilmesini istiyorsak DetectChanges fonksiyonunu tetikleyebiliriz. Bu amaçla kullanıyoruz. 

//var urun = await context.Urunler.FirstOrDefaultAsync(u=>u.Id == 3);
//urun.Fiyat = 123;

//context.ChangeTracker.DetectChanges(); 
//await context.SaveChangesAsync();
#endregion

#region AutoDetectChangesEnabled Property'si
//Bu property DetectChanges'ın otomatik olarak tetiklenmesinin konfigürasyonunu sağlıyor
//İlgili metotlar(SaveChanges, Entries) tarafından DetectChanges metodunun otoömatik olark tetiklenmesinin konfigürasyonunu yapmamızı sağlayan property'dir.
//SaveChanges fonksiyonu tetiklendiğinde DetectChanges metodunu içerisinde default olarak çağırmaktadır. Bu durumda DetectChanges fonksiyonunun kullanımını irademizle yönetmek ve maliyet/performans optimizasyonu yapmak istediğimiz durumlarda AutoDetectChangesEnabled özelliğini kapatabiliriz.
#endregion

#region Entries Metodu
//ChangeTracker mekanizması tarafından izlenen her entity nesnesinin bilgisini EntityEntry türünden elde etmemizi sağlayan bir metotdur. Bu metot üzerinde elde ettiğimiz verilerin üzerinde işlemlerimizi rahatlıkla gerçekleştirebilmekteyiz.
//Context'te ki Entry metodunun koleksiyonel versiyonudur.
//Bütün takip edilen nesnelerle ilgili State bilgisini bize döndürür.
//Change Tracker mekanizması tarafından izlenen her entity nesnesinin bilgisini EntityEntry türünden elde etmemizi sağlar ve belirli işlemler yapabilmemize olanak tanır.  
//Entries metodu,ilk önce DetectChanges metodunu tetikler. Bu durum da tıpki SaveChanges'da olduğu gibi bir maliyettir. Buradaki maliyetten kaçınmak için AutoDetectChangesEnabled özelliğine false değeri verilebilir.

//var urunler = await context.Urunler.ToListAsync();
//urunler.FirstOrDefault(u => u.Id == 7).Fiyat = 123;//update
//context.Urunler.Remove(urunler.FirstOrDefault(u => u.Id == 8));//delete
//urunler.FirstOrDefault(u => u.Id == 9).UrunAdi = "dasdsads";//update

//context.ChangeTracker.Entries().ToList().ForEach(e => 
//{
//    if (e.State == EntityState.Unchanged)
//    {
//        //...
//    }
//    else if (e.State == EntityState.Deleted)
//    {
//        //...
//    }
//});

#endregion

#region AcceptAllChanges Metodu
//SaveChanges() SaveChanges(true) tetiklendiğinde EF Core herşeyin yolunda olduğunu varsayarak track ettiği verilerin takibini keser yani değişikliklerin takip edilmesini bekler. Böyle bir durumda beklenmeyen bir durum/olası bir hata söz konusu olursa eğer EF Core takip ettiği nesneleri bırakacağı için bir düzeltme mevzu bahis olamayacaktır. 

//Haliyle bu durumda devreye SaveChanges(false) ve AcceptAllChanges metotları girecektir.

//SaveChanges(false) EF Core'a gerekli veritabanı komutlarını yürütmesini söyler ancak gerektiğinde yeniden oynatılabilmesi için değişiklikleri beklemeye/nesneleri takip etmeye devam eder. Taa ki AcceptAllChanges metodunu irademizle çağırana kadar.

//SaveChanges(false) ile işlemin başarılı olduğundan emin olursanız AcceptAllChanges metodu ile nesnelerden takibi kesebilirsiniz.

//var urunler = await context.Urunler.ToListAsync();
//urunler.FirstOrDefault(u => u.Id == 7).Fiyat = 123;//update
//context.Urunler.Remove(urunler.FirstOrDefault(u => u.Id == 8));//delete
//urunler.FirstOrDefault(u => u.Id == 9).UrunAdi = "dasdsads";//update

//await context.SaveChangesAsync(false);
//context.ChangeTracker.AcceptAllChanges();
#endregion

#region HasChanges Metodu
//Takip edilen nesneler arasında değişiklik yapılanların olup olmadığının bilgisini verir.
//Arka planda DetectChanges metodunu tetikler.
//var result = context.ChangeTracker.HasChanges();
#endregion

#region Entity States
//Entity nesnelerinin durumlarını ifade eder.
//Entity nesnelerimizin en sonki Change Tracker mekanizması tarafından takip edilen durmunu ifade eder.

#region Detached
//Nesnenin Change Tracker mekanizması tarafından takip edilmediğini ifade eder.
//Urun urun = new();
//Console.WriteLine(context.Entry(urun).State);
//urun.UrunAdi = "asfasdasf";
//await context.SaveChangesAsync();
#endregion

#region Added
//Veritabanına eklenecek nesneyi ifade eder. Added henüz veritabanına işlenmeyen veriyi ifade eder. SaveCahnges fonksiyonu çağırıldığında insert sorgusu oluşturulacağı anlamına gelir.
//Dışarıdan gelen ya da manuel olarak oluşturduğum nesneyi ben contexte soktuğum zaman ondan sonra takip mekanizması devam edecektir.
//Urun urun = new() { Fiyat = 123, UrunAdi = "Ürün 1001" };
//Console.WriteLine(context.Entry(urun).State);
//await context.Urunler.AddAsync(urun);
//Console.WriteLine(context.Entry(urun).State);
//await context.SaveChangesAsync();
//urun.Fiyat = 321;
//Console.WriteLine(context.Entry(urun).State);
//await context.SaveChangesAsync();
#endregion

#region Unchanged
//Veritabanından sorgulandığından beri nesne üzerinde herahngi bir değişiklik yapılmadığını ifade eder. Sorgu neticesinde elde edilen tüm nesneler başlangıçta/default durumda bu state değerindedir.
//var urunler = await context.Urunler.ToListAsync();
//var data = context.ChangeTracker.Entries();
#endregion

#region Modified
//Nesne üzerinde değişiklik/güncelleme yapıldığını ifade eder. SaveChanges fonksiyonu çağırıldığında/tetiklendiğinde update sorgusu oluşturulacağı anlamına gelir.
//var urun = await context.Urunler.FirstOrDefaultAsync(u => u.Id == 1);
//Console.WriteLine(context.Entry(urun).State);
//urun.UrunAdi = "fsafsafgafa";
//Console.WriteLine(context.Entry(urun).State);
//await context.SaveChangesAsync(false);
//Console.WriteLine(context.Entry(urun).State);
#endregion

#region Deleted
//Nesnenin silindiğini ifade eder. SaveChanges fonksiyonu çağırıldığında delete sorgusu oluşturulacağı anlamına gelir.
//var urun = await context.Urunler.FirstOrDefaultAsync(u => u.Id == 1);
//context.Urunler.Remove(urun);
//Console.WriteLine(context.Entry(urun).State);
//await context.SaveChangesAsync();
//Console.WriteLine(context.Entry(urun).State);
#endregion
#endregion

#region Context Nesnesi Üzerinden Change Tracker
//Change Tracker tarafından takip edilen ister tek bir nesnenin(Entry) ya da takip edilen tüm nesnelerin (ChangeTracker.Entries) ile değişiklikleri ya da yapılan işlemleri gözlemleyebiliriz.
//var urun = await context.Urunler.FirstOrDefaultAsync(u => u.Id == 1);
//urun.Fiyat = 123;
//urun.UrunAdi = "Silgi";//Modified | Update
#region Entry Metodu
#region OriginalValues Property'si
//Burada verilerin değişmeden önceki hallerini elde edebiliriz.
//Ola ki yapılan değişiklikler veritabanına yansıtılmadan evvel veritabanındaki en güncel verileri elde etmek istiyorsanız  OriginalValues property'sini kullanabiliriz.
//var fiyat = context.Entry(urun).OriginalValues.GetValue<float>(nameof(Urun.Fiyat));
//var urunAdi = context.Entry(urun).OriginalValues.GetValue<string>(nameof(Urun.UrunAdi));
#endregion

#region CurrentValues Property'si
//Mevcut değerini elde etmen gerekirse CurrentValues Property'sini kullanabiliriz.
//O andaki instance'ın Heap'teki değerini getirdi
//var urunAdi = context.Entry(urun).OriginalValues.GetValue<string>(nameof(Urun.UrunAdi));
#endregion

#region GetDatabaseValues Metodu
//Vermiş olduğumuz nesneye göre veritabanındaki en güncel halini yine entity olarak elde etmemizi sağlıyor
//var _urun = await context.Entry(urun).GetDatabaseValuesAsync();
//Console.WriteLine();
#endregion
#endregion
#endregion
#endregion
#region Change Tracker'ın Interceptor Olarak Kullanılması
//Bir veri eklerken/güncellerken/silerken SaveChanges metodunu çağırıyoruz. SaveChanges metodunu override ederek interceptor mantığında operasyonlar gerçekleştirebiliriz.
//Veritabanına gönderilmeden önce araya girip operasyon gerçekleştirmek istiyorsak eğer SaveChanges'ı override edebiliriz.
//Genellikle ekleme durumlarında AutoGenerate edilmeyen identity kolonlarımız mevcuttur. Bunları manuel şekilde kendimiz generate etmemiz gereklidir. Her veri ekleme sürecinde ekleme esnasında ilgili id Kolonuna karşılık veri oluşturmaktansa bunu SaveChanges'ta bu şekilde interceptor mantığında araya girerek eğer bir ekleme söz konusuysa id'ye şu değeri oluşturup ver şeklinde çalışmalarımızı tek elden yönetebiliyoruz. 
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
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker.Entries();
        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {

            }
        }

        return base.SaveChangesAsync(cancellationToken);
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