using System;

namespace PatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Type Pattern
            //Herhangi bir objecte yani boxing işlemine tabi tutulmuş değerin türünü tespit ettikten sonra cast işlemini is operatöründen sonra otomatik yapan bir desendir. Yani is operatörünün desenleştirilmiş hali
            object x = "Musa";
            if (x is string a)
            {
                //string _x = (string)x;
                Console.WriteLine(a);//Burada a değişkeninin garanti doğru olduğunu biliyor yani null olmadığını biliyor
            }
            else if (x is int b) //değişken isimleri farklı olmalı
            {

            }
            //a = "agfagawgaf";
            //Console.WriteLine(a);//Null olma ihtimali yüzünden hata veriyor
            //bir değişken null ise ne çağırabilirsin,ne üzerinden bir değer çağırabilirsin, ne de değerini çağırabilirsin sadece ona bir değer atayabilirsin.
            #endregion
            #region Constant Pattern
            //Elimizdeki veriyi sabit bir değer ile karşılaştırabilmemizi sağlar.
            //Yapısal olarak == operatörünü sağlayan bir pattern'dır diyebiliriz

            object y = 123;
            int c = 123;
            Console.WriteLine(c is 123);
            if (x is 123)
            {

            }
            if (x is int)
            {

            }
            #region Constant Pattern - Kritik
            //is operatörü bir değişkenin türünü sormamızı/belirlememizi sağlayan bir operatördür. Ve bu operatörün kullanıldığı değişkenleri türü illa bir referans türlü olmak zorunda değildir.
            //İsterseniz değer türlü değişkenlerde de is operatörü kullanılabilmektedir ve hatta primitive türlerde bile kullanılabilmektedir...
            int d = 5;
            //tür kontrolü
            Console.WriteLine(d is int);
            Console.WriteLine(d is string);//Buradakiler ise normal is operatörünün kendi fıtratındaki işlemdir.
            Console.WriteLine(d is bool);

            //değer kontrolü
            Console.WriteLine(d is 5);//Eğer ki is operatörüyle bir değişkenin değerini == operatörünün sorumluluğuyla check ediyorsak işte buna constant pattern denmektedir...
            #endregion
            #endregion
            #region Var Pattern
            //Eldeki veriyi 'var' değişkeni ile elde etmemizi sağlamaktadır.
            //Type pattern'ın daha da hızlandırılmış halidir.
            #region Var Pattern - Kritik
            object x1 = "asfasfa";
            if (x1 is var a1)//x1 in türü her ne olursa olsun direkt var runtime'da ilgili x'in türünü UnBoxing edecek ve sana  a1 olarak getirecektir
            {

            }
            #endregion
            #region Kritik 2
            //var normalde derleme sürecinde türü belirlerken var pattern'daki var runtime anında türü belirlemektedir. Mülakt!!!!
            object x3 = "asfasfasf";
            var b2 = "afasfasfa";//Tür derleme aşamasında otomatik olarak belirlendi
            if (x3 is var a3)
            {

            }
            #endregion
            #region Kritik 3
            object x4 = "asegaogfaf";
            var b4 = "akjfagag";//Derleme aşamasında türü belirlenir
            dynamic c4 = "asefafasdf";//Runtime'da türü belirlenir
            if (x4 is var a4)
            {

            }
            //Siz eğer ki değişken bakımından atanan değerin türüne runtime'da bürünmek istiyorsanız bu dynamic keywordudur
            #endregion
            #endregion
            #region Recursive Pattern
            //Bu desen switch - case yapılanmasını üzerinde birçok yenilik getirmektedir.
            //switch bloğunda referans türlü değişkenlerde kontrol edilebilmektedir.
            //Ayrıca switch bloğuna when komutu ile çeşitli şart/koşul niteliği kazandırılmıştır.
            //Recursive pattern tür kontrolü yaptığı için Type Pattern'i kapsamaktadır.
            //Recursive Pattern, case null komutu ile ilgili türün/referansın null olup olmamasını kontrol edebilmesinden dolayı Constant pattern'i kapsamaktadır.
            #endregion
            #region Type ve Var Pattern Üzerine Kritik
            object x5 = "fdasfagaga";
            if (x5 is string a5)
            {
                Console.WriteLine(a5);
            }
            if (x5 is var b5)
            {

            }
            //type pattern'da x5 değişkeninin string olmama ihtimalinde  o1'in null olma ihtimali söz konusu olduğu için o1 kullanılırken hata vermektedir.
            bool result = x5 is string o1;
            Console.WriteLine(o1);

            //var pattern'da ise x5 değişkeninin değeri ne olursa olsun var ile o2'ye atanacağından dolayı o2'nin null olma ihtimali yoktur... dolayısıytla o2'yi rahatça kullanabilmekteyiz...
            bool result2 = x5 is var o2;
            Console.WriteLine(o2);

            #endregion
        }
    }
}
