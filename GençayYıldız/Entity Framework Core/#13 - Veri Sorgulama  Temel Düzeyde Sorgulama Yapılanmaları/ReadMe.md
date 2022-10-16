# En Temel Basit Bir Sorgulama Nasıl Yapılır?
- EF Core'da sorgulama yaparken en temel haliyle context üzerinden hangi tabloyu sorgulayacaksak o tablonun DbSet'ini çağırıyoruz artık burada bunu execute etmek/sonucu elde etmek için bir fonksiyon çağırırız
## Method Syntax(LINQ Functions)
- ben sorgulama yaparken metotları kullanarak sorgu yapıyorsam buna Method Syntax denir.
```C#
var urunler = context.Urunler;
await urunler.ToListAsync();
```

## Query Syntax (LINQ Queries)
```C#
var urunler2 = await (from urun in context.Urunler //Urunler tablosunun içerisindeki her bir ürünü urun değişkenine verdik
               select urun).ToListAsync();
```
# Sorguyu Execute Etmek İçin Ne Yapmamız Gerekmektedir?
# ToListAsync
- Sorguyu execute etmek için kullandığımız bir fonksiyon
- Sorguyu veritabanına sunucusuna gönderebilmek için bu fonksiyonu kullanabiliriz
## Method Syntax
```C#
var urunler = await context.Urunler.ToListAsync();
```

## Query Syntax
```C#
var urunler2 = await(from urun in context.Urunler
select urun).ToListAsync();
```

# Foreach
```C#
- foreach (Urun urun in urunler)//IQueryable türünden(execute edilmemiş sorgu) yapılanmayı foreach ile çağırdığında ben bunun artık execute edilmesi gerektiğini anlıyorum ve execute ediyorum ve IEnumerable oluyor ve IEnumerable olduktan sonra sana ilgili verileri getiriyorum.
{
   Console.WriteLine(urun.UrunAdi);
}
```

# Deferred Execution(Ertelenmiş Çalışma)
- IQueryable çalışmalarında ilgili kod yazıldığı noktada tetiklenmez/çalıştırılmaz yani ilgili kod yazıldığı noktada sorguyu generate etmez! Çalıştırıldığı/execute edildiği noktada tetiklenir! İşte nu duruma da Deferred Execution(Ertelenmiş Çalışma) denir!


```C#
int urunId = 5;
string urunAdi = "2";
var urunler = from urun in context.Urunler
              where urun.Id > urunId && urun.UrunAdi.Contains(urunAdi)
              select urun; //şu durumda urunId 5 ve urunAdi değeri 2'dir ama sorgu şu anda oluşturulmamış ve tetiklenmemiştir.

urunId = 200;
urunAdi = "4";
//Burada değişken değerleri değiştirildi ve yazdığımız sorgu metninde de aynı değerler değişmiş bulunmaktadır.
foreach (Urun urun in urunler)//Burada sorgu oluşturulurken ilgili değişkenlerin son değerleri neyse ona göre o değerler eşliğinde ilgili sorguyu oluşturmaktadır.
{
    Console.WriteLine(urun.UrunAdi);
}


await urunler.ToListAsync();
```
- Bu sorgu oluşturulurken ilk başta where şartında urunId = 5 ve UrunAdi Like '%2%' değerini alacak sorguları getirecek şekilde planlanmıştır. Amma velakin herhangi bir sorgu tetiklenmemiş/oluşturulmamış olduğu için bu değişken değerleri sorgu execute/tetiklenene kadar değişse bile tetiklendiği andaki değerleri geçerli olacaktır.


# IQueryable ve IEnumerable Nedir? Basit Olarak!

```C#
var urunler = (from urun in context.Urunler
             select urun).ToListAsync();
```
# IQueryable
- Sorguya karşılık gelir.
- Ef core üzerinden yapılmış olan sorgunun execute edilmemiş halini ifade eder.
- Sorguyu oluşturuyorsun ama execute etmediğinden dolayı elinde veri yok.
- Davranış olarak sorgu oluşturma noktasında oluruz.
- Yapısal olarak koleksiyonel bir interface'tir.

# IEnumerable
- Sorgunun çalıştırııp/execute edilip verilerin in memory'e yüklenmiş halini ifade eder.
- Sorguyu oluşturmuşsun bu sorguyu execute etmişsin execute neticesinde uygun veriler hangileriyse bunlar yazılım kısmına/inmemory'e gelmiş orada entity instance'ı olarak tutulmuş halini ifade eder.
- veriler artık bellektedir.
- Bellekteki verileri,bellekteki koleksiyonel yapılanmaları temsil eder.

```C#
public class ETicaretContext : DbContext
{
    public DbSet<Urun> Urunler { get; set; }
    public DbSet<Parca> Parcalar { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=ETicaretDB;Trusted_Connection=true;");
    }
}
public class Parca
{
    public int Id { get; set; }
    public string ParcaAdi { get; set; }
}
public class Urun
{
    public int Id { get; set; }
    public string UrunAdi { get; set; }
    public float Fiyat { get; set; }

    public ICollection<Parca> Parcalar { get; set; }
}
```