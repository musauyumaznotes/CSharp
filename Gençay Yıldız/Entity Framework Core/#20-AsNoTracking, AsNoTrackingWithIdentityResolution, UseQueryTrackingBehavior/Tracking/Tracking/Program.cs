using Microsoft.EntityFrameworkCore;

ETicaretContext context = new();

//Change Tracker mekanizmasının davranışlarını yönetmemizi sağlayan fonksiyonlardır.
//Change Tracker mekanizması nesneleri takip ediyor Bu takibin bir maliyeti var ve bu maliyet takip edilen nesnelerle doğru orantılı. Biz veritabanından çektiğimiz her nesneyi takip etmek mecburiyetinde miyiz?
//Context üzerinden sorgulama neticesinde elde ettiğimiz tüm verilerde işlem yapacak mıyız?
//Eğer ki çekmiş olduğun sorgu neticesinde ilgili veriler üzerinde herahangi bir işlem yapmayacaksan sadece bunları project amaçlı kullanacaksan orada bu nesnelerin takip edilmesinin bir anlamı yok.
//Yeri geliyor yapılan sorgulamalar neticesinde milyonlarca veriyi elde edebiliyoruz. Ve biz bu milyonlarca veri üstünde işlem yapmayacaksam bunların takip edilmesinin ciddi bir maliyeti olacaktır. İşte Change Tracker mekanizmasının bu maliyetini lüzumsuz noktalarda törpülememiz gerekiyor.
#region AsNoTracking Metodu
//Context üzerinden gelen tüm datalar Change Tracker mekanizması tarafından takip edilmektedir.

//Change Tracker takip ettiği nesnelerin sayısıyla doğru orantılı olacak şekilde bir maliyete sahiptir. O yüzden üzerinde işlem yapılmayacak verilerin takip edilmesi bizlere lüzumsuz yere bir maliyet çıkaracaktır.

//AsNoTracking metodu, context üzerinden sorgu neticesinde gelecek olan verilerin Change Tracker tarafından takip edilmesini koparır/engeller.

//Context üzerinden yapmış olduğum sorgulama neticesinde gelecek olan bütün dataların takip edilmesini istemiyorsanız bu dataların üzerinde yapılacak değişikliklerle ilgili herahngi bir şekilde sorgu oluşturmayacaksanız değişiklik yapmayacaksanız AsNoTracking ile buradaki takip mekanizmasını devre dışı bırakabilirsiniz/koparabilirsiniz. Böylece lüzumlu yerde bu fonksiyonu kullanıyorsanız Change Tracker mekanizmasının lüzumsuz maliyetinden yapıyı kurtarmış olursunuz.

//AsNoTracking metodu ile Change Tracker'ın ihtiyaç olmayan verilerdeki maliyetini törpülemiş oluruz.

//AsNoTracking fonksiyonu ile yapılan sorgulamalar da verileri elde edebilir ve bu verileri istenilen noktalarda kullanabilir lakin veriler üzerinde herhangi bir değişiklik/update işlemi yapamayız.

//Sen değişiklik yapabilirsin ama SaveChanges metodunu çağırdığın zaman bu değişikliği yakalayacak bir Change Tracker mekanizman yok çünkü artık koparmışsın orada bir takip mekanizması olmayacağına göre değişikliği SaveChanges üzerinden hızlıca gerçekleştiremezsin.

//Listeleme/gösterme/projeksiyon etme gibi verileri veritabanından çekiyorsak eğer bunların maliyet oluşturmaması açısından Change Tracker ile takip edilmesine gerek yoktur.

//Eğer bir veri üstünde işlem gerçekleştirmeyeceksek yani Update/Delete gibi fonksiyonlar kullanmayacaksak verilerin takip edilmesine ihtiyaç yoktur.

//Biz bu verilere erişebiliriz.Ama instancelar üzerinde yapmış olduğum herhangi bir değişikliği direkt SaveChanges() metodu ile veritabanına yansıtamam.

//Context üzerinden gelen verilerin üzerinde herhangi bir değişiklik yapılmayacaksa bu verileri takip etmemiz gerekmeyecektir.Takip edilmesini istemediğimiz sorgularda da AsNoTracking fonksiyonunu kullanabiliriz.

//var kullanicilar = await context.Kullanicilar.AsNoTracking().ToListAsync();//Context üzerinden kullanıcılara bir select sorgusu çek amma gelecek olan verilerin/instancelarının takip edilmesine müsaade etme yani bunlara izlenmiyormuş/takip edilmiyormuş gibi çek. 
//AsNoTracking metodunu IQueryable kısmındayken yani sorgunun execute edilmeden evvel çağırılması gerekir.

//foreach (var kullanici in kullanicilar)
//{
//    Console.WriteLine(kullanici.Adi);
//    kullanici.Adi = $"yeni-{kullanici.Adi}";
//    Console.WriteLine(context.Entry(kullanici).State);
//}
//await context.SaveChangesAsync();
#endregion

#region AsNoTrackingWithIdentityResolution
//Change Tracker mekanizması devredeyse eğer veritabanından çekilen ilişkisel sorgularda aynı foreign keylere sahip nesneler için ayrı ayrı instance oluşturulmaz aynı instance'tan beslenirler.

//Eğer ki Change Tracker mekanizması devredeyse arkada ilişkisel verileri elde ederken bu verilere karşılık olan diğer nesneler aynıysa bu nesneler mükerrer bir şekilde tekrar tekrar oluşturulmayacaktır.

//Change Tracker mekanizması sayesinde yinelenen datalar aynı instanceları kullanırlar. 

//AsNoTracking metodu ile yapılan sorgularda yinelenen datalar farklı instancelarda karşılanırlar.

//Eğer ki ilişkisel verileri sorguluyorsanız AsNoTracking ile Change Tracker mekanizmasını koparırken bir düşünün ilişkisel veriler Change Tracker mekanizması sayesinde tek bir instance olarak tutulurken sizin Change Tracker mekanizmasını kaldırdığınız durumda artık buradaki nesnelerin takip edilmemesi söz konusu olacağından dolayı her birine karşılık bir instance oluşturuyor.

//Hem bağlantıyı koparmak hem de yinelenen datalarda tekil instance kullanmak istiyorsak işte o zaman AsNoTrackingWithIdentityResolution kullanmamız gerekiyor.

//ChangeTracker mekanizması yinelenen verileri tekil instance olarak getirir. Buradan ekstradan performans kazancı söz konusudur.

//Bizler yaptığımız sorgularda takip mekanizmasının AsNoTracking metodu ile maliyetini kırmak isterken bazen maliyete sebebiyet verebiliriz. (Özellikle ilişkisel tabloları sorgularken bu duruma  dikkat etmemiz gerekiyor.) 

//AsNoTracking ile elde edilen veriler takip edilmeyeceğinden dolayı yinelenen verilerin ayrı instancelarda olmasına sebebiyet veriyoruz. Çünkü ChangeTracker mekanizması takip ettiği nesneden bellekte varsa eğer aynı nesneden birdaha oluşturma gereği duymaksızın o nesneye ayrı noktalardaki ihtiyacı aynı instance üzerinden gidermektedir.

//Yani takip mekanizması şunu diyor senin şu nesneye mi ihtiyacın var bu nesne önceden bellekte oluşturulmuştu o zaman hep bu bellekteki ihtiyaç noktalarında bu nesneyi kullanalım.

//Böyle bir durumda hem takip mekanizmasının maliyetini ortadan kaldırmak hemide yinelenen dataları tek bir instance üzerinde karşılamak için AsNoTrackingWithIdentityResolation fonksiyonunu kullanabiliriz.

//var kitaplar =await context.Kitaplar.Include(k => k.Yazarlar).AsNoTrackingWithIdentityResolution().ToListAsync();

//AsNoTrackingWithIdentityResolution fonksiyonu AsNoTracking fonksiyonuna nazaran görece yavaştır/maliyetlidir. lakin ChangeTracker'a nazaran daha performanslı ve az maliyetlidir.
#endregion

#region AsTracking
//ChangeTracker'ın default olarak kullandığı metot budur. Yani oluşturduğun sorgunun takip edilmesini istiyorsan AsTracking metodunu kullanabilirsin.

//Context üzerinden gelen dataların ChangeTracker tarafından takip edilmesini iradeli bir şekilde ifade etmemizi sağlayan fonksiyondur.

//Eğer ki biz Change Tracker mekanizmasını default olarak pasife çekersem bu seferde ihtiyaç noktalarında Change Tracker mekanizmasını devreye sokmamız gerekecek işte bu yüzden AsTracking fonksiyonunu kullanmalıyız.

//Bir sonraki incelyeceğimiz UseQueryTrackingBehavior metodunun davranışı gereği uygulama seviyesinde Change Tracker'ın default olarak devrede olup olmamasını ayarlıyo olacağız. Eğer ki default olarak pasif hale getirilirse böyle durumda takip mekanizmasının ihtiyaç olduğu sorgularda AsTracking fonksiyonunu kullanabilir ve böylece takip mekanizmasını iradeli bir şekilde devreye sokmuş oluruz.

//var kitaplar = await context.Kitaplar.AsTracking().ToListAsync();
#endregion

#region UseQueryTrackingBehavior
//EF Core seviyesinde/uygulama seviyesinde ilgili context'ten gelen verilerin üzerinde Change Tracker mekanizmasının davranışını temel seviyede belirlememizi sağlayan fonksiyondur. Yani konfigürasyon fonksiyonudur.
#endregion

public class ETicaretContext : DbContext
{
    public DbSet<Kullanici> Kullanicilar { get; set; }
    public DbSet<Rol> Roller { get; set; }
    public DbSet<Kitap> Kitaplar { get; set; }
    public DbSet<Yazar> Yazarlar { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=ETicaretDB;Trusted_Connection=True;");
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }
}
public class Kullanici
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public ICollection<Rol> Roller { get; set; }
}
public class Rol
{
    public int Id { get; set; }
    public string RolAdi { get; set; }
    public ICollection<Kullanici> Kullanicilar { get; set; }
}
public class Kitap
{
    public Kitap() => Console.WriteLine("Kitap nesnesi oluşturuldu.");
    public int Id { get; set; }
    public string KitapAdi { get; set; }
    public int SayfaSayisi { get; set; }

    public ICollection<Yazar> Yazarlar { get; set; }
}
public class Yazar
{
    public Yazar() => Console.WriteLine("Yazar nesnesi oluşturuldu.");
    public int Id { get; set; }
    public string YazarAdi { get; set; }

    public ICollection<Kitap> Kitaplar { get; set; }
}
