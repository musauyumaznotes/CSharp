using System;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Members
            #region Field
            //Nesne içerisinde değer tutmamızı/depolamamızı sağlayan alanlardır.
            //Field sadece ve sadece class'ın scope'unda tanımlanır...
            //Fieldlar türüne özgü varsayılan değer alırlar.
            //MyClass m1 = new MyClass();
            //MyClass m1 :  Stack'teki m1 referansıyla Heap'teki nesneyi işaretleyecek new MyClass() : Heap'e gidecek nesne

            MyClass m1 = new MyClass(); //Nesne Oluşturduk !!!
            //m1.a = 5;
            //Console.WriteLine(m1.a);


            //int a;
            //Console.WriteLine(a);

            MyClass m2 = new MyClass(); //Nesne Oluşturduk !!!
            //m2.a = 25;

            #endregion
            #region Property
            //Property esasında özünde bir metotturç Yani programatik/algoritmik kodlarımızı inşa ettiğimiz bir metot.
            //Lakin fiziksel olarak metottan farkı parametre almamakta ve içerisinde get ve set olmak üzere iki adet blok almaktadır.
            //Biz yazılımcılar nesnelerimiz içerisindeki field'lara direkt erişilmesini istemeyiz.
            //Dolayısıyla field'lar da ki verileri kontrollü bir şekilde dışarıya açmak isteriz
            //İşte böyle bir durumda metotları kulanabiliriz
            //Encapsulation(Kapsülleme/Sarmalama) : bir nesne içerisindeki dataların(field'lardaki verinin) dışarıya kontrollü bir şekilde açılması ve kontrollü bir şekilde veri almasıdır.
            //Fieldlar senin cüzdanın sen cüzdanına direkt erişim vermezsin arada sen bulunursun birisi cüzdanına erişmek isterse izin vermezsin arada sen bulunur ve istediği şeyi ister verirsin ister vermezsin
            //Property fieldın gerçek değerini koruyor/kapsüllüyor/sarmalıyor
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.Yasi);
            myClass.Yasi = 65;




            Console.WriteLine(myClass.Yasi);

            #endregion
            #region Metot
            //Nesne üzerinde, field'larda ki yahut dışarıdan parametreler eşliğinde gelen değerler üzerinde işlemler yapmamızı sağlayan temel programatik parçalardır.
            MyClass myClass1 = new MyClass();
            myClass1.X();
            #endregion
            #region Indexer
            //Nesneye indexer özelliği kazandıran, fıtrat olarak property ile birebir aynı olan elemandır.
            #endregion
            #endregion
        }
    }
    class MyClass
    {
        //Property'le metot arasındaki farkalrdan bir taneside her property'nin bir türü olmalıdır.Ama metotlar bir geri dönüş türüne her zaman sahip olmayabilirler. Yani void olabilirler.
        #region Field
        int yasi;
        int yasi2;
        string b;
        #endregion
        #region Property
        #region Full Property
        //Property hangi türden bir field'ı temsil ediyorsa o türden olmalıdır...
        //Propertyler temsil ettikleri fieldlar'ın isimlerinin baş harfi büyük olacak şekilde isimlendirilir..
        public int Yasi
        {
            get
            {
                //Property üzerinden değer talep edildiğinde bu blok tetiklenir.
                //Yani değer buradan gönderilir.
                return yasi;
            }
            set
            {
                //Property üzerine değer gönderildiğinde bu blok tetiklenir.
                //Yani değer buradan alınır ve field'a atanır.
                //value keywordü Property'nin türü neyse o türe bürünür ve dışarıdan gelen değeri yakalar.
                yasi = value;
            }
        }
        #endregion
        #region Prop Property
        //readonly olabilir ama writeonly olamaz.
        //public int Yasi2
        //{
        //    get
        //    {
        //        return yasi2;
        //    }
        //    set
        //    {
        //        yasi2 = value;
        //    }
        //}
        public int Yasi2 { get; set; }//burada field tanımalmaya gerek yok arka planda compiler bunun adına bir field tanımlası yapar.
        #region Auto Property Initializers (C# 6.0)
        //Bir property'nin ilk değerini nesne ayağa kaldırılır kaldırılmaz verebiliriz.
        //Bu özellik sayesinde read only olan prop'lara hızlıca değer atanabilmektedir.
        public int Yasi3 { get; set; } = 15; //Oluşacak değerin/fieldın ilk değeri 15 olsun demek
        #endregion
        #endregion
        #region Ref Readonly Returns
        //ref readonly returns, bir sınıf(class) içerisindeki field'ı referansıyla döndürmemizi sağlayan ve bir yandan da bu değişkenin değerini read only yapan özelliktir.
        string adi = "Musa UYUMAZ";
        public ref readonly string Adi => ref adi; // bu şekilde field'ın değerine değil fieldın ta kendisine erişmiş olacağız.
        #endregion
        #region Computed(Hesaplanmış) Properties
        //İçerisinde türetilmiş bir bağıntı taşıyan property'lerdir.
        int s1 = 5;
        int s2 = 10;
        public int Topla
        {
            get
            {
                return s1 + s2;
            }
        }
        #endregion
        #region Expression-Bodied Property
        //Tanımlanan property'de Lambda Expression kullanmamızı sağlayan söz dizimidir.
        //Sadece readonly property'lerde kullanılır.
        public string Cinsiyet => "Erkek";
        #endregion
        #region Init Only Properties - Init Accessor (C# 9.0)
        //Init-Only Properties, nesnenin sadece ilk oluşturulma anında propertylerine değer atamaktadır.
        //Böylece iş kuralı gereği run time'da değeri değişmemesi gereken nesneler için bir önlem alınmaktadır.
        #endregion
        #endregion
        #region Metot
        public int X()
        {
            return 0;
        }
        #endregion
        #region Indexer
        public int this[int a]
        {
            get 
            {
                return a;
            }
            set 
            {
                a = value;
            }
        }
        #endregion
    }
    #region Full Property Example
    class Banka
    {
        int bakiye;
        string deger;
        string deger2;
        public int Bakiye //Write & Read Property
        {
            get
            {
                if (bakiye > 0)
                    return bakiye * 10 / 100;
                return 5;
            }
            set
            {
                if (value < 10)
                    bakiye = value;
                else
                    bakiye = value * 95 / 100;
            }
        }
        public string Deger //Readonly Property
        {
            get
            {
                return deger;
            }
            //set
            //{
            //    deger = value;
            //}
        }
        public string Deger2 //Writeonly Property
        {
            //get
            //{
            //    return deger;
            //}
            set
            {
                deger = value;
            }
        }
    }
    #endregion
}
