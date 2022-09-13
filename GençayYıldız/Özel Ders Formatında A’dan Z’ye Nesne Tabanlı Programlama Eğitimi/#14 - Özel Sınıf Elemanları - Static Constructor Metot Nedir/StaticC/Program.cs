using System;

namespace StaticC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static Constructor
            //Bir sınıftan nesne üretilirken constructor'a nazaran ilk tetiklenen metot static constructor'dır. Amaaa...!!!
            //Bir sınıftan nesne ğretilirken ilk tetiklenen fonskiyon Static Constructor'dır.... Amma velakin belirli bir duruma istinaden!!!!
            //Ctor ilgili sınıftan herrr nesne üretilirken tetiklenen fonksiyondur.
            //Static constructor ilgili sınıftan ilk nesne üretilirken bir kereye mahsus tetiklenen metottur.
            //Bu sınıftan ilk defa bir nesne üretiliyorsa ilk tetiklenen fonksiyon static constructor'dır ardından constructor'dır. Yok eğer bu sınıftan ilk değil de n. nesne üretiliyorsa artık static constructor bir daha tetiklenmez çünkü uygulamada o sınıftan bir yerlerde bir zamanlarda ilk olan bir nesne üretilmiştir. O zaman tetiklenmiştir.
            //Static yapılanmalar uygulama bazlı datalarımızı yerleştirdiğimiz alandır.
            //Static diye bişey duyduğunuzda nesneden bağımsızdır.Bir kereye mahsus tetiklenir.Bir değer koyarsın her yerde aynı değer söz konusudur.
            //Static constructor'da geri dönüş değeri ve erişim belirleyicisi bildirilmez!
            //Overloading yapılmaz! Bir sınıfın içerisinde sade ve sadece bir tane tanımlanabilir. Yani parametre almaz!!
            //Static constructor öyle ya da böyle tetiklendiği zaman bir daha tetiklenmez. Bir sınıfta tetiklenme hakkı bir keredir.
            #endregion
            new MyClass();
            new MyClass();

            var database1 = Database.GetInstance;
            var database2 = Database.GetInstance;
            var database3 = Database.GetInstance;

            database1.ConnectionString = "afasgagagawgawg";

           
        }
    }
    class MyClass
    {
        public MyClass()
        {
            //Bu sınıftan nesne üretilirken ilk tetiklenecek olan metottur
            Console.WriteLine("MyClass constructor'ı tetiklenmiştir.");
        }
        static MyClass()
        {
            //Bu sınıftan ilk nesne üretilirken ilk tetiklenecek olan metottur
            //Üretilen ilk nesnenin dışında bir daha tetiklenmez
            Console.WriteLine("MyClass static constructor'ı tetiklenmiştir.");
            //Static constructor'ın tetiklenebilmesi için illa ilk nesne üretimi yapılamsına gerek yoktur. İlgili sınıf içerisinde herhangi bir static yapılanmanında tetiklenmesi static constructor'ın tetiklenmesini sağlayacaktır.
        }
    }
    #region Singleton Design Pattern
    //bir sınıftan uygulama bazında sade ve sadece tek bir nesne oluşturulmasını istiyorsan kullanabileceğin bir design pattern.
    //Design pattern yapılanmalar oop nimetlerinden faydalanarak geliştirdiğimiz stratejiler tekrar eden stratejiler yani dünyada her yerde standart olan stratejiler.
    //Bu uygulamada bu sınıftan sadece bir tane nesne oluşsun iki tane oluşmasın diyipte bu sınıftan sade ve sadece bir tane nesne olacak ne zaman yeni bir nesne ihtiyacın varsa var olanı sana döndürüp onu kullanmanı sağlayacak bir ihtiyacın varsa bu strateji senin bu ihtiyacına çözüm getirebiliyor.
    //Bu dizayn pattern'ı uygularken Static constructor dediğimiz yapılanma  kullanılabiliyor.



    class Database
    {
        Database()
        {

        }
        public string ConnectionString { get; set; }
        static Database database;
        public static Database GetInstance 
        { 
            get 
            { 
                return database; 
            } 
        }
        static Database()
        {
            database = new Database();
        }
    }
    #endregion

}
