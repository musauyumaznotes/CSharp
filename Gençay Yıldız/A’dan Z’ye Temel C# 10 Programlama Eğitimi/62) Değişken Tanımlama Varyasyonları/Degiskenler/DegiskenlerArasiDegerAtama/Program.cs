using System;

namespace DegiskenlerArasiDegerAtama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Deep Copy
            //Derin kopyalama
            //Eldeki veri çoğaltılır, klonlanır.
            //Birden fazla referans/veri/değişken farklı değişken değerleri referans ediyorsa deep copy söz konusudur
            int a = 5;
            int b = a;

            a = a * 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //Bir değişkende yapılan değişiklik diğer değişkene yansımıyorsa deep copy yapılmıştır.
            #endregion
            #region Shallow Copy
             //Değişkenler arası değer atamalarında değeri türetmek/çoğaltmak/klonlamak yerine var olanı birden fazla referansla işaretlemeye dayalı kopyalama yöntemidir
             //Bellekte birden fazla referansın tek bir veriyi işaret etmesidir.
             //Neticede ilgili değer bir değişikliğe uğradığında tüm işaretleyen referanslara bu değişikliğin yansımasıdır.
             //referansını kopyalamadır.
             //b = a ==> Burada a b'ye kopyalanmıyor a'nın varolan değeri yüzeysel kopyalanıyor

            #endregion
        }
    }
}
