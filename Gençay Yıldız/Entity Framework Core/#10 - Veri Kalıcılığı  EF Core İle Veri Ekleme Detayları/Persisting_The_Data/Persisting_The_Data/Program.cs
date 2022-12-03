

using Microsoft.EntityFrameworkCore;

#region Veri Nasıl Eklenir
//Bir veri üstünde işlem yapmak istiyorsak eğer Context nesnesinden bir adet instance oluşturmalıyız.
//Context nesnemiz veritabanına karşılık gelir,Entity'miz veritabanındaki tablonun modeline karşılık gelir,ve bu Entity'lerden üretilen instance'lar ise o tablonun satırlarına karşılık gelir yani verileri tutan fiziksel/atomik yapılardır.

//ETicaretContext context = new();
//Urun urun = new()
//{
//    UrunAdi = "A Ürünü",
//    Fiyat = 1000
//};


#region context.AddAsync Fonksiyonu
//Tip Güvensiz yani object olarak veri eklememizi sağlar.
//await context.AddAsync(urun);
#endregion
#region context.DbSet.AddAsync Fonksiyonu
//Tip Güvenli veri eklememizi sağlar.
//await context.Urunler.AddAsync(urun);
#endregion

//await context.SaveChangesAsync();//SaveChanges üç aksiyonu gerçekleştiriken(insert,update,delete) veritabanının anlayacağı sorguları oluşturup bir transaction eşliğinde bunları veritabanına gönderip execute etmemizi sağlayan bir fonksiyondur. Eğer ki oluşturulan sorgulardan herhangi biri başarısız olursa tüm işlemleri geri alır.
#endregion
#region SaveChanges Nedir?
//SaveChanges üç aksiyonu gerçekleştiriken(insert,update,delete) veritabanının anlayacağı sorguları oluşturup bir transaction eşliğinde bunları veritabanına gönderip execute etmemizi sağlayan bir fonksiyondur. Eğer ki oluşturulan sorgulardan herhangi biri başarısız olursa tüm işlemleri geri alır.(rollback)
#endregion
#region EF Core Açısından Bir Verinin Eklenmesi Gerektiği Nasıl Anlaşılıyor?

//ETicaretContext context = new();
//Urun urun = new()
//{
//    UrunAdi = "B ürünü",
//    Fiyat = 2000
//};

//Console.WriteLine(context.Entry(urun).State);

//await context.AddAsync(urun);
//Console.WriteLine(context.Entry(urun).State);

//await context.SaveChangesAsync();
//Console.WriteLine(context.Entry(urun).State);

//EntityState elimizdeki entity'e dair yapmış olduğumuz davranışın neticesinde onun durumunu bizlere söyler yani eklenecek mi silinecek mi ya da güncellenecek mi buna göre işlem yapılır.
//Bununla ilgili yapmış olduğumuz davranış neyse ilgili EntityFrameworkCore yapılanmasında entity'e/veriye dair yapmış olduğumuz davranış neyse ona göre bir State belirleniyor ve bu State'in üzerinden EntityFrameworkCore veriye dair nasıl bir davranış sergileyeceğini modellemesini ortaya koyuyor. ona göre SaveChanges() Insert,Update,Delete sorgularını oluşturup veritabanına execute etmesi için gönderiyor.
#endregion

#region Birden Fazla Veri Eklerken Nelere Dikkat Edilmelidir?
//Veritabanı işlemlerinde transaction bir maliyettir.
//Dolayısıyla biz yapacağımız işlemleri tek bir transaction içinde yapma derdindeyiz. Veritabanıyla ilgili maliyeti arttırmamak yada maliyetini azaltmak için
//Her bir işlemde ayrı ayrı SaveChanges() kullanmak yerine en nihayetinde gidip SaveChanges talimatını vermeniz yeterli olacaktır.
//Bu şekilde oluşturulan talimat neticesinde Kardeşim burada EF Core ile ilgili yapılan davranışlar/State'ler her neyse sen öncelikle bunların hepsini Tool aracılığıyla bir analiz et ardından SaveChanges'ı çağırdığında her bir işleme özel sorguyu tek bir transaction'da oluşturup veritabanına gönder.
//ETicaretContext context = new();
//Urun urun1 = new()
//{
//    UrunAdi = "C ürünü",
//    Fiyat = 2000
//};
//Urun urun2 = new()
//{
//    UrunAdi = "D ürünü",
//    Fiyat = 2000
//};
//Urun urun3 = new()
//{
//    UrunAdi = "E ürünü",
//    Fiyat = 2000
//};
//await context.AddAsync(urun1);
//await context.SaveChangesAsync();

//await context.AddAsync(urun2);
//await context.SaveChangesAsync();

//await context.AddAsync(urun3);
//await context.SaveChangesAsync();

#region SaveChanges'ı Verimli Kullanalım!
//SaveChanges fonksiyonu her tetiklendiğinde bir transaction oluşturacağından dolayı EF Core ile yapılan her bir işleme özel kullanmaktan kaçınmalıyız! Çünkü her işleme özel transaction veritabanı açısından ekstradan maliyet demektir. O yüzden mümkün mertebe tüm işlemlerimizi tek bir transaction eşliğinde veritabanına gönderebilmek için SaveChanges'ı aşağıdaki gibi tek seferde kullanmak hem maliyet hem de yönetilebilirlik açısından katkıda bulunmuş olacaktır.
//ETicaretContext context = new();
//Urun urun1 = new()
//{
//    UrunAdi = "C ürünü",
//    Fiyat = 2000
//};
//Urun urun2 = new()
//{
//    UrunAdi = "D ürünü",
//    Fiyat = 2000
//};
//Urun urun3 = new()
//{
//    UrunAdi = "E ürünü",
//    Fiyat = 2000
//};
//await context.AddAsync(urun1);

//await context.AddAsync(urun2);

//await context.AddAsync(urun3);
//await context.SaveChangesAsync();
#endregion
#region AddRange
//Bu fonksiyon ile birlikte veritabanına veri eklerken aynı anda/aynı transaction'da birden fazla veri ekleyebiliriz.
//ETicaretContext context = new();
//Urun urun1 = new()
//{
//    UrunAdi = "C ürünü",
//    Fiyat = 2000
//};
//Urun urun2 = new()
//{
//    UrunAdi = "D ürünü",
//    Fiyat = 2000
//};
//Urun urun3 = new()
//{
//    UrunAdi = "E ürünü",
//    Fiyat = 2000
//};
//await context.AddRangeAsync(urun1,urun2,urun3);
//await context.SaveChangesAsync();
#endregion
#endregion
#region Eklenen Verinin Generate Edilen Id'sini Elde Etme (@@IDENTITY)
//(@@IDENTITY) => En son işlem yapılan üretilen/generate edilen en sonuncu primary key/Id değerini döndürür

ETicaretContext context = new();
Urun urun1 = new()
{
    UrunAdi = "M ürünü",
    Fiyat = 2000
};
Urun urun2 = new()
{
    UrunAdi = "N ürünü",
    Fiyat = 2000
};
Urun urun3 = new()
{
    UrunAdi = "O ürünü",
    Fiyat = 2000
};
await context.AddAsync(urun1);
await context.AddAsync(urun2);
await context.AddAsync(urun3);
// Bu fonksiyona tabi tutulupta arka planda buna ait bir veri üretildiğinde 
await context.SaveChangesAsync();
//SaveChanges Metodundan sonra bunun Id column'a generate edilen veri otomatik set edilecektir.Direkt oluşturduğumuz instance üzerinden bu veriye erişim sağlayabiliriz.
Console.WriteLine($"{urun1.Id},{urun2.Id},{urun3.Id}");
#endregion
public class ETicaretContext : DbContext
{
    public DbSet<Urun> Urunler { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server =localhost;Database=ETicaretDb;Trusted_Connection=true;");
    }

}

public class Urun
{
    public int Id { get; set; }
    //Eğer ki bir Id column'u oluşturuyorsanız EntityFrameworkCore'da ve bu kolonun türü int ise ya da sayısal bir kolonsa bunu otomatik identity specification özelliğini aktif hale getirir ve default olarak 1'den başlayarak 1'er 1'er arttırır bir özellikte/nitelikte generate ediyor.
    public string UrunAdi { get; set; }
    public float Fiyat { get; set; }
}

