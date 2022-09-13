using System;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Özel Fonksiyonlar
            //Bu sınıfın üzerinden bu sınıftan üretilecek nesnenin üzerinde bu nesnenin üretim esnasındaki yapılacak operasyonları tanımlamamızı sağlayacak aynı şekilde üretilen bu nesne ebedi değildir bir gün imha edilir işte bu imha edilme sürecinde son kez yapılacak işlemlere dair tanımlamaları yapmamızı sağlayacak olan özel fonksiyonlarımız vardır.
            //Bu özel memberlar tüm sınıflarda ortak olarak kullanılabilir yapılanmalara sahiptir.
            #endregion
            #region Construtor Nedir?
            //Biz bir nesne oluştururken aslında bir fonksiyon tetikliyoruz.
            //Adı üstünde yapıcı/inşa edici metot Nesnenin yapıcılığını nesne ilk ayağa kaldırılırken o nesneye dair konfigürasyonları yaptığımız metottur. 
            //Nesne üretilirken ilk tetiklenen metottur.
            //Constructor nesne oluşturma sürecinde tetiklenmek zorundadır.
            #endregion
            #region Constructor Davranış Modeli
            //Constructor new ile nesne yaratma talebi geldikten ve ilgili nesneye hafızada yer ayrıldıktan sonra tetiklenir.
            #endregion
            #region Constructor Metot Nasıl Oluşturulur?
            //Özel olsada fıtrat olarak metottur.
            //Metot adı sınıf adıyla aynı olmalıdır!(Özel sınıf elemanlarının dışında hiçbir member sınıf adıyla aynı olamaz!)
            //Geri dönüş değeri olmaz/belirtilmez!
            //Erişim belirleyicisi public olmalıdır!(private olduğu durum ayriyetten incelenecektir.)
            //Bir constructor tanımlamak için O sınıfla aynı isimde ve geri dönüş değeri bildirilmemiş olan bir imza atmanız gerekiyor
            //Constructor her daim tetiklenmesi gereken zoraki bir fonksiyondur.

            new MyClass(5);
            new MyClass(10);
            //new MyClass();
            //new MyClass();
            //new MyClass();

            MyClass m = new(15);
            #endregion
            #region Default Constructor
            //Her sınıfın içerisinde tanımlamasak dahi var olan bir default constructor vardır.
            //Eğer ki bir sınıf oluşturdun ve içine herhangi bir constructor koymadın içinde belki hiç birşey yoktur ama compilr seviyesinde default bir constructor gene tetiklenecektir.
            //Eğer ki bir class'a constructor eklersek default constructor'ı ezmiş oluruz. Ezdiğimizde de bizim yazdığımız Constructor geçerli olacaktır.
            #endregion
            #region Parametreli Constructor
            //Constructorlar parametre alabilen yapılardır.
            #endregion
            #region Constructor Overload
            //Biz bir sınıf içinde birden fazla Constructor metot tanımlayabiliyoruz.
            //Bir sınıfın içinde aynı isimde birden fazla member olamaz Haliyle bir sınıf içerisinde sadece ve sadece bir isimde bir tane metot olabilir.
            //Eğer ki bir sınıfta birden fazla aynı isimde metot oluşturacaksak bu metotlar overloading yani çoklu yüklenme yapılmış olması lazım. Bir isme çoklu yükleme yapılır
            //İmza yapılanması aynı ama bu imzaların nitelikleri değişiyor her metodun ismi aynı olmalı overload olabilmesi için ve parametrelerin sayıları yahut türleri,yahut yerleri değişmiş olmalıdır. 
            #endregion
            #region Constructor'ın Erişim Belirleyicisini private Yaparsak Sorunsalı?
            //Bir sınıfın constructor'ını private yaparsak ilgili sınıfın private yapılan o member'ı dışarıdan nesne üzerinden erişilemeyeceğinden dolayı eğer ki bu member Constructor ise eğer yine erişilemeyecektir ve nesne üretiminde hata alacağız.
            //Eğer constructor metodu tetikleyemiyorsanız ilgili sınıftan nesne üretemezsiniz.
            //Eğer ki sen bir sınıfın constructor metodunu private yaparsan o sınıfın constructor'ına erişilemeyeceği için nesne üretim esnasınıda baltalamış olursun haliyle nesne üretimini engellemiş olursun.
            //new MyClass2();
            #endregion
            #region this Keywordüyle Constructor'lar Arası Geçiş
            //Bir sınıfın içinde this keywordü o sınıfın o anki nesnesini temsil eder
            //this keywordü nasıl ki sınıfın o anki nesnesini temsil ediyor aynı şekilde this keywordu bir sınıfın nesnesinin içerisindeki birden fazla constructorlar arasında geçiş yapabilme sorumluluğunuda üstlenebilmektedir'larında arasında geçiş yapmasını sağlayabilen bir nitelik taşımaktadır. 
            //this keywordü constructorlar arasında atlamayı yani constructor'ın herahngi birisinden farklı constructorları tetikleyebilmemizi sağlayan bu sorumluluğu üstlenen bir keyword'dür
            //new MyClass3();
            //new MyClass3(5);
            new MyClass3(5,10);
            #endregion
            #region Record'lar da Constructor
            //Record'ın özünde/esasında sınıftan bir farkı yok bu yüzden constructor için geçerli tüm kurallar burada da geçerlidir.
            #endregion
        }
    }
    class MyClass
    {
        public MyClass()
        {

        }
        public MyClass(int a)
        {
            Console.WriteLine("Bir adet myclass nesnesi oluşturulmuştur. " + a);
        }
        public MyClass(string a)
        {

        }
        public MyClass(string a,int b)
        {

        }
        public void X()
        {

        }
    }
    class MyClass2
    {
        MyClass2()
        {

        }
        void X()
        {
            new MyClass2();
        }
    }
    class MyClass3
    {
        public MyClass3()
        {
            Console.WriteLine("1. Constructor");
        }
        public MyClass3(int a) : this()//Herhangi bir constructor'ın yanına bu şekilde this keywordünü verirsen o anki constructor'ın dışındaki diğer constructorlara erişmeni sağlayacaktır
        {
            Console.WriteLine($"2. Constructor : a = {a}");
        }//Eğer ki nesne üretiminde bu constructor tetikleniyorsa içerideki işlemleri gerçekleştirmeden önce this() deki constructor'ı tetikleyecektir.
        public MyClass3(int a,int b) : this(a)//burada parametre olarak manuel ve sadece çağrılan yerin parametlerine erişim sağlayabilir.
        {
            Console.WriteLine($"3. Constructor : a = {a} | b = {b}");
        }
    }
    record MyRecord
    {
        public MyRecord()
        {

        }
        public MyRecord(int a) : this()
        {

        }

    }
}
