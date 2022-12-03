using System;

namespace Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Polimorfizm Türleri  
            #region Static Polimorfizm
            //Derleme zamanında sergilenen polimorfizmdir.Hangi fonksiyonun çağrılacağına derleme zamanında karar verir
            //C#'ta static polimorfizm deyince aklımıza Metot Overloading gelmelidir.
            //Metot overloading aynı isimde birbirinden farklı imzalara sahip olan metotların tanımlanamsıdır.Ya da başka bir deyişle bir isme birden fazlar farklı türde metot yüklemektir.Haliyle burada bir metodun birden fazla formunun olması polimorfizm'ken bunlardan kullanılacak olanın derleme zamanında bilinmesi statik polimorfizm olarak nitelendirilir.

            #region Örnek
            Matematik m = new Matematik();
            m.Topla(1, 4, 6, 4);
            #endregion
            #endregion
            #region Dinamik Polimorfizm
            //Çalışma zamanında sergilenen polimorfizmdir.Yani hangi fonksiyonun çaışacağına run time'da karar verilir.
            //C#'ta dinamik polimorfizm deyince akla Metot Overrride gelmektedir.
            #region Örnek 2
            Arac a = new Arac();
            a.Calistir();

            Arac t = new Taksi();
            t.Calistir();
            #endregion
            //Base class'larda tanımlanmış olan herhangi bir virtual yani sanal yao-pılanma derived class'ta ezilip ezilmediğinin durumu çalışma zamanında bakılıyor.
            //Base class'taki sanal bir yapılanmanın Derived class'larda ezilip ezilmediğini/override edilip edilmediğini kararı run time'da veriliyor.
            //Metot Override base class'ta virtual olarak işaretlenmiş metotların derived class'ta override edilerek ezilmesi/yeiden yazılması işlemidir.Haliyle burada aynı isimde burdan fazla forma sahip fonksiyonun olamsı polimorfizm'ken bunlardan hangisinin kullanılacağının çalışma zamanında bilinmesi dinamik polimorfizm'dir.
            #endregion
            #endregion
            #region Polimorfizm Durumlarında Tür Dönüşümleri
            //Polimorfizm OOP'de bir nesnenin kalıtımsal açıdan ataları olan refferanslar tarafından işaretlenebilmesidir..haliyle ilgili nesne bu ataları olan referans türlerine göre dönüştürebilmektedir.
            //Dikkat edersen eğer Ğplimorfizm durumlarında kalıtımsal açıdan üst bir referans ile işaretlenebilmiş herhangi bir nesneyi kendi türünden işaretleyebilmek için Cast operatörünü kullanarak object türüne özel olan UnBoxing'e benzer bir hamlede bulunmuş oluyoruz...         Buradan anlıyoruz ki object türünde gerçekleştirilen UnBoxing durumu esasında object türü ile gerçekleştirilebilen Polimorfizm'in sonucudur...
            //Boxing herhangi bir stack'teki veriyi yani nesne olmayan veriyi nesneye dönüştürebilmek,stackteki herahngi bir türü heap'e alabilmek için yapılan bir uygulamadır.
            //Stack'teki tutulan herhangi bir değeri heap'e alabilmek yani primitive bir değeri yani değer türlü bir değeri/türü nesne haline getirebilmek için object mantığını kullanıyoruz.
            #endregion
            #region Cast Operatörü
            //Eğer ki kalıtımsal ilişki olmayan herhangi bir türe dönüştürülmeye çalışılırsa derleyici hatası verecektir
            //Yok eğer kalıtımsal ilişkide olup fiziksel nesnenin hiyerarşik altında olan bir türe dönüştürülmeye çalışılırsa run time hatası verecektir.
            #region Örnek 3
            A a1 = new C();
            //C c = (C)a1;

            D d = (D)a1;

            //object o = 123;
            //int i =(int)o;
            #endregion
            #endregion
            #region As Operatörü
            //Eğer kalıtımsal ilişkide olup fiziksel nesnenin hiyerarşik altında olan bir türe dönüştürülmeye çalışılırsa run time hatası vermeyecektir geriye null dönecektir.
            //as operatörü uygulamayı patlatmaz.
            //Cast operatörünün as operatöründen farkı biri dönüşüm sağlanamıyorsa hata fırlatırken(Cast) diğeri null dönmektedir(As).
            A a3 = new C();
            C c1 = a3 as C;
            #endregion
        }
    }
    #region Örnek
    class Matematik
    {
        public long Topla(int s1, int s2)
            => s1 + s2;
        public long Topla(int s1, int s2, int s3)
           => s1 + s2 + s3;
        public long Topla(int s1, int s2, int s3, int s4)
           => s1 + s2 + s3 + s4;
    }
    #endregion
    #region Örnek2
    class Arac
    {
        public virtual void Calistir()
            => Console.WriteLine("Araç Çalıştı...");
    }
    class Taksi : Arac
    {
        public override void Calistir()
            => Console.WriteLine("Taksi Çalıştı...");
    }
    #endregion
    #region Örnek 3
    class A{}
    class B : A{ }
    class C : A{ }
    class D : C { }
    #endregion
}
