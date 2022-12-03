using System;

namespace Inheritance3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bir Nesnedeki ToString, Equals, GethashCode, GetType Metotları Nereden Gelmektedir? 
            MyClass myClass = new MyClass();

            #endregion
            #region Nesnelerin Atası/Ademi Object Türü
            //C# programlama dilinde tüm sınıflar Object sınıfından türetilir  
            //Bir sınıf oluşturduğunda bir sınıftan türese de türemese de bu sınıf object sınıfından türeyecektir. Yani compiler seviyesinde otomatik olarak default olarak object sınıfından türetilecektir.
            //object her şeyi kapsayan bütün değerleri kapsayabilen bir özellik olmasının altında yatan sebep tüm değerlerin Object'ten türemesidir.
            //Eğer ki tanımlanan sınıf herahngi bir kalıtım almıyorsa default olarak Object sınıfından türetilecektir. Yok eğer herhangi bir sınıftan kalıtım alıyorsa bir sınıfın aynı anda birden fazla sınıftan kalıtım alamama prensibinden yola çıkarak bir yandan da Object sınıfından türemeyecek sadece kalıtım aldığı sınıftan türeyecektir. ama yine dolaulı yoldan Object sınıfından türemiş olacaktır Object sınıfı atası olmuş olacaktır.
            //En nihayetinde bir sınıf öyle ya da böyle Object sınıfından kalıtım alacaktır.
            #endregion
            #region Object Sınıfı Memberları

            #endregion
            #region İsim Saklama(Name Hiding) Sorunsalı
            //Kalıtım durumlarında atalardaki herhangi bir member ile aynı isimde member'a sahip olan nesneler olabilmektedir.
            //Bu şekilde aynı isme sahip olan memberlar için base'deki member saklanır.

            D d = new D();
            #endregion
            #region Record'lar da Kalıtım
            //Recorlar sade ve sadece Record'lardan kalıtım alabilmektedirler.
            //Class'lardan kalıtım alamazlar yahut veremezler!
            //Kalıtımın tüm temel kuralları record'lar için geçerlidir.
            //Bir record aynı anda birden fazla record'dan kalıtım alamaz!
            //Record'larda temelde class oldukları için üretilir üretilmez otomatik olarak Object'ten türerler
            //base ve this keyword'leri aynı amaçla kullanılabilmektedir
            //Name Hiding söz konusu olabilmektedir.
            #endregion
        }
    }
    #region Örnek 1
    class MyClass
    {

    }
    #endregion
    #region Örnek 2
    class A
    {
        public void X()
        {

        }
    }
    class B : A
    {

    }
    class C : B
    {

    }
    class D : C
    {
        public new void X()
        {

        }
    }
    #endregion
}
