using System;

namespace oop_sinif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sınıf Nedir? Neden Sınıf Yapısı Kullanılır? 

            #endregion
            #region Sınıf İle Nesne Arasındaki İlişki Nedir?

            #endregion
            #region Sınıf Nasıl ve Nerede Oluşturulur?
            #region Namespace İçerisinde
            //Namespace : İçerisinde birden fazla class struct interface gibi yapılanmaları barındıran esasında senin kütüphane mantığını oluşturmanı sağlayan genel anlamda kurmuş olduğun sistemde sınıflarını farklı namespaceler altında kategorize edip çağırılma esnasında o kategorizeler üzerinden çağırmanı sağlayan bir yapılanmadır.

            #endregion
            #region Namespace Dışarısında

            #endregion
            #region Class İçerisinde(Nested Type)

            #endregion

            //Bir class tanımlanmasında tanımlanan yerde(namespace/dışı,class) aynı isimde birden fazla class tanımlanamaz!

            #endregion
            #region Sınıf İle Nesne Modeli Tasarlama
            //!!! İhtiyaçlar !!!
            //Değerler tutman gerekebilir field. Alan koymam lazım
            //Operasyonel/eylemsel işlemler yapmam gerekebilir. Yani fonksiyonelite kazandırmam gerekebilir.
            #endregion
            #region Sınıf Modelinden Referans Noktası Oluşturma
            //Bir class tanımlandığında o class adı bir türdür. Haliyle o türü kullanabilmek için direkt olarak class adını kullanmamız yeterlidir.

            OrnekModel w; //Senin bunu değişken türü olarak kullanabilmenin altında yatan şey esasında bu bir referans türlü bir değişken olmasıdır. 
            
            #endregion
        }
    }
    class MyClass
    {
        class MyClass3
        {

        }
    }
    class OrnekModel
    {
        //class 'ın içinde oluşturulan değişkenlere field denir
        int a;
        int b;
        public void X()
        {
            Console.WriteLine(a + " " + b);
        }
        public int Y()
        {
            return a * b;
        }

    }
}
class MyClass2
{

}
