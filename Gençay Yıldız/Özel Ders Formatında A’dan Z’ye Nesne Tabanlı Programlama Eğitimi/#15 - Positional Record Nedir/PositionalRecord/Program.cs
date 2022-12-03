using System;

namespace PositionalRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Positional Record
            //Aynı şekilde nesnenin birebir ta kendisi olan sadece davranışsal olarak datasını ön planda tutan Record denilen yapılanmaların da kendine has var olan özel memberları özel bir semantikle kullanabilmemizi sağlayan yapılardır.
            //Norminal Record'lar Object Initializer'lar ile ilk değerleri verilerek üretilebilen readonly datalardı
            //Positional Record'lar ise esasında Record'lar içerisinde tanımlama yapabildiğimiz constructor ve deconstructor kullanımlarını daha da özelleştirerek kullanılmasını sağlamaktadır.
            //Positional Record kullanırken parametrelerin karşılıkları olan propertyleri manuel oluşturmak zorunda DEĞİLİZ...
            //Positional Record tanımlanmışsa eğer nesne üretiminde tetiklenmesi/kullanılması zorunludur.
            #endregion
            MyRecord m = new MyRecord("sgagfag","adfafasf");
            var (n, s) = m;
        }
    }
    record MyRecord(string Name,string Surname)
    {
        public MyRecord() : this("agfagagaswg","afagfawfgawfwa")
        {

        }
        public MyRecord(string name): this()
        {

        }
        //public string Name => name;
        //public string Surname => surname;
    }
}
