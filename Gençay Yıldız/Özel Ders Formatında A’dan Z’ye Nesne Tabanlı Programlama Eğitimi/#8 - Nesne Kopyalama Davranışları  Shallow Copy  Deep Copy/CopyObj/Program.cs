using System;

namespace CopyObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nesne & Değer Kopyalamadan Kastedilen Nedir?
            //Belleğin stack kısmında tanımlanan ve değerlerini orada tutan değişkenlere Değer türlü değişkenler denir.
            //Nesnelerden farkı sadece değersel olmaları/sadece veri olmaları
            int a = 5;
            int b = a;

            #endregion
            #region Shallow Copy
            //Var olan bir nesnenin/değerin , referansının kopyalanmasıdır.Shallow copy neticesinde eldeki değer çoğaltılmaz.Sadece birden fazla referansla işaretlenmiş olur.
            //Nesne tek lakin işaretleyen referans sayısı birden fazla!
            //Bir nesneyi birden fazla referans işaretliyorsa ve bu nesne türetilmiyorsa/çoğlatılmıyorsa biz buna shallow copy deriz.
            //Referans türlü değişkenlerin/değerlerin default davranışı shallow copy'dir.
            #region Örnek 1
            MyClass m1 = new MyClass();
            MyClass m2 = m1;
            // Şu davranış eğer değer türlü değişkenler üzerinde yapılıyorsa eğer deep copy oluyordu yani değerler çoğaltılıyordu.
            //Eğer bu davranış referans türlü değişkenlerde oluyorsa burada shallow copy yapılır.Yani ilgili nesne ilgili değer türetilmez/çoğaltılmaz sadece işaretlenir.
            //Biz artık her iki referanstan'da aynı nesneyi elde ederiz.
            //Burada yüzeysel/sığ bir kopyalama yapılıyor.
 
            MyClass m3 = m2;
            MyClass m4 = new MyClass();
            #endregion
            #region Örnek 2
            MyClass m5 = null;
            MyClass m6 = new MyClass();
            MyClass m7 = m6;
            m5 = m7;

            #endregion
            #region Örnek 3
            MyClass m11 = new MyClass();
            MyClass m12 = new MyClass();
            MyClass m13 = m11;
            m11 = m12;
            m12 = m11;
            m11 = m11;

            //Bir referans sadece ve sadece tek bir nesneyi işaretler.Birden fazla nesneyi işaretlemesi mümkün değil.
            //Bir referans önceden bir nesneyi işaret ediyorsa o referansa başka bir nesneyi işaret etmesini söylediğin anda önceki işaretleme/referans kopacaktır.
            #endregion
            #endregion
            #region Deep Copy
            //Var olan bir nesne, deep copy ile kopyalanıyorsa eğer ilgili nesne miktarı çoğlaır.Aynı özelliklere ve değerlere sahip olan bellekte farklı bir nesne daha oluşur.
            //Değer türlü değişkenlerde default davranış deep copy'dir.
            //Bir metodun parametresinde ya da bir yerde bir değişkenene ihtiyacın olup gönderdiğin zaman oraya değişkenin kendisi gitmez değişkenin değeri kopyalanır hafızada ve bu değer gönderilir.
            //Davranış olark derin kopyalama yapmış oluyorsun Kopyalandıktan sonra oluşan değerler birbirinden bağımsız, aynı fıtratta olan bağımsız değerler/nesneler olacaktır.
            #endregion
            #region Deep Copy Exxample
            MyClass m111 = new MyClass();
            MyClass m112 = m111;//Shallow Copy
            MyClass m113 = m111.Clone();//Deep
            //m112 üzerinde değişiklik yaparsan m111 etkilenecek, m111 üzerinde değişiklik yaparsan m112 etkilenecek ama m113 üzerinde ne değişiklik yaparsan yap her ikiside etkilenmeyecek.Çünkü artık bu klonlanmış darklı bir değer/nesne bu 
            #endregion
        }
    }
    class MyClass
    {
        public MyClass Clone()
        {
           return (MyClass)this.MemberwiseClone();//MemeberwiseClone bir sınıfın içerisinde o sınıftan üretilmiş olan o anki nesneyi clonelamamızı sağlayan bir fonksiyondur...
        }
    }
}
