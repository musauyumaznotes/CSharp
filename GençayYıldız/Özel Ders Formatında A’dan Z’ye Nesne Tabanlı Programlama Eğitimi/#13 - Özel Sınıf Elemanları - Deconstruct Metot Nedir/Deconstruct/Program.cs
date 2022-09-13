using System;

namespace Deconstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Deconstruct Metodu Nedir?
            //Bir sınıf içerisinde deconstruct ismiyle tanımlanan metot compiler tarafından özel olarak algılanmakta ve sınıfın nesnesi üzerinden geriye hızlıca Tuple bir değer döndürmemizi sağlamaktadır.
            //Bir sınıfınız olduğunu düşünün bu sınıftan ürettiğiniz bir tane nesne oldğunu varsayın.Şimdi bu nesnenin içerisinde onlarca property'niz olabilir. bu propertylerden belli başlı olanları ihtiyacınıza istinaden belli başlı olanları hızlıca özet bir analiz mahiyetinde elde etmek istiyor olabilirsiniz işte bu ihtiyaca istinaden size bu nesnenin ilgili propertylerini hızlı bir şekilde belirli bir semantikle verebilcek ve bunu tuple olarak verebilcek bir özelliktir.
            #endregion


            Person person = new Person
            {
                Name ="Musa",
                Age = 23
            };
            var (x, y) = person;
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out string name,out int age)
        {
            name = Name;
            age = Age;
        }
    }
}
