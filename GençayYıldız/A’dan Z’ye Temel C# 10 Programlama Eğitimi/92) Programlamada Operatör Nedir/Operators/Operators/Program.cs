using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aritmetik Operatörler
            // + 
            // - 
            // * 
            // /
            // %
            #region Aritmetik Operatörlerde Geriye Dönüş Değeri
            //Aritmetik operatörler, iki sayısal değer üzerinde işlem yapan operatörler oldukları için işlem neticesinde geriye "uygun türde" sonuç dönerler.


            #region İnceleme 1
            //int sonuc = 3 + 5;
            #endregion
            #region İnceleme 2
            //int x = 3 , y= 5;
            ////int y = 5;
            //int sonuc = x * y;
            #endregion
            //Aynı türde olan sayısal değer üzerinde işlem yaparken sonuç türü aynı olacaktır
            #region İnceleme 3

            //double s1 = 123;
            //double s2 = 321;
            //double sonuc = s1 + s2;
            #endregion
            #region İnceleme 4
            //decimal s1 = 123123;
            //decimal s2 = 3214532;
            //decimal sonuc = s1 % s2;
            #endregion
            #endregion
            #region (int) * (int) = ?

            #endregion
            #region (int) * (double) = ?
            //iki farklı türde sayısal değer üzerinde yapılan aritmetik işlem neticesinde sonuç büyük olan türde dönecektir.
            //Aritmetik operatörler küçük olan tür büyük olan türe bilinçsiz bir şekilde dönüştürülerek o şekilde hesap yapılır...O yüzden sonuç büyük olan türde elde edilecektir/edilmektedir...
            //int s1 = 10;
            //double s2 = 5;
            //double sonuc = s1 + s2;
            #endregion
            #region (byte) * (int) = ?
            //int s1 = 3;
            //byte s2 = 123;
            //int sonuc = s1 - s2;
            #endregion
            #region (byte) * (byte) = ? (İstisna! - Mülakat!!!)
            //Normalde iki aynı türdeki sayıosal değer üzerinde yapılan aritmetik işlem neticesinde sonuç aynı türde dönecekken bu iki değer byte ise sonuç her daim int dönecektir.
            //Böyle kabul edilmiştir....
            //İstisnadır...
            //byte s1 = 10;
            //byte s2 = 5;
            //int sonuc = s1 - s2;
            #endregion
            #region Matematiksel İşlemler(Öncelik Sırası)

            #endregion
            #endregion
            #region Karşılaştırma Operatörleri
            //İki sayısal değer arasında büyüklük, küçüklük ve eşitlik durumuna göre karşılaştırma yapan operatörlerdir.
            // <(küçüklük)
            // >(büyüklük)
            // <=(küçük veya eşitlik)
            // >=(büyük veya eşitlik)
            // ==(eşitlik)
            #region Karşılaştırma Operatörlerinin Geriye Dönüş Değerleri
            //Karşılaştırma operatörleri geriye her daim bool türde bir değer döndürecektir.
            //int i1 = 123;
            //int i2 = 321;
            //i1 > i2;
            #endregion
            #endregion 
            #region Mantıksal Operatörler
            //Tüm şartları değerlendirip, kendine göre sonuç döndüren operatörlerdir.
            #region ve &&
            //ve(&&) operatörü, tümmm şartların yerine getirilmiş olmasını isterrr
            //Patates ve köfte
            //  true  && true
            #endregion
            #region veya ||
            //veya(||),şartlardan ennn az bir tanesinin yerine getirilmiş olması yeterlidir.
            //Patates veya köfte
            //true/false || true/false
            #endregion
            #region ya da ^
            // ya da(^) operatörü, şartlardan kesinlikle bir tanesinin yerine getirilmesini isterr... 
            #endregion

            #region Mantıksal Operatörlerin Kullanım Mantığı
            bool patetes = true, kofte = false;
            bool sonuc1 = patetes && kofte;
            bool sonuc2 = patetes || kofte;
            bool sonuc3 = patetes ^ kofte;

            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);

            //Mantıksal operatörlergeriye bool/mantıksal sonuçlar dönerler...
            #endregion
            #region Mantıksal Operatörlerin Geriye Dönüş Değeri
            ////ve 
            //Console.WriteLine(true  && true); //true
            //Console.WriteLine(true  && false);//false
            //Console.WriteLine(false && false);//false
            //Console.WriteLine(false && true);//false

            ////veya
            //Console.WriteLine(true  || true); //true
            //Console.WriteLine(true  || false);//true
            //Console.WriteLine(false || false);//false
            //Console.WriteLine(false || true);//true

            ////ya da
            //Console.WriteLine(true  ^ true); //false
            //Console.WriteLine(true  ^ false);//true
            //Console.WriteLine(false ^ false);//false
            //Console.WriteLine(false ^ true);//true
            ////SHIFT + 3 SPACE 
            #endregion
            #region Örnek
            Console.WriteLine(((true && true) || false && ((true ^ false) && false) || true));
            #endregion

            #endregion
            #region Arttırma Azaltma Operatörleri
            #region Örnek 1
            // ++ 
            int i = 5;
            //i++;
            //++i;
            //Console.WriteLine(i);

            Console.WriteLine(i++);// Çıktı : 5 | Bellek : 6
            Console.WriteLine(++i);// Çıktı : 7 | Bellek : 7

            //++i;
            // --
            #endregion
            #region Örnek 2
            //int a = 5;
            //int b = a++;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion
            #region Örnek 3
            //int i1 = 5;
            //int i2 = ++i1;// i1 = 6 i2 = 6
            //int i3 = i1;// i3 = 6
            //i2 = ++i2; //i2 = 7
            //++i2;
            //Console.WriteLine(i1);//6
            //Console.WriteLine(i2);//7
            //Console.WriteLine(i3);//6
            #endregion
            //int z = 5;
            //Console.WriteLine("z : " + z++);
            //Console.WriteLine("z : " + ++z);
            #endregion
            #region Üzerine Ekleme Yığma Operatörleri
            // +=
            // -=
            // *=
            // /=
            // %=

            #endregion
            #region Metinsel İfadelerde Operatörler
            #region + Operatörü
            //Metinsel ifadeler + operatörüyle yanyana birleştirilebilirler
            //int a = 5, b = 3;
            //Console.WriteLine(a + b);

            //string a = "Ahmet", b = "Mehmet";
            //Console.WriteLine(a + b);

            //int a = 5;
            //string b = "abc";

            //a + b;//Elimizde bulunan değeri Boxing olarak dönüşüm yapar.
            #endregion
            #region += Operatörü
            //string a = "Ahmet";
            //string b = "mehmet";
            //a = a + b;
            //a += b;
            #endregion
            #region == Operatörü
            //string a = "Ahmet";
            //string b = "Mehmet";

            //bool sonuc = a == b;

            ////a.Length > b.Length
            //bool sonuc21 = a != b;
            #endregion
            #endregion
            #region ! Operatörü
            ////Manevratik bir operasyon sağlar.
            ////Değil Olumsuzluk!
            ////Console.WriteLine(!true);
            //int i1 = 3;
            //int i2 = 5;
            ////Console.WriteLine(i1 != i2);
            //Console.WriteLine(!(i1 == i2));
            #endregion
            #region Ternary Operatörü
            ////Şarta bağlı değer döndüren operatördür.
            ////Bir değişkene/metoda/peroperty'e değer atarken, eğier ki bu deüer şarta göre fark edecekse satır bazlı/tek satırda bu şart kontrolünü yaparak duruma göre değeri döndürmemizi sağlayan bir kalıpsal operatördür.
            //bool medeniHal = false;
            //string mesaj = medeniHal == true ? "Evlilere Kampanya...." : "Bekarlara Kampanya....";
            //Console.WriteLine(mesaj);
            #region Birden Fazla Condition Uygulamak
            //int yas = 25;
            ////Yaşı; 25'den küçük olanlara A, 25 olanlara B ve 25'den büyük olanlara C dweğerini döndüren ternary operatörünü oluşturalım
            //string sonuc = yas < 25 ? "A" : (yas == 25 ? "B" : "C");
            //Console.WriteLine(sonuc);
            #endregion
            #region Örnek 1
            //Kullanıcı tarafından girilen sayının aşağıdaki önergelere göre hesabını gerçekleştiren kodu geliştiriniz.
            // sayı < 3                   => sayı * 5
            // sayı > 3 && sayı < 9       => sayı * 3
            // sayı >= 9 && sayi % 2 == 0 => sayı * 10
            //sayi % 2 == 1               => sayı
            // hiçbiri değilse            => -1
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            //int _sayi = int.Parse(sayi);
            int sonuc = sayi < 3 ? sayi * 5 :
                (sayi > 3 && sayi < 9 ? sayi * 3 :
                (sayi >= 9 && sayi % 2 == 0 ? sayi * 10 :
                (sayi % 2 == 1 ? sayi : -1)));
            Console.WriteLine(sonuc);
            #endregion
            #region Örnek 2
            //Hava durumunu tutan string değişkenin değerine göre aşağıdaki önergelleri uygulayan programı yazınız.
            // "Yağmurlu" => "Şemsiye Almalısın"
            // "Güneşli"  => "Bol bol d vitamini alman dileğiyle..."
            // "Kapalı"   => "Yağmur Yağabilir"
            string havaDurumu = "Yağmurlu";
            string deger = havaDurumu == "Yağmurlu" ? "Şemsiye Almalısın" : (havaDurumu == "Güneşli" ? "Bol bol d vitamini alman dileğiyle..." : "Yağmur Yağabilir");
            Console.WriteLine(deger);
            #endregion
            #endregion
            #region Atama(Assign) Operatörü
            //sol taraftaki değişken kısmına sağ taraftaki değeri atamamızı sağlayan bir operatördür
            int a = 5;
            #endregion
            #region .(Member Access - üye Erişim) Operatörü  
            //Elimizdeki değerlerin türleri alt elemanlara sahiptir. 
            //Bir türün altında erişebildiğiniz property/metot/fieldlardır.
            //Member access, elimizdeki bir değerin türüne uygun elemanlarını/fonksiyonlarını/metotlarını/propertylerini/fieldlarını erişmemizi/çalıştırmamızı/çağırmamızı sağlayan operatördür.
            //member access kodun devamını getirir.
            int i4 = 5;
            Console.WriteLine(i4.ToString());
            #endregion
            #region Cast Operatörü 
            //Genellikle tür dönüşümlerinde kullanılan bir operatördür
            //1. Boxing -> UnBoxing
            //object x = 123;
            //int x2 = (int)x;
            //2. Bilinçli Tür Dönüşümü
            //int a2 = 5;
            //short b = (short)a;
            //3. Char -> int | int -> char (ASCII)
            //int ascii = 93;
            //char c = (char)ascii;

            //****İleride polimorfizm durumunda base class referansıyla işaretlenen bir nesneyi kendi türünde de elde edebilmemizi sağlamaktadır.
            #endregion
            #region sizeof Operatörü
            //Verilen türün bellekte kaç byte'lık yer kapladığını integer olarak geriye döndürür
            //Console.WriteLine("int : " + sizeof(int));
            //Console.WriteLine("short : " + sizeof(short));
            //Console.WriteLine("byte : " + sizeof(byte));
            //Console.WriteLine("long : " + sizeof(long));
            //Console.WriteLine("decimal : " + sizeof(decimal));
            //Console.WriteLine("char : " + sizeof(char));
            //Console.WriteLine("bool : " + sizeof(bool));

            #endregion
            #region typeof Operatörü
            //typeof operatörü verilen türün /değerin type'ını/türünü getirir
            //O tür ile ilgili bilgileri edinmek için kullanılan bir operatördür.
            //İleride(ileri düzey programlamada) reflection dediğimiz bir konuda elimizdeki bir türün reflectionına girmek için kullandığını göreceğiz.
            //Type t = typeof(int); //int türüne ait tüm bilgiler burada t değişkenine atanmıştır.
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.IsPrimitive);
            //Console.WriteLine(t.IsClass);
            //Console.WriteLine(t.IsValueType);
            #endregion
            #region default Operatörü
            //Belirtilen türün default değerini döndüren operaatördür...
            //Default deger ne demektir? Dewfault değerler, her tür için yazılım tarafında tanımlanmış bir varsayılan değer demektir.   
            //sayisal = 0
            //bool = false
            //string = null
            //char = \0
            //referans = null

            //Console.WriteLine(default(decimal));
            //Console.WriteLine(default(string));
            //Console.WriteLine(default(Program));
            //Console.WriteLine(default(short));
            //Console.WriteLine(default(byte));

            //int a5 = default;
            //int a55 = default(int);
            #endregion
            #region is Operatörü
            //// Boxing'e tabi tutulmuş bir değerin öz türünü öğrenebilmek/check edebilmek/kontrol edebilmek için kullanılan bir operatördür.
            ////is operatörü denetleme neticesinde durumu bool yani true ya da false olarak döndürecektir.
            //object x = true;//Boxing
            //Console.WriteLine(x is bool);
            //Console.WriteLine(x is int);
            //Console.WriteLine(x is Program);

            ////İleride if yapılamasında vs çok tercih ettiğimiz bir operatör olacaktır. 
            ////OOP yapılanmasında polimorfizm is operatörüyle kalıtımsal durumlardaki nesnelerin türlerinide öğrenebileceğiz...
            #endregion
            #region is null Operatörü
            //Bir değişkenin değerinin null olup olmamasını kontrol eden ve sonuç olarak geriye bool türde bir değer döndüren operatördür.
            //string a2 = null;
            //Console.WriteLine(a2 is null);
            //is null operatörünü sadece null olabilen türlerde kullanabilmekteyiz.
            //int b = 123;
            //Console.WriteLine(b is null);
            #endregion
            #region is not null Operatörü
            ////Elimizdeki değerin null olup olmamasıyla ilgilenmekte ve geriye bool sonuç döndürmektedir.
            //string a5 = "asfasfafafas";
            //Console.WriteLine(a5 is not null);
            ////Sadece null alabilen türlerde kullanılabilir...
            #endregion
            #region as Operatörü
            ////Cast operatörünün UnBoxing işlemine alternatif olarak üretilmiş bir operatördür...
            #region Cast Örneklendirmesi
            ////object x = "Ahmet";
            ////int x2 = (int)x;
            ////Console.WriteLine(x2);
            #endregion
            //object x = "Ahmet";
            //Program y = x as Program;
            //Console.WriteLine(y);
            #endregion
            #region ?(Nullable) Operatörü
            //C# programlama dilinde değer türlü değişkenler normal şartlarda null değer alamazlar(Not nullable)
            //Bir değer türlü değişkenin null değer alabilmesi için (yani nullable olabilmesi için) ? operatörünün kullanılması gerekmektedir.
            int? a2 = null;//Değer türlü değişkenden ziyade referans türlü değişken gibi hareket edecek ve null değerlerini karşılayabilecek
            bool? b3 = null;

            Console.WriteLine(a2 is null);

            // Bir değer türü değişken nullable yapıldıysa eğer; is null, is not null,as gibi null ile çalışan operatörleri üzerinde kullanabiliriz.

            #region as Örneklendirme
            object x = 123;
            int? y = x as int?;
            #endregion
            #endregion
            #region ??(Null-Coalescing) Operatörü
            //Elimizdeki değişkenin değerinin null olma durumuna istinaden farklı bir değeri göndermemizi sağlayan operatördür.
            string a56 = "null";
            Console.WriteLine(a56 ?? "Merhaba");
            //Sol ve sağdaki türler birebir aynı olmalıdır. Aksi taktirde derleyici hata verecektir.
            #endregion
            #region ??= Operatörü (Null-Coalescing Assignment) (C# 8.0)
            string x2 = null;
            Console.WriteLine(x ??= "Merhaba");

            int? id = null;
            id ??= 1;//id null ise 1 değerini ata, yok eğer değilse değerini koru...
            #endregion
        }
    }
}
