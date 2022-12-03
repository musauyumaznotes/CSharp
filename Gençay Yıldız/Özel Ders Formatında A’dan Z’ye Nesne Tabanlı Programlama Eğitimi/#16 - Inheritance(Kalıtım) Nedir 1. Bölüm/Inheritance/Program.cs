using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance(Kalıtım)
            #region Bir Programcı Açısından Kalıtım Nedir?
            //OOP yaklaşımı gerçek hayattan modellenerek yazılıma uygulanmış/uyarlanmış bir yaklaşımdır. Kalıtımı adamlar demiş ki ulan biz oop diye bir yaklaşım geliştiriyoruz bunu daha iyi nasıl yapabiliriz demişler biyolojideki kalıtım mantığını alıp buraya uyarlamışlar
            //Nesne tabanlı programlama bir tek yazılımı programlama değil günlük hayatı programlama üzerine de bizlere mantık kazandırır.
            //Kalıtım OOP'nin ennnn önemli özelliğidir.
            //Üretilen nesneler farklı nesnelere özelliklerini aktarabilmekte ve böylece hiyerarşik bir düzenleme yapılabilmektedir.
            //Aynı aile grubundan gelen nesnelerin ya da yatayda eşit seviyede olan tüm olguların benzer özelliklerini tekrar tekrar her birinde tanımlamaktansa bir üst sınıfta tanımlanmasını ve her bir sınıfın bu özellikleri üst sınıftan kalıtımsal olarak almasını sağlamaktadır.
            //böylece hem kod maliyeti düşmekte hem de mimarisel tasarım açısından avantaj sağlamaktadır.
            //Kod maliyetini düşürür.
            //Kalıtım denen olay lazımsa kullanılır.
            //Bizim işimiz bir yerden sonra var olan bir şeyi tekrar tekrar yazmak değil Biz durmandan stratejik bir yapılanmaya kayacağız Senin yazacağın kodlar kullanılabilir olmalı lazım olduğu noktada kullanılabilir olmalı eğer kullanamıyorsan tekrardan lazım olduğu noktada yazıyorsan orada bir problem vardır.
            //Nesne tabanlı programlamada benzer/aynı oldgudaki nesnelerin aynı olan memberları/özellikleri/içerikleri eğer ki her sınıf içinde tekrar tekrar tanımlanmışsa bu aykırı bir durumdur!
            //Aynı olguda olan sınıfların tekrar eden memberları bir başka sınıfta toplansın ve oradan ilgili sınıflara kalıtımsal olarak aktarılsın
            //Genellenemeyen, diğerlerinde olmayan ve sadece o sınıfa ait olan özellikler direkt ilgili sınıfta tanımlanmalıdır
            //OOP'de kalıtım özünde nesnelerin birbirinden türemesini sağlayan bir özelliktir.
            //Bu özellik yanında da birçok özellik ve stratejik yapılanma getirmektedir.
            #endregion
            #region Kalıtımın Kullanılmadığı Durum
            //Benim sınıflarımın içerikleri aynıysa bir kendine sorarsın benim yazdığım kod ne kadar kaliteli Bir kod yazdık çalışıyor nesne üretebiliyorum mis gibi
            //ama benim bir cümle kurma tarzım var bir de o cümleyi üslubuyla tanımlı kurma şansım var kısacık cümleyle derdimi anlatıp çözüm getirmek varken uzun uzun derdimi anlatıp daha sonradan da o derdi komplike hale getirebilecek şekilde çözmek var  
            //Aynı olguda olan sınıfların tasarımına baktığında tekrar eden yapılanmalar varsa diyeceksin ki ulan burda bir yanlışlık olabilir ben buradaki hepsinde tekrar eden yapılanmaları bir farklı sınıfa alıp oradan kalıtım alabilirim diyeceksin
            #endregion
            #region Kalıtımın Kullanıldığı Durum
            // Kalıtım lalettayin bir şekilde tasarlanmamalıdır. Ortak olguda olan nesneleri temsil edecek olan bir üst ve daha evrensel nitelikte olgu olmalıdır.Opel,Mecedes ve Fiat ortak olgudur. Yani üçüde bir arabadır. Haliyle bunların daha evrensel üst niteliği Araba olarak nitelendirilir.
            //Kalıtım operasyonunda kalıtım veren sınıfın erişilebilen tüm memberları kalıtım alan sınıfa kalıtsal olarak aktarılacaktır.
            //Kodları tekrar tekrar tüm sınıflarda yazmaktansa kalıtımdan faydalanmak en doğrusu!
            //Tek bir merkezi yerden tekrar eden yani ortak olan yapılanmaları yöenetebiliyorum. kodlarımız 
            //Hem yönetilebilirliği artmış oldu hem de kod maliyetini düşürmüş olduk.
            #endregion
            #region C# Programlama Dilinde Hangi Yapılar Kalıtım Alabilirler?
            //Kalıtım sınıflara özel bir niteliktir.
            //Yani bir sınıf sade ve sadece bir sınıftan kalıtım alabilir.
            //record'lar da kalıtım alabilmekte Lakin sadece kendi aralarında.Kalıtım alabildikleri tek istisnai sınıf Object sınıfıdır 
            //Ayrıca abstract class, interface ve struct gibi yapılarında kendilerine göre kalıtımsal operasyonları mevcuttur.

            #endregion
            #region C#'ta Kalıtım Nasıl Alınır? (: Operatörü)
            //İki sınıf arasında kalıtımsal ilişki kurabilmek için : operatörü kullanılmaktadır.
            //Hatta bilsekte bilmesekte kalıtımsal tüm ilişkiler : operatörü tarafından yapılmaktadır
            //class Opel : Araba  => Soldaki, sağdakinden kalıtım alsın bu şekilde çalışma neticesinde artık compiler sevitesinde Araba sınıfındaki bütün erişime açık olan,kalıtıma müsait olan memberlar Opel'e aktarılmış olacaktır.
            //{

            //}
            //Kodun içinde selena gibi gelmez bu yapmış olduğun işlem neticesinde bir nesne oluşturduğunda ilgili aktarılan/miras alınan datalara/memberlara erişebileceksin Yani bunların direkt fiziksel olarak gözükmesini bekleme bu compiler seviyesinde yani arkada dijital seviyede oluyor.
            //Erişim belirliyecileri bir yandan da kalıtımsal durumlarda memberların davranışlarını sergilememizi sağlar 
            //Kalıtım operasyonel olarak gerçekleştirildikten sonra compiler seviyesinde member aktarımı sağlanır!
            #endregion
            #endregion
            Muhasebeci muhasebeci = new Muhasebeci();
            Mudur mudur = new Mudur();
            Yazilimci yazilimci = new Yazilimci();
        }
    }

    class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool MedeniHal { get; set; }
    }
    class Muhasebeci : Personel
    {
        //public string Adi { get; set; }
        //public string Soyadi { get; set; }
        //public bool MedeniHal { get; set; }

        public bool Musavir { get; set; }
    }
    class Yazilimci : Personel
    {
        //public string Adi { get; set; }
        //public string Soyadi { get; set; }
        //public bool MedeniHal { get; set; }
        public string[] KullandigiDiller { get; set; }
    }
    class Mudur : Personel
    {
        //public string Adi { get; set; }
        //public string Soyadi { get; set; }
        //public bool MedeniHal { get; set; }
    }
}
