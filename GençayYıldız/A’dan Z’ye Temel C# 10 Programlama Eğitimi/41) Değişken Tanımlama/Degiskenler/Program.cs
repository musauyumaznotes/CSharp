using System;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değişken Tanımlama/Oluşturma
            //int yas;
            //bool medeniHal;
            //string soyadi;

            #endregion
            #region RAM'in Yapısı

            #endregion
            #region Değişkenler RAM'de Nasıl Tutulur?
            //int yas;
            //string adi;
            //string soyadi;
            #endregion
            #region C# Kuralları
            #endregion
            #region Değişken Tanımlama Kuralları
            //1. Anlamlı isimlendirme
            //int yas;
            //2. Özel karakter olmamalı
            double stok_adedi;
            //3. Sayısal İfadeler
            int sayi1;
            int sayi2;
            //int 3sayi;
            //4. Bir scope içinde aynı isimde değişken TANIMLANAMAZ!!!

            #endregion
            #region Değişken İsimlerini @ Operatörüyle Tanımlama
            //string @x;
            //Değişken isimlerinde programatik keyword kullanılamaz! Eğer ki bir değişken isminde programatik olarak kullanılan bir keywordü vermek istiyorsanız eğer bunu @ operatörü ile ezebilir ve öylece verebilirsiniz

            //string @static;


            #endregion



            #region Tanımlanmış Değişkene Değer Atama
            //int x = 123;
            //string adi = "Musa";
            //string soyadi = "Uyumaz";
            //char basHarf = 'M';

            #endregion
            #region Tanımlandıktan Sonra Değer Atama
            //Dikkat
            //Bir değişkene atanan en son değer geçerlidir
            //int a = 5;
            //a = 15;
            //a = 20;

            //Tanımlanmış olan değişkene türüne uygun bir değer atılmalıdr

            #region Ornek 1
            int x;





            x = 15;
            #endregion
            #region Ornek 2
            int ac = 5;
            int b = 15;
            string c;

            c = "Hilmi";
            #endregion
            #region Ornek3
            int xa = 5;
            char y = 'a';
            bool p;
            decimal d = 3.14m;
            p = false;
            #endregion
            #endregion
            #region Değişkene Değer Atama Kuralları
            #region Metinsel
            string adSoyad = "Musa Uyumaz";
            #endregion
            #region Karakter
            char basHarf = 'M';
            #endregion
            #region Mantıksal
            bool medeniHal = false;
            #endregion
            #region Sayısal
            //int sayi = 3;
            //int sayi22 = 3000000;
            //byte sayi21 = 3;
            //byte y1 = 500;
            //int z = 9999999999;

            #region Küsüratlu/ Ondalıklı Türler
            float f = 3.14F;
            double do2 = 3.14;
            decimal de = 3.14M;
            #endregion
            #endregion
            #endregion
            #region (_a,_b) = (a,b) Tuple Türüyle Değer Atama
            //int a = 5;
            //int ba = 10;

            (int a, int b) c2 = (5,10);
            (int yas, string adi, bool medeniHal) kisi = (23,"Musa",false);
            //kisi.yas = 5;

            (int x, char y) z;

            z = (5, 'a');
            #endregion
            #region Literal Düzenlemeler(C# 7.0)
            //Kompleks sayısal ifadeleri _(Alt tire) ile düzenlememizi sağlayan özelliktir.
            //int sayi4 = 1_000_000;
            #endregion
            #region Değişken Türüne Uygun Default Değer Atama
            //default keywordü : içerisine verilen türün varsayılan değerini geri döndürür
            bool xav = default(bool); //false
            int y1 = default(int); //0
            string za = default(string); //null
            char ch = default(char); // \0

            //Main içerisinde oluşturulan değişkenlerin ilk değerlerini manuel atmaya özen gösteriniz.
            #endregion
            #region Default Literals
            bool x12 = default;
            decimal y2 = default;
            #endregion


           
            #region Tanımlanmış Değişkenin Değerini Okuma
            int xc = 5;
            //Bir değişkenin ismini elde edebilmek için değişkenin adından faydalanmaktayız.
            //Bir değişkenin adı assign(=) operatörünün sağında yahut metotların parametrelerinde çağrılıyorsa ilgili değişkein değeri gönderilir.
            Console.WriteLine(xc);
            int ya = xc;
            #region Kritik 1
            int a2 = 5;
            int b2 = 10;
            int c1 = b2;
            int d2 = a2;
            b2 = a2;
            c1 = b2;
            #endregion
            #region Kritik 2
            int abc = 5;
            abc = abc;
            #endregion

            #endregion
            #region Değeri Olmayan Değişkenler!
            //Class içerisinde tanımlanan değişkenlerde varsayılan deger otomatik atanmaktadır.Lakin main içerisinde tanımlanan değişkenler de varsayılan değer atanmadığı için böyle boş tanımlanan değişkenlerde ilk değeri manuel vermediğimiz sürece işlem yapamayız!

            //Bir metot içerisinde tanımlanan değişkenlerin ilk değerlerini manuel olarak vermeyi alışkanlık haline getiriniz... Çünkü programın rahatça işlenebilir ve kodlanabilir olması için
            int h;
            //Console.WriteLine(h);
            //int k = h;
            #endregion



            #region Değişken Davranışları Genel Bakış(ref için farkındalık) 

            #endregion



            #region Scope Nedir?
            //Faaliyet Alanı
            //Kapsam
            //Değişken ve fonksiyonların erişilebilirlik sınırlarını belirleyen alandır.
            //Tanımlamalarda ve algoritmik çalışmalarda karışıklılığı önleyen bir sınır çizer.
            //C# : Süslü Parantez { }

            #endregion
            #region Değişkenin Faaliyet Alanı Nedir?
            //Bir değişken sade ve sadece tanımlandığı scope içerisinden erişilebilir ve kullanılabilir
            #endregion
            #region Custom Scope Oluşturmak?
            //{
            //    {
            //        {
            //            {

            //            }
            //        }
            //    }
            //}
           
            {
                int a = 5;
                {
                    
                }
            }
            {
                int a= 7;
            }
            #endregion


            #region Sabitler
            const double pi = 3.14;
            //const değişkenler tanımlama aşamasında değerlerini isterler...
            //Aksi taktirde hata alınır.

            //pi = 123;
            #endregion
        }
    }
}
