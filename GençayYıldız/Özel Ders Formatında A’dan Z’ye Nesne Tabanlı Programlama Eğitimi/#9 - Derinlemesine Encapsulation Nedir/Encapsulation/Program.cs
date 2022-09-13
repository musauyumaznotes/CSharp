using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation nedir? Bir Veriyi Neden Kapsülleriz?
            //Encapsulation, nesnelerimizde ki field'ların kontrollü bir şekilde dışarıya açılmasıdır.
            //Bir başka deyişle, nesnelerimizi başkalarının yanlış kullanımlarından korumak için kontrolsüz değişime kapatmaktır.
            //Nihayetinde ben bir nesne oluşturuyorum oluşturmuş olduğum nesneyi dışarıdan kullancak bir adam tarafından benim dışında yanlış kullanılmasını istemiyorsam eğer ilgili nesnenin fieldlarını kapsüllemem lazım.
            //Encapsulation dediğimiz yapılanma fieldların kontrolünü sağlamaktır.

            //Encapsulation ise tam tersi. Encapsulation, motor üreticilerinin onu kaporta ve motor kapakları ile koruma içgüdüsüdür. Encapsulation evlerimizde ki kapı ve perdelerdir. Encapsulation beynimizi çevreleyen kafatasıdır. Encapsulation, sınıfımızı başkalarının yanlış kullanımlarımdan korumak için kontrolsüz değişime kapamaktır. Sınıfımızın içeriğini deterministic tutabilmek için koruruz onu. 
            #endregion
            #region Encapsulation Nasıl Uygulanır?
            #region Metot İle Encapsulation
            #region Eskiden Encapsulation
            MyClass m = new MyClass();
            m.ASet(15);
            Console.WriteLine(m.AGet());
            #endregion
            #endregion
            #region Property İle Encapsulation
            m.A = 1412214;
            Console.WriteLine(m.A);
            #endregion

            #endregion
            #region This'e dair Genel Kültür

            #endregion
        }
    }
    class MyClass
    {
        int a;
        #region Eskiden Encapsulation Nasıl Yapılıyordu
        public int AGet()//Bu fonksiyon tetiklendiğinde o anki nesnedeki a field'ının değerini geri gönder
        {
            return this.a;
        } //Dış dünyaya açmak istediğin field'ın neyse o türde çalışmalısın 
        public void ASet(int value)
        {
            this.a = value;
        }
        #endregion
       

        public int A
        {
            get { return a; }
            set { a = value; }
        }

    }
}
