using System;

namespace Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nesne Nedir
            //Nesne dediğimiz yapı canlı bir organizma 
            //İçerisinde birden fazla anlamlı birbirleriyle ilişkisel veriler tutan ve bunları tutmakla yetinmeyen biraz da entelektüel alışkanlığı/yanı olan bu veriler üzerinde işlemler yapıp sonuçlar üretebilen fonksiyonellikler barındıran bir yapılanmadır/organizmadır.
            //Nesne bir veri bütünüdür.
            //Bir olguya dair bütün alakadar değerler bir araya geldiğinde nesne ortaya çıkar. 
            //Class yapılanmalarından üretilen verilerdir. 
            //Nesneler kompleks verilerdir.
            //Nesne dediğin içerisinde lüzumsuz bir değere yer vermeyen yapılanmadır/değerdir.
            //Nesneleri modellememizi sağlayan classlar ise Complex Type'dır
            //Nesne kodu daha hızlı geliştirebilmek, daha sistematik hale getirebilmek, daha yönetilebilir, daha kullanılabilir kılmak için kullanılır.
            //Nesnenin fıtratı class'tır. Nesne oluşturacaksan class'tan başka şansın yok!!!
            #endregion
            #region Sınıftan Nesne Üretme/Türetme/Oluşturma
            //Nesne üretimi için new operatörü kullanılmaktadır.
            //new yazdıktan sonra hangi sınıftan/türden bir nesne oluşturmak istiyorsan ilgili sınıfın ismini bildirmen yeterli olacaktır.
            //new operatörüyle herhangi bir türdeki bir sınıftan,ya da herhangi bir sınıftan ya da herahngi bir  türden nesne oluşturacaksan bunu yaparken buradaki fonksiyonu çağırmak zorundasın.

            new MyClass();//new operatörünü gören Compiler : Aha bir tane nesne oluşturacam :):):)
            //Bu operasyon neticesinde Ram'in heap bölgesine ilgili nesne atanıyor.
            //Elimizdeki nesneleri yani Heap'te oluşturmuş olduğumuz o organizmaları/verileri erişip üzerinde işlem yapıp değerleri üzerinde çalışmalar sergilemek istiyorsak bizim bu nesneyi stack'teki bir  referansla işaretlememiz lazım. 
            //Heap'teki nesneyi işaretleyebilmemiz için Heap'teki nesnenin tipi neyse referansının da tipi aynı olmalıdır.Yani biz Stack'te bir referans noktası/değişken tanımladık bu değişkenle Heap'teki/uzaktaki başka bir ortamdaki nesneyi referans etmiş/işaretlemiş olduk.

            
            new Random();//Bu bir nesne oluşturma talebidir.

            new MyClass();
            new MyClass();
            new MyClass();
            new MyClass();

            #region Target-Typed NEw Expressions (C# 9.0)
            //Nesne oluşum sürecinde, oluşturulacak olan nesne eğer ki direkt bir referansa atılıyorsa eğer burada hangi nesnenin oluşturulduğu referans sayesinde bilinebilmektedir. Dolayısıyla ilgili nesnenin oluşturulması için
            MyClass x = new MyClass();
            //semantiğinden ziyade
            MyClass x1 = new();//new dedik 
            //şeklinde de oluşturmamızı sağlayan yeni bir özelliktir.
            #endregion

            #endregion

        }
    }
    class MyClass
    {
        public int A { get; set; }
        public void X()
        {

        }
    }
} 
