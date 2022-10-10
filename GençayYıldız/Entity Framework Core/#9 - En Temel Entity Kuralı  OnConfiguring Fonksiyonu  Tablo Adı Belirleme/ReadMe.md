# OnConfiguring İle Konfigürasyon Ayarlarını Gerçekleştirmek
- Context nesnesi bizim veritabanımıza karşılık gelen class. Şimdi bu class hangi sunucudaki veritabanına bağlaancaksa hangi kullanıcı adı şifresiyle bağlanacaksa ya da lazy loading gibi bir operasyon gerçekleştirecek mi gerçekleştirmeyecek mi bununla ilgili temel konfigürasyon yapılanması olacaksa ya da Context ile ilgili temel yapılandırmalar olacaksa bunların hepsini üstlenen bir fonksiyondur.
- EF Core tool'unu yapılandırmak için kullandığımız bir metottur.
- Context nesnesinde override edilerek kullanılmaktadır.

```C#
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    #region Yapılabilen Çalışmalar
    //Provider 
    //ConnectionString
    //Lazy Loading vb.
    #endregion
    optionsBuilder.UseSqlServer("Server = localhost; Database =ETicaretDb; Trusted_Connection = true;");
}
```

# Basit Düzeyde Entity Tanımlama Kuralları
- EF Core : Bir tablo olacaksa her tablonun kesinlikle bir primary key kolonu olmalıdır diyor. 
- EF Core, her tablonun default olarak bir primary key kolonu olması gerektiğini kabul eder.
- Haliyle, bu kolonu temsil eden bir property tanımlamadığımız taktirde hata verecektir.
- Temel düzeyde yazmış olduğumuz property'inin primary key olabilmesi için bir gelenek vardır.Adı Id,ID,EntityId,EntityID olmalıdır ki EF hususi olarak primary key olarak belirleyecektir.

```C#
public class Urun
{
    //public int ID { get; set; }
    //public int Id { get; set; }
    //public int UrunId { get; set; }
    public int UrunID { get; set; }
}
```
- Entity dediğimiz yapılanma tekil isimli olur. Fıtrat olarak entity yeryüzünde bir olguyu modelleyen sınıftı. Haliyle modellemeyi yapan sınıfın kendisi tekil isimlendirmeyle tarif edilir. Bu sınıftan türetilen instance'lar o olgunun fiziksel haline karşılık gelir. 

# Tablo Adını Belirleme
- DbSet Property'sinde property'e ne isim verirsek Tablo adıda o isim olmaktadır.
```C#
public DbSet<Urun> Urunler { get; set; }
```

# Örnek Kod
```C#
public class ETicaretContext : DbContext
{
    public DbSet<Urun> Urunler { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        #region Yapılabilen Çalışmalar
        //Provider 
        //ConnectionString
        //Lazy Loading vb.
        #endregion
        optionsBuilder.UseSqlServer("Server = localhost; Database = ETicaretDb; Trusted_Connection = true;");
    }
}

public class Urun
{
    //public int ID { get; set; }
    //public int Id { get; set; }
    //public int UrunId { get; set; }
    public int UrunID { get; set; }
}
```