using System;

namespace Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Record'ı Anlayabilmek İçin Ön Hazırlık)(Init - Only Properties)
            //Herhangi bir nesnenin propertylerine ilk değerlerinin verilmesi ve sonraki süreçte bu değerlerin değiştirilmemesini garanti altına almamızı sağlayan Init - Only Properties özelliği gelmiştir
            //Bu özellik sayesinde nesnenin sadece ilk yaratılış anında propertylerine değer atanmakta ve böylece iş kuralları gereği runtime'da değeri değişmemesi gereken nesneler için ideal bir önlem alınmaktadır.
            //Init - Only properties developer açısından süreç esnasında değiştirilmemesi gereken property değerlerinin -yanlışlıkla- değiştirilmesinin önüne geçmekte ve böylece olası hata ve bug'lardan yazılımı arındırmaktadır.
            #region Only - Init Properties VS Getter - Only Properties
            //Bu ikisi arasındaki temel fark esasında Object Initializer işlevselliğinden kaynaklanmaktadır.
            #endregion
            MyClass my = new MyClass()
            {
                MyProperty = 25,
                A = 5
            };
            //my.MyProperty = 123;
            Console.WriteLine(my.MyProperty);

            #region Readonly Field'lar da Init Only Property Kullanımı Kritik

            #endregion
            #endregion
            #region Records Nedir?
            // Eğer ki tek bir property'de Sabitlik/Değişmemezlik/Salt okunurluk/Readonly'lik/Sadece okunabilirlik amaç ediniliyorsa Init-Only Properties özelliği kullanılır.
            //Eğer ki bir objeyi bütünsel olarak değişmez yapmak istiyorsak o zaman daha fazlasına ihtiyacımız olacaktır. İşte bu ihtiyaca istinaden Records türü geliştirilmiştir.
            //Record bir objenin topyekün olarak sabit/değişmez olarak kalmasını sağlamakta ve bu durumu güvence altına almaktadır.
            //Böylece bu obje artık değeri değişmeyeceğinden dolayı esasında objeden ziyade bir değer gözüyle bakılan bir yapıya dönüşmektedir.
            //Nesne ön plandaysa bu class, nesnenin değerleri ön plandaysa bu record'dur.
            #endregion
            #region Örnek
            MyRecord2 record1 = new MyRecord2() { MyProperty = 5 };
            MyRecord2 record2 = new MyRecord2() { MyProperty = 5 };

            Console.WriteLine(record1.Equals(record2));


            MyClass2 myClass1 = new MyClass2() { MyProperty = 5 };
            MyClass2 myClass2 = new MyClass2() { MyProperty = 5 };

            Console.WriteLine(myClass1.Equals(myClass2));
            #endregion
            #region Class Örnek 
            //MyClass3 myClass3 = new MyClass3 
            //{
            //    MyProperty1 = 5,
            //    MyProperty2 = 10,
            //};

            //MyClass3 myClass31 = new MyClass3
            //{
            //    MyProperty1 = myClass3.MyProperty1,
            //    MyProperty2 = 15
            //};
            //MyClass3 myClass32 = myClass3.With(24);
            #endregion
            #region Record Örnek
            MyRecord3 myRecord3 = new MyRecord3
            {
                MyProperty1 = 5,
                MyProperty2 = 10
            };
            MyRecord3 myRecord31 = myRecord3 with { MyProperty2 = 15 };
            #endregion
        }
    }
    record MyRecord2
    {
        public int MyProperty { get; init; }
        //public void X()
        //{

        //}
        //public MyRecord()
        //{

        //}
        //~MyRecord()
        //{

        //}
        //static MyRecord()
        //{

        //}
    }
    class MyClass2
    {
        public int MyProperty { get; set; }
    }
    class MyClass
    {
        readonly int a;
        public int A
        {
            get
            {
                return a;
            }
            init
            {
                a = value;
            }
        }
        public int MyProperty { get; init; } = 3;
    }


    record MyRecord3
    {
        public int MyProperty1 { get; init; }
        public int MyProperty2 { get; init; }
    }
    class MyClass3
    {
        public int MyProperty1 { get; init; }
        public int MyProperty2 { get; init; }
        public MyClass3 With(int property2)
        {
            return new MyClass3 
            { 
                MyProperty1 = this.MyProperty1,
                MyProperty2 = property2
            };
        }
    }
}
