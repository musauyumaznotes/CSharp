# Veri Nasıl Silinir?
- EntityFramework'le ilgili çalışma yapacaksan eğer her şeyden önce bir tane context nesnesine ihtiyacın var.
- Silinecek veriyi context üzerinden veritabanından çekiyoruz. Sonrasında bu context üzerinden gelen veriyi remove fonksiyonuna veriyoruz ve ardından SaveChanges metodunu çağırıyoruz Silme sorgusu oluşturulup execute edilmiş oluyor.
```C#
ETicaretContext context = new();
Urun urun = await context.Urunler.FirstOrDefaultAsync(u=>u.Id == 5);
context.Urunler.Remove(urun);
await context.SaveChangesAsync();
```

# Silme İşleminde ChangeTracker'ın Rolü
- Bu takip mekanizması sayesinde ilgili verinin üzerinde yapılan eyleme göre doğru sorguyu oluşturtabiliriz.
- En nihayetinde context'ten elde etmiş olduğumuz veriyi silerken de ChangeTracker sayesinde bu işlemi gerçekleştirmiş oluyoruz.
- ChangeTracker, context üzerinden gelen verilerin takibinden sorumlu bir mekanizmadır. Bu takip mekanizması sayesinde context üzerinden gelen verilerle ilgili işlemler neticesinde delete yahut update ssorgularının oluşturulacağı anlaşılır!

# Takip Edilmeyen Nesneler Nasıl Silinir?
- Context'ten gelmeyen veriyi sen bir instance ile oluşturuyorsun Bu nesnenin Unique/Primary Key olan değeri hangisiyse onu yazıyorsun yazdıktan sonra Remove metodunu ve ardından sorguların oluşturulması ve oluşturulan sorguların Execute edilmesi için SaveChanges metodunu çağırıyorsun.
```C#
ETicaretContext context = new();
Urun u = new()
{
   Id = 2
};
context.Urunler.Remove(u);//Git u nesnesine bak bu u nesnesi Track ediliyor mu edilmiyorsa Id değerine bak Id değeriyle eşleşen veri varsa onu sil demiş olduk.
await context.SaveChangesAsync();
```

# EntityState İle Silme İşlemi
- İlk başta nesneyi oluşturuyoruz. Sonrasında bu oluşturmuş olduğumuz nesnenin EntityState özelliği EntityState.Deleted'a çekerek silinecek olarak işaretliyoruz sonrasında ise sorguların oluşturulması ve oluşturulan sorguların Execute edilmesi için SaveChanges metodunu çağırıyorsun.
```C#
ETicaretContext context = new();
Urun u = new() { Id = 1 };
context.Entry(u).State = EntityState.Deleted;
await context.SaveChangesAsync();
```

# Birden Fazla Veri Silinirken Nelere Dikkat Edilmelidir?
- SaveChanges her çağırıldığında/tetiklendiğinde bir transaction eşliğinde yapılan işlemleri veritabanına gönderir orada execute eder.
- Yani biz SaveChanges metodunu ne kadar tetiklerse/çağırırsam o kadar transaction oluşturmuş olurum.
#region SaveChanges'ı Verimli Kullanalım
- Dolayısıyla bizler sileceğimiz verilerin hepsini Remove fonksiyonuna tabi tuttuktan sonra yani State'lerini EntityState.Deleted konumuna getirdikten sonra bir kereye mahsus bu işlemlerin tek bir transaction'da işlenebilmesi için sonunda SaveChanges metodunu çağırmalıyız.

# RemoveRange
- Bu fonksiyon ile birden fazla verimiz varsa bunları teker teker remove etmektense ya da bunların Statelerini teker teker EntityState.Deleted olarak değiştirmektense bu verileri bir dizi/koleksiyon olarak alıp silme işlemini yapan fonksiyondur

```C#
ETicaretContext context = new();
List<Urun> urunler = await context.Urunler.Where(u => u.Id >= 7 && u.Id <= 9).ToListAsync();
context.Urunler.RemoveRange(urunler);
await context.SaveChangesAsync();
```
```C#
public class ETicaretContext : DbContext
{
    public DbSet<Urun> Urunler { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=ETicaretDb;Trusted_Connection=true;");
    }
}
public class Urun
{
    public int Id { get; set; }
    public string UrunAdi { get; set; }
    public float Fiyat { get; set; }
}
```
