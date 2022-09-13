using System;

namespace oop_sinif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region this Keywordü
            //Bir sınıftan oluşturduğum nesneyi sınıfın modellemesi esnasında temsil etmemi sağlayan keyword this keywordüdür.
            //Modelleme de oluşturulan this keywordü her oluşturulan nesne için geçerlidir! benim yorumum
              //O anki nesne neyse bu oluşturulmuş olan tüm nesnelerin her birini nesne üzerinde daha doğrusu nesne modellemesi üstünde temsil etmeni sağlayan keyword this keyword'üdür.
            //static yapılanmalarda this keywordune erişemeyiz
            #region 1. Sınıfın Nesnesini Temsil Eder
            //Genellikle bu amaçla kullanılır
            MyClass m1 = new MyClass();
            MyClass m2 = new MyClass();
            #endregion
            #region 2. Aynı İsimde Field İle Metot Parametrelerini Ayırmak İçin Kullanılır
            //eğer bir field ismi ile bir metot parametresinin ismi aynı olursa biz o anki nesnenin temsilcisi olan this'e gidip oradan field'a erişiriz
            //this keywordü ilgili class yapılanmasının o anki nesnesine karşılık gelir.
            //this kullanmak zorunda değiliz sen burada this kullansanda kullanmasanda compiler seviyesinde otomatik olarak this kullanılmaktadır.
            #endregion
            #region 3. Bir Constructer'dan Başka bir Constructer'ı Çağırmak İçin Kullanılır

            #endregion
            #endregion
        }
    }
    class MyClass
    {
        int a;
        public void X(int a)
        {
            //bir fieldla aynı isimde parametre olsa bile yakın olana yani metot parametresine erişim sağlar...
            this.a = a;
            //this.X();
        }
    }
}
