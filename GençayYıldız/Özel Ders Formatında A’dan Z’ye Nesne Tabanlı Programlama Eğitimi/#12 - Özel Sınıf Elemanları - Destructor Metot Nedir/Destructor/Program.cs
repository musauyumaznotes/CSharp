using System;

namespace Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Destructor/Finalizer Functions 
            //Bir class'tan üretilmiş olan nesne imha edilirken otomatik çağrılan/tetiklenen  metottur.
            //Nesneyle işimiz bitti.nesneyle ilgili bu değerle ilgili işlem yapmama gerek yok dolayısıyla böyle bir durumda nesneyi yok edeceğiz.çünkü biz belleğimizde bize lazım olmayan bir değerle işimiz olmayacak.
            //Nesne imha edilirken/yok edilirken son kez nesne adına selametle dememizi sağlayacak olan bir fonksiyondan bahsediyoruz
            //Nesnede ki garanti bri şekilde en son tetiklenecek olan fonksiyon destructor fonksiyonudur.
            //C#'ta destructor sadece class yapılanmasında kullnılabilir ve bir class sade ve sadece tek bir destructor içermelidir.
            //Destructor parametre alamaz
            #endregion
            #region Destructor Davranış Modeli
            //Bir nesneyi biz edebiyen kullanmayız nesne ile işimiz bittiğinde yani nesneyi imha ederken son kez hadi hoşçakalın dediği fonksiyona biz destructor diyoruz
            //Destructor yıkıcı metot nesne imha edilirken/yıkılırken/yok edilirken/silinirken devreye girecektir. 
            #endregion
            #region Bir Nesne Hangi Şartlarda Kim Tarafından İmha Edilir?
            //Bir nesnenin imha edilebilmesi için;
            //1. İlgili nesne herhangi bir referans tarafından işaretlenmemelidir
            //2. Yahut nesnenin oluşturlduğu ve kullanıldığı scope sona ermiş olmalıdır.
            //3. Yani anlaşılan ilgili nesneye bir daha erişilemez hale gelinmelidir.
            #endregion
            #region Garbage Collector
            //Ram'de bir daha kullanılmamak üzere/erişilmemek üzere duran nesneler/referanssız nesneler  ya da ilgili alanda scope'u bitmiş görevi bitmiş alanlarda tanımlanmış nesneler dışarıdan bir daha erişilmeyen nesneler bunlar çöp diye nitelendirilir.
            //Uygulamada lüzumsuz olan nesneleri toplamak için Garbage Collector isimli bir mekanizma devreye girer.
            //Esasında Garbage Collector C#'ta bellek optimizasyonunu üstlenen bir yapılanmadır. Yani .Net'te bellek optimizasyonu/bellek yönetimi biz developerlardan alınıp Garbage Collector'a verilmiştir. ve mimari/işletim sistemi bunu otomatik olarak yürütür.
            //Bu mekanizma kendi kafasına göre çalışır.
            //C#'ta Garbage Collector'ın ne zaman iş göreceği tahmin edilemez.Kafasına göre takılır:)
            //Dolayısıyla biz geliştiricilerin bu mekanizmaya müdahale etmesi pek önemli değildir.
            //Bu mekanizmaya biz developerların bu mekanizmaya çokta müdahale etmesi tavsiye edilmez
            //Nihayetine bizler buna müdahale ettikçe/işine karıştıkça orada büyük bir maliyete sebeb olabilmekteyiz. Garrbage Collector dediğimiz mekanizma bellek optimizasyonunu kendi planına göre yürüttüğünden dolayı müdahale edebiliyoruz ama bu müdahale çok fazla önerilmiyor.
            #endregion
            #region Destructor Tanımlama Kuralları
            //nesne tam imha edilirken nesne son kez hadi eyvallah diyeceği destructor fonksiyonunu devreye sokuyor onu tetikliyor.

            #region 1. Örnek
            X();
            GC.Collect();//Garbage Collector devreye sokulmuş oldu.
            Console.ReadLine();
            #endregion
            #region 2. Örnek
            int sayi = 100;
            while (sayi >= 1)
            {
                new MyClass2(sayi--);
            }
            Console.WriteLine("*********************");
            GC.Collect();

            Console.ReadLine();






            
            #endregion
            #endregion
        }
        static void X()
        {
            MyClass m = new MyClass();
        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Nesne üretilmiştir");
        }
        ~MyClass()//İmhadan bir tık öncesi son nefes
        {
            Console.WriteLine("Nesne imha ediliyor...");
        }
    }
    class MyClass2
    {
        int no;
        public MyClass2(int no)
        {
            this.no = no;
            Console.WriteLine($"{no}. nesne oluşturulmuştur.");
        }
        ~MyClass2()
        {
            Console.WriteLine($"{no}. nesne imha ediliyor");
        }
    }
}
