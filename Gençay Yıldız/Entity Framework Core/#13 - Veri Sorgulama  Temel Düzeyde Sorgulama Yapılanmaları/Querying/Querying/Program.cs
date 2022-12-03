using Microsoft.EntityFrameworkCore;

ETicaretContext context = new();

#region En Temel Basit Bir Sorgulama Nasıl Yapılır?
//EF Core'da sorgulama yaparken en temel haliyle context üzerinden hangi tabloyu sorgulayacaksak o tablonun DbSet'ini çağırıyoruz artık burada bunu execute etmek/sonucu elde etmek için bir fonksiyon çağırırız
#region Method Syntax(LINQ Functions)
//ben sorgulama yaparken metotları kullanarak sorgu yapıyorsam buna Method Syntax denir.
//var urunler = context.Urunler;
//await urunler.ToListAsync();
#endregion
#region Query Syntax (LINQ Queries)
//var urunler2 = await (from urun in context.Urunler //Urunler tablosunun içerisindeki her bir ürünü urun değişkenine verdik
//               select urun).ToListAsync();
#endregion
#endregion

#region Sorguyu Execute Etmek İçin Ne Yapmamız Gerekmektedir?
#region ToListAsync
//Sorguyu execute etmek için kullandığımız bir fonksiyon
//Sorguyu veritabanına sunucusuna gönderebilmek için bu fonksiyonu kullanabiliriz
#region Method Syntax
//var urunler = await context.Urunler.ToListAsync();
#endregion
#region Query Syntax
//var urunler2 = await(from urun in context.Urunler
//select urun).ToListAsync();
#endregion
#endregion

int urunId = 5;
string urunAdi = "2";
var urunler = from urun in context.Urunler
              where urun.Id > urunId && urun.UrunAdi.Contains(urunAdi)
              select urun;

urunId = 200;
urunAdi = "4";

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.UrunAdi);
}

await urunler.ToListAsync();
#region Foreach

//foreach (Urun urun in urunler)//IQueryable türünden(execute edilmemiş sorgu) yapılanmayı foreach ile çağırdığında ben bunun artık execute edilmesi gerektiğini anlıyorum ve execute ediyorum ve IEnumerable oluyor ve IEnumerable olduktan sonra sana ilgili verileri getiriyorum.
//{
//    Console.WriteLine(urun.UrunAdi);
//}

#region Deferred Execution(Ertelenmiş Çalışma)
//IQueryable çalışmalarında ilgili kod yazıldığı noktada tetiklenmez/çalıştırılmaz yani ilgili kod yazıldığı noktada sorguyu generate etmez! Çalıştırıldığı/execute edildiği noktada tetiklenir! İşte nu duruma da Deferred Execution(Ertelenmiş Çalışma) denir!
#endregion
#endregion
#endregion

#region IQueryable ve IEnumerable Nedir? Basit Olarak!

//var urunler = (from urun in context.Urunler
//              select urun).ToListAsync();
#region IQueryable
//Sorguya karşılık gelir.
//Ef core üzerinden yapılmış olan sorgunun execute edilmemiş halini ifade eder.
//Sorguyu oluşturuyorsun ama execute etmediğinden dolayı elinde veri yok.
//Davranış olarak sorgu oluşturma noktasında oluruz.
//Yapısal olarak koleksiyonel bir interface'tir.
#endregion
#region IEnumerable
//Sorgunun çalıştırııp/execute edilip verilerin in memory'e yüklenmiş halini ifade eder.
//Sorguyu oluşturmuşsun bu sorguyu execute etmişsin execute neticesinde uygun veriler hangileriyse bunlar yazılım kısmına/inmemory'e gelmiş orada entity instance'ı olarak tutulmuş halini ifade eder.
//veriler artık bellektedir.
//Bellekteki verileri,bellekteki koleksiyonel yapılanmaları temsil eder.
#endregion
#endregion



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