using System;

namespace Inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Base Class ve Derived Class Nedir?
            //Kalıtımsal ilişkide olan iki sınıf arasında kalıtım veren sınıfa Base/Parent class Kalıtım alan class'a ise Derived/Child class denir.
            //Unutma bir sınıfın sade ve sadece tek bir Base class'ı olabilir! direkt türediği sııftır Base class'ı
            //Base class dediğimiz kavram direkt birebir kalıtımı aldığınız sınıftır.
            //Lakin atalarındaki tüm sınıflar Base Class'ı değildir!
            //Bir class'ın birden fazla Derived Class'ı olabilir. yani benim bir tane babam vardır ama babamın birden fazla oğlu/kızı olabilir.
            //Bir class hem Derived class hem de Base class olabilir
            //Bir derived class'ın ataları olabilir fakat onlar derived class'ın base class'ı değildir.Ata yadigarı sınıflar olacaktır.
            #endregion
            #region Kalıtımın Altın Kuralı!
            //Bir class'ın sade ve sadece bir Base Class'ı olur dedik. 
            //C# programlama dilinde bir class'ın sade ve sadece tek bir class'tan türetilmesine izin verilmektedir! Aynı anda birden fazla class'tan türeme işlemi gerçekleştirilemez!
            #endregion
            #region Kalıtımda Nesne Üretim Sırası
            //Bir sınıftan nesne üretimi yapılırken kalıtım aldığı üst sınıflar varsa eğer önce o sınıflardan SIRAYLA nesne üretilir.
            //Yazılım sen nesne üretmesende compiler seviyesinde ilgili kalıtım veren sınıftan bir nesne üretilecektir.Öncelikle katlıtım veren daha sınra kalıtım alandan nesne üretilecektir.
            //Kalıtımsal ilişkinin olduğu durumda nesne üretiyorsan eğer Ram'in Heap bölgesinde kaç tane hiyerarşik ata varsa o kadar nesne üretilmiş olur
            //Bu da arka planda bir sınıftan aktarılmış olan herhangi bir member'ı sen o sınıfta üst sınıflardan gelen bir member'ı kullanmak istiyorsan özünde arka planda oluşturulan nesne üzerinde tetikleme yapıyorsun.
            //Yani buradan anlaşılıyor ki bir sınıftan nesne üretilirken siz 1 tane nesne ürettiğinizi düşünsenizde kalıtımsal açıdan birden fazla nesne üretimi gerçekleşebilmektedir.



            new D();
            #endregion
            #region Bir Sınıftan Base Class Constructor'ına Ulaşım
            //Madem ki herhangi bir sınıftan nesne üretimi gerçekleştirilirken öncelikle base class'ından nesne üretiliyor, bu demektir ki önce base class'ın constructor'ı tetikleniyor.
            //Haliyle bizler nesne üretimi esnasında base class'ta üretilecek olan nesnenin istediğimiz constructor'larını tetikleyebilmeli yahut varsa parametre bu değerleri verebilmeliyiz.
            //İşte bunun için base Keyword'ünü kullanmaktayız.
            //Eğer ki base class'ın constructor'ı sadece parametre alan constructor ise derived class'larda o constructor'a bir değer GÖNDERMEK ZORUNDAYIZ bunuda base keywordüyle saplayabliriz...
            //Eğer ki base class'ta boş parametreli bir constructor varsa derived class'ta base ile bir bildirimde bulunmak zorunda değiliz... Çünkü varsayılan olarak kalıtımsal durumda base class'taki boş parametreli constructor tetiklenir
            //Bir class'ın constructor'ının yanında : base(...) kullanırsak eğer o class'ın tüm constructorlarını bize getirecektir. Haliyle ilgili sınıftan bir nesne üretilirken base class'tan nesne üretimi esnasında hangi constructor'ın tetikleneceğini bu şekilde belirleyebiliriz...
            new MyClass2();
            #endregion
            #region base Keyword vs this Keyword
            //this bir sınıftaki constructor'lar arasında geçiş yapmamızı sağlar
            //base bir sınıfın base class'ının constructor'larından hangisinin tetikleneceğini belirlememizi ve varsa parametrelerinin değerlerinin derived class'tan verilmesini sağlar.
            //thisi kullanıyorsam buradaki constructorlar base'i kullanıyorsam bir üstteki/base class'taki constructorlar
            //Ayrıca nasıl ki this keywordü ilgili sınıfta o ank, nesnenin memberlarına erişebilmemizi sağlıyor aynı şekilde base'de base class'taki memberlara erişebilmemizi sağlamaktadır.
            //Base class'ta erişilebilir olmayan member'lar base keywordüyle erişilemez!
            //private olan bir member base class'tan derived class'a aktarılmıyacağından dolayı base. dediğinde erişilmeyecektir.
            #endregion
        }
    }
    #region Örnek 1
    class BuyukBaba
    {
        //Büyükbabanın derived classı Baba'dır ama dolaylı yoldan da Ogul class'ı büyükbabanın derived class'ı olabilir. Dolayısıyla aynı mantık bir sınıfın derived class'ları bizzat kendisinden türeyenlerdir
    }
    class Baba : BuyukBaba
    {

    }
    class Anne : BuyukBaba
    {

    }
    class Ogul : Baba
    {

    }
    #endregion
    #region Örnek 2
    class A
    {
        public A()
        {
            Console.WriteLine($"{nameof(A)} nesnesi oluşturulmuştur.");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine($"{nameof(B)} nesnesi oluşturulmuştur.");
        }
    }
    class C : B
    {
        public C()
        {
            Console.WriteLine($"{nameof(C)} nesnesi oluşturulmuştur.");
        }
    }
    class D : C
    {
        public D()
        {
            Console.WriteLine($"{nameof(D)} nesnesi oluşturulmuştur.");
        }
    }
    #endregion
    #region Örnek 3
    class MyClass
    {
        public MyClass(int a)
        {

        }
        public MyClass(string a)
        {

        }
        public MyClass(int a, string b)
        {

        }
        public MyClass()
        {

        }
    }
    class MyClass2 : MyClass
    {
        public MyClass2() : base(5, "deasafasf")
        {

        }
        public MyClass2(int a) : base(a)
        {

        }
    }
    #endregion
    #region Örnek 4
    class E
    {
        int a;
        public int b;
        public int MyProperty { get; set; }
    }
    class F : E
    {
        int c;
        public void X()
        {
            MyProperty = 123;
        }
    }
    #endregion

}
