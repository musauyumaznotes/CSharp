using System;

namespace Polymorp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Çok Biçimlilik(Polimorfizm)
            //Bir nesnenin birden fazla türle/referansla işaretlenebilme mevzusu
            #endregion
            #region Polimorfizm Nedir?
            //Polimorfizm esasında kalıtım gibi biyolojik bir terimdir.
            //Bir olguyu bir nesneyi tarifle/formla tarif edebilmektir.
            //İki ya da daha fazla nesnenin aynı tür sınıf tarafından karşılanabilmesidir/referans edilebilmesidir.
            //Bir nesnenin birden fazla farklı türdeki referans tarafından işaretlenebilmesi polimorfizm'dir.
            //Polimorfizm bir nesnenin kalıtımsal olarak ilişkişi olan diğer nesnelerin referanslarıyla işaretlenebilmesini sağlar
            //Polimorfizm OOP tasarımlarında geliştirilen koda daha manevrasal bir şekilde nitelik kazandıran ve yaklaşım sergilememizi sağlayan bir özelliktir.
            //Polimprfizm programlamada ki temel prensip olan Sol/Sağ Prensibini aşıp eldeki nesnenin birden fazla referansla işaretlenebilmesini sağlar.
            //Polimorfizm dışında elindeki herhangi bir nesneyi sadece o nesnenin referansıyla işaretleyebiliyorsun Amma velakin polimorfizm sayesinde elindeki bir nesneyi o nesnenin türünün dışındaki referanslarla da işaretleyebiliyorsun.İşte bu nesneye farklı türlerdeki referanslarla işaretlenebilme niteliği kazandıran yapılanmaya polimorfizm denir.
            //bir nesnenin birden fazla referansla işaretlenmesi o nesnenin birden fazla türün davranışını sergilemsini sağlar.
            #endregion
            #region Polimorfizm Felsefesi - 1
            //Yani bir olguyu çoklu form olarak tarif edebilmektir.
            //Yazılımda polimorfizm'in olabilmesi için kalıtım şarttır
            //Bir nesnenin farklı bir nesnenin referansıyla işaretlenebilemsi için o nesneden türüyor olması lazım.
            #endregion
            #region Polimorfizm Felsefesi - 2
            //Haliyle "Yemek yiyen canlılar yediklerini sindirirler" dediğimizde bir olguya çoklu formları tarif etmiş oluyoruz... İşte burada polimorfizm vardır.
            #endregion
            #region Polimorfizm Felsefesi - 3
            //Eşşeğe altım semer vursakta eşşek yine eşşşeeeeekkk
            #endregion
            #region Programlamada Polimorfizm Nerede Kullanılmaktadır?
            //Programlama da polimorfizm esasında taa en temelden beri kullanılmaktadır.
            //Örneğin elimizdeki herhangi bir byte türündeki veriyi ister byte istersekte byte'dan büyük olan herhangi bir türde tutmak çok biçimliliktir.
            //Ya da object türünün herhangi bir türdeki değeri alabilmesi yahut bir başka deyişle object türüne herhangi bir türdeki veriyiy atayabilmek polimorfizm'dir.
            //Evet bir nesnenin başka bir nesne ile işaretlenebilmesi/referans edilebilmesi için kesinlikle arada kalıtımsal bir ilişki olması gerekmektedir.
            //Yani bir başka deyişle Nesne tabanlı programlama'da polimorfizm uygulamak istiyorsanız türler arasında kalıtım uygulanmış olmalıdır.
            //OOP'de polimorfizm aralarında kalıtımsal ilişki olan sınıflarda uygulanabilir.Aksisi mümkün değildir.
            #endregion
            #region Örnek
            MyClass2 m = new MyClass();
            #endregion
            #region Polimorfizm Kalıtım İlişkisi
            //Bir nesneyi kendi türünün dışındaki bir tür ile/referansla işaretleyebilmek için kesinlikle ilgili nesne, o türden türemiş olması gerekmektedir.
            //Bir sınıftan üretilen bir nesne ancak ve ancak kendisinden olan bir referansla işaretlenebilir ya da atalarından olan bir referansla işaretlenebilir!!!! bu durumda derived class aynı zamanda base class olacağından işaretlenebilir olacaktır.
            #endregion
            #region Örnek 2
            A1 a = new B1();
            B1 b = new B1();
            C1 c = new B1();
            #endregion
            #region Polimorfizm Nesne Yönetiminde Neye Yarar?
            //Bir nesnenin birden fazla referansla işaretlenebilmesi o nesnenin birden fazla türün davranışlarını gösterebilmesini sağlar.
            //Sen hangi referansla nesneyi işaretlersen sadece O referansın davranışlarını görebilirsin. ya da bu nesnenin referans türündeki davranışlarına ulaşabiliyorsun. Bu referansla nesnenin üzerindeki davranışı elemiş oldun.Çünkü referansın erişebileceğin davranışları sınırlandırarak/filtrelendirerek getirir.
            //Polimorfizm bir nesnenin kendi türünün dışında bir veya birden fazla türle işaretlenebilmesidir/referans edilebilmesidir.Ve bunun bize getirmiş olduğu farklı davranışları sergileyebilme niteliğidir.
            #endregion
            #region Örnek 3
            C c1 = new C();
            B b1 = new C();
            A a1 = new C();
            #endregion
        }
    }
    #region Örnek
    class MyClass : MyClass2
    {

    }
    class MyClass2
    {

    }
    #endregion
    #region Örnek 2
    class A1 : C1
    {

    }
    class B1 : A1
    {

    }
    class C1
    {

    }
    #endregion
    #region Örnek 3
    class A
    {
        public void X() { }
    }
    class B : A
    {
        public void Y() { }
    }
    class C : B
    {
        public void Z() { }
    }
    #endregion
}
