using System;

namespace oop_sinif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass();
            MyClass.MyClass2 m2 = new MyClass.MyClass2();
            #region Class İçerisinde Tanımlanan Class Sınıf Elemanı mıdır?
            //Bir class'ın içinde bulunan classlar(nested class) Class'ın elemanı olamaz.
            #endregion

            #region Class Elemanlarına Açıklama Satırı Nasıl Eklenir?
            Random random = new Random();
            MyClass myClass = new MyClass();
            //Sınıflarıma ve elemanlarına açıklamalar ekleyebiliriz.Bizim sınıfın referansını kullanan herkes bu açıklamalara erişebilir. Bizler bunun için 3 adet (///) slash kullanırız.
            //Açıklama satırlarını ne amaçla kullanırız ? : Bizim kendi adımıza yazdığımız kodları daha sonraki süreçlerde geriye dönük baktığımızda daha hızlı kavrayabilmek bu kodu ne amaçla yazdığımızı anlayabilmemiz için oluşturulması gereken notlardır. Nihayetinde kodun izahiyetini/açıklamamızı yapmamızı sağlayan yapılardır.
            //Kendi yazdığın kodlar için kendine hatırlatıcı bir unsur olacaktır hem de asıl önemlisi olan senin dışında senden sonra göreve devam edecek olan ya da sisteme daha sonradan dahil olacak olan herhangi bir developer'ın ne olduğuna dair bu kodun açıklanması sistemdeki kodların ne olduğuna dair hızlıca anlamasını sağlayacak bir dökğmantasyon görevi gören yapılardır.
            #endregion
        }
    }
    /// <summary>
    /// Bu bir örnek classtır
    /// </summary>
    class MyClass
    {
        int a;
        /// <summary>
        /// Bu bir property'dir
        /// </summary>
        public int MyProperty { get; set; }
        /// <summary>
        /// Bu bir metottur
        /// </summary>
        public void X() { }
        /// <summary>
        /// Bu bir örnek metot overloadıdır.
        /// </summary>
        /// <param name="a">a parametresi...</param>
        public void X(int a) { }
        public int this[int a]
        {
            get { return 0; }
        }
        public class MyClass2
        {

        }
    }
}
