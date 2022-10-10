# Veri Nasıl Eklenir?
- Bir veri üstünde işlem yapmak istiyorsak eğer Context nesnesinden bir adet instance oluşturmalıyız.
- Context nesnemiz veritabanına karşılık gelir,Entity'miz veritabanındaki tablonun modeline karşılık gelir,ve bu Entity'lerden üretilen instance'lar ise o tablonun satırlarına karşılık gelir yani verileri tutan fiziksel/atomik yapılardır.

```C#
ETicaretContext context = new();
Urun urun = new()
{
    UrunAdi = "A Ürünü",
    Fiyat = 1000
};

await context.AddAsync(urun);//Tip Güvensiz
await context.Urunler.AddAsync(urun);//Tip Güvenli

await context.SaveChangesAsync();
```
- Burada ilk başta context sınıfından bir instance oluşturulur. Daha sonrasında ise Urun sınıfından oluşturduğumuz instance'ın içini doldurup (gerekli property/değişken değerleri) AddAsync(urun) fonksiyonu çağrılır daha sonrasında ise bu değişiklikleri kaydetmek ve sorgusunu oluşturmak için SaveChangesAsync() metodu çağrılır ve gerekli işlemler tamamlanmış yani nesne veritabanına eklenmiş olur.


# context.AddAsync Fonksiyonu
- Tip Güvensiz yani object olarak veri eklememizi sağlar.
```C#
await context.AddAsync(urun);
```
 
# context.DbSet.AddAsync Fonksiyonu
- Tip Güvenli veri eklememizi sağlar.
```C#
await context.Urunler.AddAsync(urun);
```

# context.SaveChangesAsync()
- SaveChanges üç aksiyonu gerçekleştiriken(insert,update,delete) veritabanının anlayacağı sorguları oluşturup bir transaction eşliğinde bunları veritabanına gönderip execute etmemizi sağlayan bir fonksiyondur. Eğer ki oluşturulan sorgulardan herhangi biri başarısız olursa tüm işlemleri geri alır.(rollback)
```C#
await context.SaveChangesAsync();
```

# Entity Id Property'si
- Eğer ki bir Id column'u oluşturuyorsanız EntityFrameworkCore'da ve bu kolonun türü int ise ya da sayısal bir kolonsa bunu otomatik identity specification özelliğini aktif hale getirir ve default olarak 1'den başlayarak 1'er 1'er arttırır bir özellikte/nitelikte generate ediyor.
```C#
public int Id { get; set; }
```

# EF Core Açısından Bir Verinin Eklenmesi Gerektiği Nasıl Anlaşılıyor?
```C#
ETicaretContext context = new();
Urun urun = new()
{
    UrunAdi = "B ürünü",
    Fiyat = 2000
};

Console.WriteLine(context.Entry(urun).State);

await context.AddAsync(urun);//Bu durumda state belirlendi(added)
Console.WriteLine(context.Entry(urun).State);

await context.SaveChangesAsync();
Console.WriteLine(context.Entry(urun).State);
```

- EntityState elimizdeki entity'e dair yapmış olduğumuz davranışın neticesinde onun durumunu bizlere söyler yani eklenecek mi silinecek mi ya da güncellenecek mi buna göre işlem yapılır.
- Bununla ilgili yapmış olduğumuz davranış neyse ilgili EntityFrameworkCore yapılanmasında entity'e/veriye dair yapmış olduğumuz davranış neyse ona göre bir State belirleniyor ve bu State'in üzerinden EntityFrameworkCore veriye dair nasıl bir davranış sergileyeceğini modellemesini ortaya koyuyor. ona göre SaveChanges() Insert,Update,Delete sorgularını oluşturup veritabanına execute etmesi için gönderiyor.

# Birden Fazla Veri Eklerken Nelere Dikkat Edilmelidir?
- Veritabanı işlemlerinde transaction bir maliyettir.
- Dolayısıyla biz yapacağımız işlemleri tek bir transaction içinde yapma derdindeyiz. Veritabanıyla ilgili maliyeti arttırmamak yada maliyetini azaltmak için
- Her bir işlemde ayrı ayrı SaveChanges() kullanmak yerine en nihayetinde gidip SaveChanges talimatını vermeniz yeterli olacaktır.
- Bu şekilde oluşturulan talimat neticesinde Kardeşim burada EF Core ile ilgili yapılan davranışlar/State'ler her neyse sen öncelikle bunların hepsini Tool aracılığıyla bir analiz et ardından SaveChanges'ı çağırdığında her bir işleme özel sorguyu tek bir transaction'da oluşturup veritabanına gönder.
```C#
ETicaretContext context = new();
Urun urun1 = new()
{
   UrunAdi = "C ürünü",
   Fiyat = 2000
};
Urun urun2 = new()
{
   UrunAdi = "D ürünü",
   Fiyat = 2000
};
Urun urun3 = new()
{
   UrunAdi = "E ürünü",
   Fiyat = 2000
};
await context.AddAsync(urun1);
await context.SaveChangesAsync();

await context.AddAsync(urun2);
await context.SaveChangesAsync();

await context.AddAsync(urun3);
await context.SaveChangesAsync();
```

# SaveChanges'ı Verimli Kullanalım!
- SaveChanges fonksiyonu her tetiklendiğinde bir transaction oluşturacağından dolayı EF Core ile yapılan her bir işleme özel kullanmaktan kaçınmalıyız! Çünkü her işleme özel transaction veritabanı açısından ekstradan maliyet demektir. O yüzden mümkün mertebe tüm işlemlerimizi tek bir transaction eşliğinde veritabanına gönderebilmek için SaveChanges'ı aşağıdaki gibi tek seferde kullanmak hem maliyet hem de yönetilebilirlik açısından katkıda bulunmuş olacaktır.
```C#
ETicaretContext context = new();
Urun urun1 = new()
{
   UrunAdi = "C ürünü",
   Fiyat = 2000
};
Urun urun2 = new()
{
   UrunAdi = "D ürünü",
   Fiyat = 2000
};
Urun urun3 = new()
{
   UrunAdi = "E ürünü",
   Fiyat = 2000
};
await context.AddAsync(urun1);

await context.AddAsync(urun2);

await context.AddAsync(urun3);
await context.SaveChangesAsync();
```

# AddRange
- Bu fonksiyon ile birlikte veritabanına veri eklerken aynı anda/aynı transaction'da birden fazla veri ekleyebiliriz.
```C#
ETicaretContext context = new();
Urun urun1 = new()
{
    UrunAdi = "C ürünü",
    Fiyat = 2000
};
Urun urun2 = new()
{
    UrunAdi = "D ürünü",
    Fiyat = 2000
};
Urun urun3 = new()
{
    UrunAdi = "E ürünü",
    Fiyat = 2000
};
await context.AddRangeAsync(urun1,urun2,urun3);
await context.SaveChangesAsync();
```

# Eklenen Verinin Generate Edilen Id'sini Elde Etme (@@IDENTITY)
- (@@IDENTITY) => En son işlem yapılan üretilen/generate edilen en sonuncu primary key/Id değerini döndürür

```C#
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

await context.SaveChangesAsync();

Console.WriteLine($"{urun1.Id},{urun2.Id},{urun3.Id}");
```
- AddAsync fonksiyonuna tabi tutulupta arka planda buna ait bir veri üretildiğinde SaveChanges Metodundan sonra bunun Id column'a generate edilen veri otomatik set edilecektir.Direkt oluşturduğumuz instance üzerinden bu veriye/Id Column'a erişim sağlayabiliriz.
