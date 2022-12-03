using System;

namespace ReferansNesne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Referans Nedir?
            //RAM'in Stack bölgesinde tanımlanan ve Heap bölgesindeki nesneleri işaretleyen/referans eden değişkenlerdir/noktalardır
            //Stack'de tüm değer türlü değişkenlerimi ve değerlerini tutabiliyorum amma velakin referans türl değerlere geçtiğimizde değerler heap'te tutulurken Stack'te referanslar tutulur. Değişkenin kendisi Stack'te karşılığı olacak olan değer Heap'te tutulur
            //Interface'ler/Abstract Classlar referans türlü değişkenlerdir. Referans noktası alınabilir değişkenlerdir.
            //Referanslar illa bir nesne referans etmek zorunda değildirler.
            //Eğer ki bir referans herhangi bir nesne işaretlemiyorsa null değerini alır.
            #endregion
            #region Stack Heap İlişkisi
            #region Nesneler Neden Referansla İşaretleniyor? Neden referans kullanıyoruz?
            //Developer olarak bilgisayarda sabit diske direkt erişebiliyorum,belirli yetkilerim varsa register denilen yapıya erişebiliyorum, bellekte Stack'e erişebiliyorum, Static'e erişebiliyorum amma velakin Heap'e erişemiyorum
            //Heap'teki herhangi bir değere/nesneye erişmek için Heap'e dolaylı yoldan erişmem gerekecek haliyle Heap'e erişebilen başka ve benim de erişebildiğim başka bir yapılanmayı kullanmam gerekecek. İşte burada Stack devreye giriyor.
            //Biz Stack'e erişebiliyoruz, Stack'teki referanslarda Heap'teki nesnelere erişebildiğinden dolayı biz de dolaylı yoldan Stack üzerinden Heap'teki nesnelerimize erişebilmekteyiz.
            //Bundan dolayı nesneleri bir referansla işaretliyoruz.Eğer ki bir nesneyi referansla işaretlemezsek ilgili nesneyi kullanamayız.
            #endregion
            #region Referans Üzerinden Nesneye Nasıl Erişilebilir?
            //Stack'te oluşturduğumuz değişken sayesinde erişilebilir
            #endregion
            #region Nesne Üzerindeki Elemanlara Nasıl Erişilir?
            //Elemanlara erişebilmek için yine yapmamız gereken nesneye erişmek (.) operatörü ile dışarıya erişebilirliği olan, dışarıdan erişime izni olan, dışarıdan erişilebilir olan tüm memberlara/elemanlara rahat bir şekilde erişebilmekteyim.

            MyClass m = new MyClass();//Burda bir nesne oluşturup m referansıyla işaretlemiş
            m.MyProperty = 10;//burda da m referansında bir işlem yapmış

            //o referans üzerinden ilgili nesne üzerinde yapmış olduğum herahngi bir işlem daha doğrusu referansın üzerinde yapmış olduğum herhangi bir işlem işaret ettiği nesne üzerinden gerçekleştirilir.

            MyClass m2 = null;//Burda m2 referansını oluşturmuş

            m2.MyProperty = 20;//Ya kardeşim MyProperty tamam bu türün içinde var ama buna karşılık bir nesne oluşturmadığın sürece bu MyProperty'i nerede çalıştıracağını bilemeyecek yani çalıştıracak bir nesne yok somutlaştırılmamış haliyle program burada patlaycaktır.


            //Eğer ki bir referans null ise access modifier(.) operatörü sayesinde ilgili referansın içerisindeki memberlara erişebilirsiniz.Amma velakin referansın bir nesnesi olmadığından dolayı bu member'ı tetikleyecek, bu member'ı üzerinde çalıştıracak bir nesne/ekosistem/organizma olmayacağından dolayı bu referansta null reference hatası verecektir.

            //Null olan(yani nesnesi olmayan) referanslar üzerinden herhangi bir member'i çağırıp işlemeye çalıştığımızda bu durumda NullReference hatası verecektir. 
            #endregion

            #endregion
            #region Referanssız Nesneler
            //Her nesnenin bir referansı olmak ya da bir referans tarafından işaretlenmek zorunda değildir!!!
            //Bir nesne oluşturulduğu an herahngi bir referansla işaretlenmezse eğer Heap'e yerleştirilir. Lakin bu nesneye tarafımızca bir daha erişemeyiz. Haliyle ilgili nesneyle aramızdaki tek diyalog oluşturma anıdır.
            //Heap'te duran nesneler referanssızsa/işaretleyicisi yoksa(Lüzumsuz bir şekilde duran/memory'de bir alan tahsis eden) Garbage Collector mekanizması sayesinde bunlar temizlenecektir.
            //Eğer ki bir nesne referanssızsa bunu oluşturabilmekteyiz... Lakin bu nesne sistemde/memoryde lüzumsuz yer kaplayacağından dolayı belli bir süre sonra Garbage Collector dediğimiz çöp toplayıcısı tarafından temizlenecektir. 
            //Garbage Collector: Heap'de referanssız olan nesneleri imha etmekten/temizlemekten sorumlu bir yapılanmadır.
            #region Referansız Nesne Üzerindeki Elemanlara Nasıl Erişilir

            new MyClass().MyProperty = 10;
            //Bir nesne eğer referanssızsa bu nesneyi tanımladıktan sonra bir daha erişemezsiniz. Dolayısıyla referanssız tanımlanmış olan nesneyi erişebilmenin tek yolu tanımlama anıdır. bir kere erişirsin o da son kez selametle demek için :):)
            #endregion
            #endregion
            #region Referans Türüne Göre Nesne Elemanlarına Erişim
            //Her bir referans bir nesneyi temsil edecek imzaya sahiptir.
            //Benim nesneyi referans edebilmek için o nesneyi temsil edebilcek bir fıtratta class'a ihtiyacım var. bu da nesnenin türündeki class'tır.
            #endregion
            #region Object Initializer İle Nesne Oluşturma Esnasında Propertylere İlk Değer Atama
            //sadece field ve propertylere değer atama yapılabilir methodlara atama yapılamaz ve çağırılamaz
            MyClass m4 = new MyClass()
            {
                MyProperty = 10,
                MyProperty2 = 30,
                MyProperty3 = 40,
            };
            MyClass m5 = new MyClass();
            m5.MyProperty = 10;
            #endregion
        }
    }
    class MyClass
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }
    }
}
