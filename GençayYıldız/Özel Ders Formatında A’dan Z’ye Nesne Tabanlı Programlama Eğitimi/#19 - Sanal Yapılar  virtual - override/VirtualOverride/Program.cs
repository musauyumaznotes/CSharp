using System;

namespace VirtualOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sanal Yapılar Virtual & Override
            //Bir nesne üzerinde var olan tüm memberların tamamı derleme zamanında belirgindir.
            //Yani derleme aşamasında hangi nesne üzerinden hangi metotların çağrılabileceği bilinmektedir.
            //Sanal yapılar ile derleme zamanında kesin bilinen bu bilgi run time(çalışma zamanı)da belirleneblmektedir. Yani ilgili nesnenin hangi metodu kullanacağı bilgisi kararlaştırılır
            //Yani bir member'ın bir sınıfın içerisinde olup olmayacağını runtime'da/çalışma zamanında belirlemek istiyorsan bunu biz sanal yapılanmalar sayesinde sağlıyoruz.
            #endregion
            #region Sanal Yapılar
            //Sanal yapılar bir sınıf içerisinde bildirilmiş olan ve o sınıftan türeyen alt sınıflarda da tekrar bildirilebilen yapılardır.
            //Sanal dediğimiz yapı bir sınıfın içinde bildirilmiş olan bir member'dır ve bu sınıftan türeyen başka bir sınıfta tekrardan da bildirilebilir.Biz bunun farkına/hangi sınıfta bildirildiğinin farkına derleme zamanında varamadığımız için runtime'da farkına varırız.
            //Bu yapılar metot ya da property'ler olabilir.
            //Name hiding base class'ta tanımlanmış olan bir member'ın kendisinden türeyen sınıfların herhangi birinde tekrardan tanımlanmısıdır.Ama sanal yapılanmalar base class'ta tanımlanmış olan sanal yapılanmanın kendisinden türeyen soyundan gelen herahngi bir class'ta bildirilebilmesidir. yani ezilebilmekte/devre dışı bırakılıp yeniden oluşturulabilmektedir.
            //Name hiding durumunda var olan bir member aynı isimde kendisinden türeyen farklı bir sınıfta aynı isimde aynı imzada tanımlanır.Amma velakin sen var olan bir member'ı kendisinden türeyen herhangi bir sınıfta ezip içeriğini yeniden oluşturmak/var olan algoritmasını/işlevselliğini/davranışını yeniden şekillendirmek istiyorsan biz buna sanal yapılanma diyoruz
            //Name hiding isim çakışmasıdır yani atalarda var olan aynı isimde olan bir member torunlarda herhangi birinde de vardır ikisininde davranışı farklı olabilir bu torunlardaki member atalarda bulunan memberı eziyor/yeniden düzenliyor anlamına gelmez.
            //Atalardaki herahngi bir member'ı içeriğinin/algoritmasının/davranışının bilinçli bir şekilde torunlarda değiştirilmesi sanal yapılarla sağlıyoruz bu şu demek atalardaki bu özellik devre dışı 
            //İşte burada bir sınıfta tasarlanmış sanal yapının işlevinin iptal edilip edilmeme durumuna göre tanımlandığı sınıftan mı yoksa bu sınıfın torunlarından mı çağrılacağının belirlenmesi runtime'da gerçekleşecektir.
            //base class'taki atalardaki herhangi bir member sanalsa ve bu sanal yapı atadan mı gelecek yoksa torunların herhngibirinden mi gelecek ordan mı çağrılacak nerden çağrılacağı derleme aşamasında bilinmez.Biz bunun kararını runtime'da veririz.
            //Eğer sanallaştırılmış member ezilirse artık fiziksel bir member olmuştur.
            //Vee unutma Metot ya da property fark etmez Bir sanal member'ın hangi türe ait olduğunun bu şekilde run time'da belirlenmesine Geç Bağlama(Late Binding) denir.
            #endregion
            #region Sanal Yapılar Ne İçin Kullanılamaktadır?
            //Kalıtımsal olarak gelen bu niteliği kendimde değiştiriyorsam işte bu değişiklik hakkını bana veren özellik o member'ın/özelliğin/niteliğin sanal olması
            //Sanal yapı kendinden türeyen torunlarda ezilmek/yeniden yazılmak zorunda değildir.
            //Virtual ile işaretlenmemiş member kesinlikle override edilemez.
            #endregion
            #region Örnek - Ek
            Terlik t = new Terlik();
            t.Bilgi();

            Kalem k = new Kalem();
            k.Bilgi();
            #endregion
            #region Örnek 1
            Maymun m = new Maymun();
            m.Konus();
            Inek i = new Inek();
            i.Konus();
            #endregion
            #region Örnek 2 
            Ucgen u = new Ucgen(3, 4);
            Console.WriteLine(u.AlanHesapla());

            Dortgen d = new Dortgen(3, 4);
            Console.WriteLine(d.AlanHesapla());

            Dikdortgen dd = new Dikdortgen(3, 4);
            Console.WriteLine(dd.AlanHesapla());
            #endregion
            #region Özet
            //Sanal yapılar OOP'de Polimorfizm(Çok Biçimlilik)'i uygulayan yapılardır.
            //Sanal yapıalrın en önemli özelliği Geç Bağlam(Late Binding)'dir.
            //Eğer bir member sanla olarak bildirilnenişse derleyici nesnelerin tür bilgisinden faydalanarak derleme zamanında hangi nesneden ilgili member'ın çağrılacağını bilir.
            //Eğer bir member sanal olarak bildirilmişse, ilgili member'ın hangi nesne üzerinden çağrılacağı run time'da belirlenir. Hangi member'ın runtime'da belirlenmesine geç bağlama(late binding) denir
            //Türeyen sınıflar sanal yapıları override etmek zorunda değildirler
            //Static yapılanmalar sanal olarak bildirilemezler.
            #endregion
        }
    }
    #region Örnek - Ek
    class Obje
    {
        virtual public void Bilgi()
        {
            Console.WriteLine("Ben bir objeyim...");
        }
    }
    class Terlik : Obje
    {
        public override void Bilgi()
        {
            Console.WriteLine("Ben bir terliğim...");
        }
    }
    class Kalem : Obje
    {
        public override void Bilgi()
        {
            Console.WriteLine("Ben bir Kalemim...");
        }
    }
    #endregion
    #region Örnek 1
    class Memeli
    {
        virtual public void Konus()
        {
            Console.WriteLine("Ben konuşmuyorum...");
        }
    }
    class Maymun : Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("Ben maymunum...");
        }
    }
    class Inek : Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("Ben ineğim...");
        }
    }
    #endregion
    #region Örnek 2
    class Sekil
    {
        protected int _boy; //protected ile işaretlenmiş herhangi bir member sade ve sadece ilgili sınıfta yahut o sınıftan kalıtım almış olan sınıfların içerisinde erişilebilir.Amma velakin nesne üzerinden erişilemez!
        protected int _en;
        public Sekil(int boy, int en)
        {
            _boy = boy;
            _en = en;
        }
        virtual public int AlanHesapla()
        {
            return 0;
        }
    }
    class Ucgen : Sekil
    {
        public Ucgen(int boy, int en) : base(boy, en)
        {

        }
        public override int AlanHesapla()
        {
            return _boy * _en / 2;
        }
    }
    class Dortgen : Sekil
    {
        public Dortgen(int boy, int en) : base(boy, en)
        {

        }
        public override int AlanHesapla()
        {
            return _boy * _en;
        }
    }
    class Dikdortgen : Sekil
    {
        public Dikdortgen(int boy, int en) : base(boy, en)
        {

        }
        public override int AlanHesapla()
        {
            return _boy * _en;
        }
    }
    #endregion
}
