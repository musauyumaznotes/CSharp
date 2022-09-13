using System;

namespace R
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nesneler Arası İlişkiler
            //Nesneler doğrudan ya da dolaylı olarak farklı türlerde birbirleriyle bağ kurabilmektedirler.
            //Bu ilişkiler kalıtım,referans yahut soyutlama gibi durumalrın getirisi olan mantıksal izahatlerdir.
            #endregion
            #region is - a İlişkisi Nedir?
            //is - a ilişkisi tamamiyle kalıtımla alakalıdır.C# programlama dilinde iki sınıf arasında : operatörü ile gerçekleştirilen kalıtım neticesinde ortaya bir is - a ilişkisi çıkmaktadır.
            //A is a B => Bu durumda A sınıfı B sınıfından kalıtım almıştır.
            #endregion
            #region has - a İlişkisi Nedir?
            //Bir sınıfın başka bir sınıfın nesnesine dair sahiplik ifadesinde bulunan ilişkidir.Bir yandan kompozisyon/composition ilişkisi de denmektedir.
            //Bir sınıf farklı bir sınıfın referansını kendi içinde barındırıyorsa biz buna has a ilişkisi diyoruz
            #endregion
            #region can - do İlişkisi Nedir?
            //Interface yapılanamasının getirisi olan bir ilişki türüdür.
            //Interface bir sınıfın imzasıdır.Yani bir sınıfın içerisinde olacak olan tüm member'ların şablonunu/arayüznü oluşturduğumuz bir kontrattır.Herhangi bir interface'i uygulayan class o interface içerisinde tanımlanmış member imzalarını kendisinde oluşturmak zorundadır.Aksi taktirde compiler hata verecektir.
            //Interfaceler içlerindeki memberların imzalarını class'ta uygulattırdığından dolayı o interfaceler ile ilgili nesnelerin yapabilecekleri kabileyetleri göstermektedir.
            //can - do ilişkisi bir nesnenin davranışlarını/kabiliyetlerini belirtmektir. Bu davranış/kabiliyetlerin interface içerisinde tanımlanmaktadır.
            #endregion
            #region Association Nedir?
            //Sınıflar arasındaki bağlantığının zayıf biçimine verilen addır.
            //Bu bağlantı oldukça gevşektir. Yani sınıflar lendi aralarında ilişkilidir lakin birbirinden bağımsızdırlar.
            //Parça - bütün ilişkisi oktur
            //Örneğin bir otobüsteki yolcular ile otobüs arasındaki ilişki association'dır Nihayetinde hepsi aynı yöne gitmektedir. Lakin bir yolcu indiğinde bu durum otobüsün ve diğer yolcuların durumunu değiştirmez!
            //Bir araya gelmiş birçok nesne var serseri bir düzen oluşturmuşlar ama aradan elenenler olduğu zaman bu bütünde herahngi bir aksaklık/eksiklik ortaya çıkmıyor. İşte bu tarz durumlara biz association diyoruz.
            #endregion
            #region Aggregation ve Composition Nedir?
            //Nesneleri birleştirip daha büyük bir nesne yapmaya verilen isimlerdir.
            //Her ikiside birleştirilmiş nesnelerden bütünsel nesneler yapma durumlarını ifade eder
            //Her ikisinde de parça - bütün ilişkisi söz konusudur.
            //Her ikisinde de sahiplik(has a) ilişkisi vardır.
            //
            #endregion
        }
    }
}
