using System;

namespace akis_kontrol_yapilanmalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch Case
            //Switch case, kodun akışında belirli bir şarta göre yönlendirme yapmamaızı(farklı algoritma çalıştırmamızı/farklı operasyon gerçekleştirmemizi/tetiklememizi) sağlayan yapılanmadır. 
            //Switch case yapılanamsı sadece bir değişkenin değerini sadece eşitlik durumlarını kontrol ederken kullanılabilir.
            //Sadece eşitlik durumu check edilecekse o zaman switch kullanılabilir..
            //Kontrol edilen değerin türü ne ise case bloklarınad da aynı türde değerlerle kontrol edilmelidir...
            //Switch parantezinde kontrol edilen değer bir değişken yahut sabit/statik bir değer olabilirken case bloklarında değerler kesinlikle sabit/statik olmak zorundadır. Caselerdeki değerler değişkenlerden alinamaz.
            //Default case bloklarından hiçbiri eşleştirmeye uymuyorsa eğer varsa default bloğu tetiklenir...
            //Eşitlik sağlandığı zaman durumda diğer caselere bakmadan switch bloğundan çıkıp gidecektir....(compiler)
            //Amaç şarta göre eşitlik durumuna göre tek bir tane kodu/konsepti/algoritmayı tetiklemek/operasyon yapmak.
            //case bloklarının sıralaması ve default'un yerleştirildiği yer önemli değildir....
            string adi = "Ahmet";
            switch (adi)
            {
                case "Mehmet":
                    Console.WriteLine("Adı Mehmet");
                    break;
                default:
                    Console.WriteLine("Hiçbiri değil");
                    break;
                case "Ahmet":
                    Console.WriteLine("Adı Ahmet");
                    break;
                case "Hilmi":
                    Console.WriteLine("Adı Hilmi");
                    break;

            }
            #region when
            //Switch yapılanmasında sadece elimizdeki değerin eşitlik durumunu kontrol edebilmekteyiz.Bunun dışında bu kontrol esnasında farklı şartlarıda değerlendirmek istiyorsak eğer when keywordünü kullanabiliriz.
            //programlamada şart duyduğun anda aklına hemen boolean gelmeli
            int satisTutar = 1000;
            switch (satisTutar)
            {
                case 1000 when (3 == 5):

                    break;
                case 1000 when (3 == 3):

                    break;
            }
            #endregion
            #region go to
            //switch case yapılanmasında sadece eşitlik durumunu inceleyebildiğimiz için mantıksal bir işlem gerçekleştiremekteyiz. Dolayısıyla bazen farklı değerler eşit olma durumunda aynı operasyonu/kodu/akışı kullanacağımız senaryolarla karşılaşabilmekteyiz
            //Farklı eşitliklerde aynı kodu çalıştıracaksak eğer kod tekrarına girmemek için goto keywordü ile şu case'deki kodu çalıştır diyeiliyoruz.... Yani caseler arasında zıplama yapabiliyoruz.....
            //goto keywordünün kullanıldığı case'in eşleştirmesine bakmaksızın direkt olarak kodunu çalıştıracaktır.
            int i = 10;
            switch (i)
            {
                case 5:
                    Console.WriteLine(i * 10);
                    break;
                case 6:
                    Console.WriteLine(i / 5);
                    break;
                case 7:
                case 10:
                    goto case 5;
            }
            #endregion
            #region Switch Expressions
            //Tek satırlık işlemler için maliyet düşürücü ve kullanışlı semantiklerdir.
            #region Eski Yöntem
            string isim = "";
            int i2 = 10;
            switch (i)
            {
                case 5:
                    isim = "Hilmi";
                    break;
                case 7:
                    isim = "Rıfkı";
                    break;
                case 10:
                    isim = "Musa";
                    break;

            }
            #endregion
            #region Yeni Yöntem
            int i0 = 10;
            string isim2 = i0 switch
            {
                5 when 3 == 3 => "Hilmi",
                int x when x == 7 && x % 2 == 1 => "Rıfkı",
                10 => "Musa",
                var x => "Hiçbiri" //default : Hiçbirinin olamdığı durumda default tanımlamaasına karşılık gelecektir.
            };
            #endregion
            #region Tuple Patterns
            //Tuple patterns ise switch yapılanmasını Tuple nesnelerini kontrol edebilecek şekilde hem standart hemde yeni yapılanmayla bizlere sunmaktadır.
            #region Eski
            int s1 = 10;
            int s2 = 20;
            string mesaj = "";
            switch (s1, s2)
            {
                case (5, 10):
                    mesaj = "5 ile 10 değerleri";
                    break;
                case (10, 20):
                    mesaj = "10 ile 20 değerleri";
                    break;
                default:
                    break;
            }
            Console.WriteLine(mesaj);
            #endregion
            #region Yeni
            string mesaj2 = (s1, s2) switch
            {
                (5, 10) => "5 ile 10 değerleri",
                (10, 20) => "10 ile 20 değerleri"
            };
            #endregion
            #region When şartı ile Tuple Patterns
            string mesaj4 = (s1, s2) switch
            {
                (5, 10) when (true) => "5 İle 10 değerleri",
                var x when (x.s1 % 2 == 1 || x.s2 == 10) => "10 İle 20 değerleri",
                _ => "Hiçbiri"

            };
            #endregion
            #endregion
            #region Positional Patterns 
            //Positional patterns ise Deconstruct özelliği olan nesneleri kıyaslamak yahut değersel karşılaştırmak için kullanılan gelişimdir.
            #endregion
            #region Property Patterns
            //Property patterns nesnenin propertylerine girerek belirli durumları hızlı bir şekilde kontrol etmemizi gerçekleştiren ve bunu farklı değerler için birden fazla kez tekrarlı bir şekilde yapmamıza olanak sağlayan güzel gelişimdir.
            //Patternlar desen getiriyor yani kodeun maliyetini ve yapısını düzenliyor daha yakışıklı bir kod ortaya çıkarmamızı sağlıyor.
            #endregion
            #endregion
            #endregion
            #region if
            //Switch case : Elimizdeki bir değerin sadece eşitlik durumunu check eden/kontrol eden kiyaslayan bir akış kontrol mekanizması
            //if yapılanması elimizdeki bir değerin eşitlik durumu da dahil tümmmm bütün karşılaştırmaları yapmamızı sağlayan ve sonuca göre akışı yönlendirmemizi sağlayan bir yapılanmadır. 

            bool medeniHal = true;
            if (medeniHal == true)//medein hal true ise diye sorduk
            {
                Console.WriteLine("Allah tek yastıkta kocatsın...");
            }

            //if yapılanması tek başına kullanılıyorsa sadece şarta bağlı çalışacak koda odaklanır..

            #region Kritik 1
            //if yapılanmasında illa ki else kullanmak zorunda değiliz
            int i6 = 10;
            if (i6 != 10)
            {
                Console.WriteLine("Merhaba");
            }
            Console.WriteLine("Dünya");
            #endregion
            #region Kritik 2
            //bool türdeki değişkenlerin değerleri zaten bool olacağından dolayı karşılaştırma operatörünü kullanmak zorunda değiliz...
            bool medeniHal2 = true;
            //if (medeniHal == true)
            if (medeniHal2)
            {
                Console.WriteLine("Hayırlı olsun...");
            }
            #endregion
            #region if else 
            //if yapısı -> Şarta göre bir kodun çalışıp çalışmayacağını belirleyen bir yapılanma...
            //if else yapısı -> Şarta göre bir kodun çalışıp, şartın olamdığı durumda bir başka kodun çalışmasını belirleyen bir yapılanma...
            //Şartın olumsuz/değil durumunda da çalışacak kodu belirlemiş oluyoruz!!!
            //if bloğunda else varsa, şartın false olması durumunda kesinlikle else bloğu tetiklenir.
            //if else yapılanmasında şart doğru olduğunda sadece if,yanlış olduğunda ise sadece else blokları tetiklenir 
            int i01 = 3;
            if (i01 > 5)
            {
                Console.WriteLine("i01 değeri 5'ten büyüktür.");
            }
            else
            {
                Console.WriteLine("i01 değeri 5'ten küçüktür. ");
            }



            #region KRİTİK 1
            //Şartın işleyişine/davranışına göre true ya da false döneceği için buradaki algoritma takla atabilir/yer değiştirebilir. buna manevra diyoruz.
            int i02 = 10;
            if (i02 != 10)
            {
                Console.WriteLine("i02 değeri 10 değil");
            }
            else
            {
                Console.WriteLine("i02 değeri 10");
            }

            if (i02 == 10)
            {
                Console.WriteLine("i02 değeri 10");
            }
            else
            {
                Console.WriteLine("i02 değeri 10 değil");
            }
            #endregion
            #region KRİTİK 2
            //if else yapılanmasında if ve else bloklarında aynı işlemleri yapacaksak eğer bu nları bu şekilde blok içerisinde tekrarlı bir şekilde yapmamamız GEREKMEKTEDİR!!!!
            //Her iki durumda da ortak olacak olan/çalıştırılacak komutları if else bloğunun dışına yazmamız olayı çözecektir.
            int i03 = 10;
            if (i03 == 10)
            {
                Console.WriteLine("i03 değeri 10");
                //Console.WriteLine("Merhaba");
            }
            else
            {
                Console.WriteLine("i03 değeri 10 değil");
                //Console.WriteLine("Merhaba");
            }
            Console.WriteLine("Merhaba");


            #endregion



            #endregion
            #region if - else if 
            //Birden fazla şartı kontrol etmemizi sağlayan yapılanmadır.
            //if yapılanmalarından herahngi biri doğrulandıysa eğer diğer ifler denetlenmeyecektir...
            int sayi = 30;
            if (sayi > 5 && sayi <= 10)
            {
                Console.WriteLine(sayi * 5);
            }
            else if (sayi > 10 && sayi <= 20)
            {
                Console.WriteLine(sayi * 10);
            }
            else if (sayi > 20 && sayi <= 30)
            {
                Console.WriteLine(sayi * 20);
            }


            #region KRİTİK
            //int sayi1 = int.Parse(Console.ReadLine());
            //if (sayi1 > 100 && sayi1 <= 200)
            //{
            //    Console.WriteLine("100 ile 200 arasında");
            //}
            //else if (sayi1 > 200 && sayi1 <= 300)
            //{
            //    Console.WriteLine("200 ile 300 arasında");
            //}
            //else if (sayi1 > 200 && sayi1 <= 400)
            //{
            //    Console.WriteLine("200 ile 400 arasında");
            //}
            //amacın neyse yapacağın operasyonun fıtratına uygun bir şekilde bunları kullanmalısın
            int sayi1 = int.Parse(Console.ReadLine());
            //ifler birbirinden bağımsızdır.
            if (sayi1 > 100 && sayi1 <= 200)
            {
                Console.WriteLine("100 ile 200 arasında");
            }
            if (sayi1 > 200 && sayi1 <= 300)
            {
                Console.WriteLine("200 ile 300 arasında");
            }
            if (sayi1 > 200 && sayi1 <= 400)
            {
                Console.WriteLine("200 ile 400 arasında");
            }
            #endregion
            #endregion
            #region if - else if - .... - else 
            int ac = 100;
            if (ac < 100)
            {
                Console.WriteLine("100'den küçük");
            }
            else if (ac > 100)
            {
                Console.WriteLine("100'den büyük");
            }
            else
            {
                Console.WriteLine("100'e eşit.");
            }
            #endregion
            #region Scopesuz if yapısı
            //if yapısı tek satırlık/konseptlik bir işlem gerçekleştiriyorsa eğer bunu scope çerisinde yazmak mecburiyetinde değildir.
            //Eğer ki birden fazla konsept/işlem/operasyon barındıracaksa bunları kesinlikle scope içerisine almamız gerekmektedir... Aksi taktirde scopesuz çalışırsa ilk işlemi if bloğu alacak diğerlerini almayacaktır....
            if (true)
            {
                Console.WriteLine("475484awgag agewsgaqf");
            }
            if (true)
                Console.WriteLine("agasöogesakg oekgag");
            if (true)
            {
                Console.WriteLine("A");
                Console.WriteLine("B");
            }
            #endregion
            #region Senaryo 1
            //Klavye'den iki ürünün fiyatı girildiğinde toplam fiyat 200'TL'den fazla ise,2. üründen  %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.
            #region Benim Çözümüm
            Console.WriteLine("Lütfen tutarı giriniz");
            decimal tutar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen tutarı giriniz");
            decimal tutar2 = int.Parse(Console.ReadLine());

            if (tutar1 > 200)
            {
                tutar2 -= tutar2 * 0.25m;
            }
            Console.WriteLine($"Ödenecek Tutar = {tutar1 + tutar2}");
            #endregion
            #region Hocanın Çözümü
            Console.Write("Lütfen birinci ürünün fiyatını giriniz : ");
            int birinciUrunFiyati = int.Parse(Console.ReadLine());
            Console.Write("Lütfen ikinci ürünün fiyatını giriniz : ");
            int ikinciUrunFiyati = int.Parse(Console.ReadLine());

            int toplam = birinciUrunFiyati + ikinciUrunFiyati;
            #region 1. Kritik
            if (toplam > 200)
            {

            }
            #endregion
            #region 2. Kritik
            if (birinciUrunFiyati + ikinciUrunFiyati > 200)
            {
                //int toplamSonTutar =  birinciUrunFiyati += (ikinciUrunFiyati * (75 / 100));
                Console.WriteLine(birinciUrunFiyati += (ikinciUrunFiyati * (75 / 100)));
            }
            else
            {
                Console.WriteLine(birinciUrunFiyati + ikinciUrunFiyati);
            }
            #endregion
            #endregion



            #endregion
            #region Senaryo 2
            //Belirlenen kullanıcı adı ve şifre doğru girildiğinde "Giriş Başarılı", yanlış girildiğinde "Girdiğiniz kullanıcı adı veya şifre hatalı" mesajı veren Console uygulamasını yapalım
            #region Benim Çözümüm
            Console.Write("Kullanıcı Adını Giriniz : ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifreyi Giriniz : ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == "deneme" && sifre == "12345")
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı");
            }
            #endregion
            #region Hocanın Çözümü
            Console.WriteLine("Lütfen Kullanıcı adınızı yazınız.");
            string kullaniciAdi2 = Console.ReadLine();
            Console.WriteLine("Lütfen şifrenizi giriniz.");
            string sifre2 = Console.ReadLine();

            //if (!(kullaniciAdi2 == "gncy" && sifre2 == "12345"))
            //    Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalıdır.");
            //else
            //    Console.WriteLine("Giriş Başarılı");
            Console.WriteLine((kullaniciAdi2 == "gncy" && sifre2 == "12345") ? "Giriş Başarılı" : "Girdiğiniz kullanıcı adı veya şifre hatalıdır.");

            #endregion
            #region Switch
            Console.WriteLine("Lütfen Kullanıcı adınızı yazınız.");
            string kullaniciAdi3 = Console.ReadLine();
            Console.WriteLine("Lütfen şifrenizi giriniz.");
            string sifre3 = Console.ReadLine();

            Console.WriteLine((kullaniciAdi3, sifre3) switch
            {
                ("Musa", "12345") => "Giriş Başarılı",
                _ => "Girdiğiniz kullanıcı adı veya şifre hatalı"
            });


            #endregion
            #endregion
            #region Senaryo 3
            //Kullanıcıdan alınan iki sayının ve yapılacak işlem türünün (toplam,çıkarma,çarpma,bölme) seçilmesiyle, sonucu hesaplayan programı yazalım.
            #region Benim çözümüm
            Console.WriteLine("1. Sayıyı Giriniz");
            int sayi4 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz");
            int sayi5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Yapılacak İşlemi Seçiniz (+,-,*,/)");
            char islem = char.Parse(Console.ReadLine());

            Console.WriteLine
                (
                    (islem) switch
                    {
                        '+' => sayi4 + sayi5,
                        '-' => sayi4 - sayi5,
                        '*' => sayi4 * sayi5,
                        '/' => sayi4 / sayi5,
                    }
                );
            #endregion
            #region Hocanın Çözümü
            Console.WriteLine("1. Sayıyı Giriniz");
            int sayi41 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz");
            int sayi51 = int.Parse(Console.ReadLine());
            Console.WriteLine("Yapılacak İşlemi Seçiniz (+,-,*,/)");
            char islem1 = char.Parse(Console.ReadLine());

            #region 1. Kritik
            if (islem1 == '+')
            {
                Console.WriteLine(sayi51 + sayi41);
            }
            else if (islem1 == '-')
            {
                Console.WriteLine(sayi51 - sayi41);
            }
            else if (islem1 == '*')
            {
                Console.WriteLine(sayi51 * sayi41);
            }
            else
            {
                Console.WriteLine(sayi51 / sayi41);
            }
            #endregion
            #region 2. Kritik
            switch (islem1)
            {
                case '+':
                    break;
                case '-':
                    break;
                case '*':
                    break;
                //case '/':
                //    break;
                default:
                    break;
            }
            #endregion
            #region 3. Kritik
            int sonuc = islem1 switch
            {
                '+' => sayi41 + sayi51,
                '-' => sayi41 - sayi51,
                '*' => sayi41 * sayi51,
                '/' => sayi41 / sayi51,
                _ => sayi51 * sayi41
            };
            #endregion
            #region 4. Kritik
            Console.WriteLine(islem1 == '+' ? sayi41 + sayi51 : (islem1 == '-' ? sayi51 - sayi41 : (islem == '*' ? sayi41 * sayi51 : sayi41 / sayi51)));
            #endregion
            #endregion
            #endregion
            #region Senaryo 4
            //Girilen sayının değeri 10 değilse ekrana 'sayı yanlış' yazdıralım
            #region Benim Çözüm
            Console.WriteLine("Sayı giriniz");
            int sayi245 = int.Parse(Console.ReadLine());
            if (sayi245 != 10)
                Console.WriteLine("Sayı yanlış");
            #endregion
            #region Hocanın Çözümü
            Console.WriteLine("Sayı giriniz");
            int sayi246 = int.Parse(Console.ReadLine());
            #region Kritik 1
            if (sayi246 == 10)
            {

            }
            else
            {
                Console.WriteLine("Sayı yanlış");
            }
            #endregion
            #region Kritik 2
            if (sayi246 != 10)
            {
                Console.WriteLine("sayı yanlış");
            }
            #endregion
            #region Kritik 3
            Console.WriteLine(sayi246);
            #endregion
            #endregion
            #endregion
            #region Senaryo 5
            //Girilen sayının negatif ya da pozitif olduğunu gösteren uygulamayı yazalım.
            #region Benim Çözüm
            int sayi247 = int.Parse(Console.ReadLine());
            Console.WriteLine(sayi247 > 0 ? "Pozitif" : "Negatif");
            #endregion
            #region Hocanın Çözümü
            int sayi248 = int.Parse(Console.ReadLine());

            string sonuc2 = "";
            if (sayi248 < 0)
                //Console.WriteLine("Negatif");
                sonuc2 = "Negatif";
            else
                //Console.WriteLine("Pozitif");
                sonuc2 = "Pozitif";
            Console.WriteLine(sonuc2);
            #endregion
            #endregion
            #endregion
            //Birçok yazılımcı analitik bir çözüm getirmiyor ilk bulduğu yöntemi ya da bildiği neyse onu uygulamaya çalışıyor. Ama biz bunu yapmayacağız düşünüp karar vereceğiz.Birden fazla farklı yöntemle ben bunu nasıl yapabilirim? Aralarından hangisi en iyisidir? Hangisi Daha Doğrudur?
            //Yazılımcılığın  % 90'ı işin tefekkür boyutudur. yani derin düşünce boyutudur.
            //Hepimiz bir şairiz en güzel belagatı yapabilen olmak
        }
    }
}
