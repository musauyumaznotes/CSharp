using System;

namespace objectType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region object
            //Tüm türleri karşılayabilen bir türdür.
            //Tüm türlerin üst çatısı Object'tir.
            //Tüm türler varsayılan olarak object'ten türerler.
            //Object değişkenler ilgili verileri RAM'de object türde tutarlar. Lakin verinin öz türünüde içerisinde bozmadan saklarlar. Yaniiii object içerisindeki veri kendi öz türünde tutulur
            //Bu durum object içerisindeki veriyi kedni türündwe tekrar elde edebiliriz anlamına gelmektedir...

            #region Boxing
            //object türdeki bir değişkene herhangi bir türdeki değeri göndermek Boxing olarak nitelendirilmektedir.
            //Herhangi bir değer object türe assign ediliyorsa eğer bu işlem Boxing işlemidir.
            int yas = 28;
            object _yas = 28;//Boxing //kutulama işlemi
            #endregion
            #region Cast Operatörü
            //Cast Operatörü parantezdir.
            //Cast Operatörü, object oan değişkenin solunda o object'i hangi türe Unboxing etmek istiyorsak parantez içerisine hedef türü bildirerek kullanılır.
            #endregion
            #region UnBoxing
            #region Casting 
            //int yas2 = (int)_yas;//UnBoxing
            //Console.WriteLine(yas2 * 5);
            string yas3 = (string)_yas;//Farklı bir tiple UnBoxing yaptığımızdan Runtime'da patladık
                                       //Ne şekilde koyduysan o şekilde çıkarmalısın
            #endregion
            #endregion
            #endregion
            
        }
    }
}
