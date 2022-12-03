using System;

namespace Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metinsel İfadelerin Diğer İfadelere Dönüştürülmesi
            //Tür dönüşümlerinde dikkat edilmesi gereken tek bir husus vardır ki, o da ; dönüşüm yapılacak verinin türüne uygun bir hedef tür belirlenmelidir.
            #region Parse Metodu
            //Parse metodu sadece string dataları hedef türe dönüştürürken kullanılır!
            #region Örnek 1
            //string x = "123";
            ////Console.WriteLine(x * 5);
            //short x2 = short.Parse(x);
            //Console.WriteLine(x2 * 5);
            ////Console.WriteLine(short.Parse(x) * 5);
            #endregion
            #region Örnek 2 
            //Tür HATALI
            //string a = "Ahmet";
            //int a2 = int.Parse(a);
            //Console.WriteLine(a2);
            #endregion
            #region Örnek 3
            //string medeniHal = "Evli";
            //bool medeniHal2 = bool.Parse(medeniHal);
            //Console.WriteLine(medeniHal2);

            #endregion
            #region Örnek 4
            //string x = "a";
            //char x2 = char.Parse(x);

            #endregion
            #endregion
            #region Convert Fonksiyonları
            #region Örnek 1
            string x = "25";
            int x2 = Convert.ToInt32(x);
            #endregion
            #region Örnek 2
            string y = "3,14";
            double d = Convert.ToDouble(y);
            Console.WriteLine(d * 5);
            #endregion
            #endregion
            #endregion
            #region Diğer İfadelerin Metinsel İfadelere Dönüştürülmesi
            #region Convert Fonksiyonu
            int a = 25;
            string a2 = Convert.ToString(a);
            #endregion
            #region ToString Fonksiyonu  
            //Genellikle diğer türleri biz metinsel türe dönüştürürüz bu yüzden bu metodu ortaya çıkarmışlar.
            //ToString fonksiyonu tüüümmmm ama tüm türlerde mevcuttur.
            float f = 35;
            string f2 = f.ToString();
            #endregion
            #endregion
            #region Sayısal İfadelerin Kendi Aralarında Dönüşümü
            #region Bilinçsiz Tür Dönüşümü
            //Bir sayısal türün kendisinden daha geniş aralıktaki bir başka sayısal türe atanması bilinçsiz tür dönüşümüdür.
            //Burada dönüşümü Compiler üstlenir.
            #region Örnek 1
            int g = 3000;
            float h = g;
            #endregion
            #region Örnek 2
            short s = 123;
            long l = s;
            #endregion
            #endregion
            #region Bilinçli Tür Dönüşümü
            //Kendi irademizle yani compiler karar vermeyi bize bıraktığı tür dönüşüm tipidir.Cast operatörüyle birlikte yapılır
            int n = 60000;
            byte r = (byte)n;
            Console.WriteLine(r);

            #region Checked
            //Bilinçli Tür Dönüşümü yapılırken eğer ki veri kaybı söz konusuysa runtime'da hata fırlatılmasını sağlar
            //Bilinçli tür dönüşümü esnasında bir veri kaybı söz konusu olursa eğer runtime'da bizleri uyaracak olan bir kontrol mekanizmasıdır
            checked
            {
                //int c = 500;
                //byte t = (byte)c;
                //Console.WriteLine(t);
            }
            #endregion
            #region UnChecked
            //Bilinçli tür dönüşümü sırasında veri kaybı söz konusuysa eğer bunu görmezden gelir ve runtime'da hata vermez
            //Normal bir kod bloğu default olarak unchecked'tir
            unchecked
            {
                int yhg = 500;
                byte nm = (byte)yhg;
                Console.WriteLine(nm);
            }
            #endregion
            #endregion
            #region Kritik Mülakat 
            int abc = 3000;
            short ss = (byte)abc; // Burada ilk olarak int tipindeki abc değişkeni (byte) ile bilinçli tür dönüşümü yapılarak byte türüne dönüştürülmüştür.Daha sonra bu byte türündeki değer tekrardan bilinçsiz tür dönüşümüyle short'a çevrilmiştir.

            #endregion
            #endregion
            #region bool Türünün Sayısal Türe Dönüştürülmesi
            //Elimizdeki mantıksal bir değeri herhangi bir sayısal değere Convert edersek ilgili değerin mantıksal karşılığını elde edebiliriz...
            bool boo = true;
            decimal i = Convert.ToDecimal(boo);
            Console.WriteLine(i);
            #endregion
            #region Sayısal Türlerin bool Türüne Dönüştürülmesi
            //Tür dönüşümleinde dönüştürülecek türün hedef türe uygun olması gerekiyordu.
            //Burada istisna var
            //normal de;
            //1 -> true
            //0 -> false
            //eşit olması ve geri kalanının mümkün olmaması gerekmektedir. Halbuki burada 0'ın dışındaki tümmm değerler true olarak kabul edilmesi istisnadır
            int i1= -123;
            bool b2 = Convert.ToBoolean(i1);
            Console.WriteLine(b2);
            #endregion
            #region char Türünün Sayısal Türe Dönüştürülmesi
            //Bilgisayarınızda bulunan her bir karakterin arka planda bir tamsayı karşılığı vardır.
            //Bilgisayardaki her bir karakterin sayısal bir karşılığı vardır. Bu sayısal değerlere ASCII kaynak kodu denmektedir.
            //char --> int (cast edilirse ASCII kodu)
            //Tüm sayı tiplerinde dönüşüm gerçekleştirilebilir.
            char krkter = 'a';
            int _a = (int)krkter;
            Console.WriteLine(_a);
            #endregion
            #region Sayısal Türlerin char Türüne Dönüştürülmesi
            //Elinizdeki herhangi bir tam sayısal değeri char'a cast ederseniz ASCII karşılığı olan karakteri sizlere getirecektir 
            int oascii = 111;
            int Oascii = 79;

            Console.WriteLine((char)oascii);
            Console.WriteLine((char)Oascii);
            #endregion
        }
    }
}
