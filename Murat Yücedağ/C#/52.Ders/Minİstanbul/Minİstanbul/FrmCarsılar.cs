using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Minİstanbul
{
    public partial class FrmCarsılar : Form
    {
        public FrmCarsılar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Mısır Çarşısı, Eminönü'nde Yeni Camii'nin arkasında ve Çiçek Pazarı'nın yanındadır. İstanbul'un en eski kapalı çarşılarından biridir. Aktarlarıyla meşhur bu çarşıda hâlen tabii ilaçlar, baharat, çiçek tohumları, nadir bitki kök ve kabukları gibi eski geleneğine uygun ürünlerin yanı sıra; kuruyemiş, şarküteri ürünleri, değişik gıda maddeleri satılmaktadır. Mısır Çarşısı pazar günleri de açıktır." +
                "Bizans zamanında Makro Envalos adında bir çarşının aynı yerde bulunduğu rivâyet edilmektedir. Bugünkü yapı, 1660 yılında Turhan Sultan tarafından Hassa baş mimarı Kâzım Ağa'ya yaptırılmıştır. Önceleri Yeni Çarşı ya da Vâlide Çarşısı olarak anılan ve rivâyete göre Mısır'dan alınan vergilerle inşâ edilen çarşı, 18. yüzyıldan sonra bugün bilinen adıyla anılmaya başlanmıştır. 1691 ve 1940'ta iki büyük yangın tehlikesini atlatmıştır. Çarşı, son olarak 1940-1943 yılları arasında İstanbul Belediyesi tarafından restore edilmiştir." +
                "Yeni Cami'nin yanında yer alan L şeklindeki yapının altı kapısı bulunmaktadır. Bunlardan biri Haseki Kapısı'dır. Bunun üstündeki kısım iki katlı olup üst katta zamanında mahkeme olup esnafın kendi arasında ve halkla sorunları çözülürmüş.[1]";
            pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\misir.jpg";
            pictureBox2.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\misir2.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Sahaflar Çarşısı, Beyazıt Sahaflar Çarşısı ya da İstanbul Sahaflar Çarşısı, Fatih'te bulunan ve eski-yeni kitapların satıldığı tarihi çarşı. Beyazıt Camii, İstanbul Üniversitesi, Kapalıçarşı ve Beyazıt Devlet Kütüphanesi'ne olan yakınlığı nedeniyle eskiden bir kültür odağıydı. Zamanla sahafların ve satılan kitapların öncelik ve nitelikleri değişse bile halen Fatih'in uğrak yerlerindendir." +
                "Osmanlı İmparatorluğu'nda sahaflık büyük camilerin etrafında teşekkül ediyordu. Bunda cami eksenli ticari ve sosyal hayatın getirisi vardı. Sahaflar Çarşısı ise önceleri şimdiki konumunda değil, Kapalıçarşı'nın içerisinde bulunuyordu. Evliya Çelebi'nin aktardığı bilgilere göre eski sahaflar çarşısı Kapalıçarşı içerisinde yaklaşık 50 dükkandan ibaretti. Bu dükkanlarda yaklaşık 300 kişi çalışıyordu. Hammer ise bu dükkanların çarşı içinde dağınık bir vaziyette olduğunu aktardı. Bu dönemde burada çeşitli minyatürlü nadide eserler, el yazmaları, din, felsefe ve mantık kitapları satılıyordu.[1]Hakkaklar Çarşısı'na sahafların yerleşmesi 1910'lara kadar devam etti. Kapalıçarşı'daki sahaflar ile Hakkaklar Çarşısı'ndaki fesciler zamanla yer değiştirdi.Zamanla şimdiki yer Sahaflar Çarşısı olarak anıldı. 1950'de büyük bir yangın geçirdi. Belediye burayı betonarme bir şekilde yeniden düzenledi. 1952 sonrasında belediye burada sadece kitap satılmasını istedi.[1] Hakkı Tarık Us bu konuda etkili oldu.[2]Çarşının iki kapısı bulunmaktadır. Biri Beyazıt Camii'nin hemen dibinde yer alırken diğeri Kapalıçarşı'ya çıkan yola açılır. Belediye 1981'de buraya ilk Türk matbaacısı olan İbrahim Müteferrika'nın büstünü koydu.Çarşının tam ortasında Laleli'deki Çoban Çavuş Camii'nin haziresinden getirilmiş olan Sahaf Kı­rımlı Hasan Efendi'ye ait bir mezar taşı ağacın dibine konuldu. Çarşı'nın sebil durumundaki çeşmeleri de bulunmaktadır. Genel olarak eski kültürel işlevini kaybetmiştir.[1] İstanbul Üniversitesi'ne olan yakınlığı buraya öğrenci ilgisini artırmıştır. Fakat genel olarak Türk eğitim sistemindeki dönüşüm sonrasında buradaki sahaflar bibliyograf özelliklerini kaybetti. Ağırlıklı olarak üniversite hazırlık kitapları, yabancı dil eğitimi için kitap ve setler göze çarpmaktadır.Çarşının giriş kısmındaki çınar agacının altını kendisine mesken tutarak çeşitli eserler satan Hüseyin Avni Dede ise meydanın tanınmış simasıdır." +
                "Ali Emîrî Efendi Dîvânü Lugati't-Türk'ün ele geçen tek nüshasını Sahaflar Çarşısı'nda tesadüfen bularak 30 Lira ve sahafa küçük bir kâr ödemesi yaptıktan sonra satın aldı.[4] Çarşı Türk romancılarının da uğrak noktalarından biriydi. İstanbul Üniversitesi Edebiyat Fakültesi'nde dersler veren Ahmed Hamdi Tanpınar Huzur romanında Mümtaz karakteri ekseninde burayı mekan unsuru olarak kullandı.[5] Türk bibliyograf Seyfettin Özege (1901-1818) de buradan edindiği kitapları koleksiyonuna ekliyordu.[6]";
            pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\sahaf.jpg";
            pictureBox2.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\sahaf2.jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kapalıçarşı, İstanbul kentinin merkezinde Beyazıt, Nuruosmaniye ve Mercan semtlerinin ortasında yer alan dünyanın en büyük çarşısı ve en eski kapalı çarşılarından biri. Kapalıçarşı'da yaklaşık 4.000 dükkân bulunmaktadır ve bu dükkânlarda toplam çalışan sayısı yaklaşık 25.000'dir. Gün içerisindeki en yoğun zamanlarında içinde 500.000' e yakın insan barındırdığı söylenir. Yılda 91 milyon turisti ağırlayan çarşı, dünyanın en fazla ziyaret edilen turistik mekanıdır." +
                "Kapalıçarşı'nın çekirdeğini oluşturan iki bedestenden İç Bedesten yani Cevahir Bedesteni müellifler arasında tartışmalı olmakla beraber büyük olasılıkla Bizans'tan kalma bir yapı olup 48 m x 36 m ölçülerindedir. Yeni Bedesten ise 1460[kaynak belirtilmeli] yılında Fatih Sultan Mehmet tarafından yaptırılan Kapalıçarşı'nın ikinci önemli yapısıdır ve Sandal Bedesteni olarak anılmaktadır. Burada bir yolu pamuk bir yolu ipekten dokunan ve Sandal adı verilen kumaş satıldığı için Sandal Bedesteni ismi verilmiştir.Fatih Sultan Mehmet'in Kapalıçarşı'nın inşaatına başladığı yıl olan 1460 Kapalıçarşı'nın kuruluş yılı olarak kabul görmüştür. Asıl büyük çarşı ise Kanuni Sultan Süleyman tarafından ahşap olarak inşa ettirilmiştir.Dev ölçülü bir labirent gibi, 30.700 metrekarede 66 kadar sokağı, 4.000 kadar dükkânı ile Kapalıçarşı, İstanbul’un görülmesi gereken, benzersiz bir merkezidir.Adeta bir şehri andıran, bütünü ile örtülü bu site zaman içerisinde gelişip büyümüştür. İçinde son zamanlara kadar 5 cami, 1 mektep, 7 çeşme, 10 kuyu, 1 sebil, 1 şadırvan, 24 kapı, 17 han bulunmaktaydı.15.yüzyıldan kalan kalın duvarlı, bir seri kubbe ile örtülü eski iki yapının etrafı sonraki yüzyıllarda, gelişen sokakların üzerleri örtülerek, ekler yapılarak bir alışveriş merkezi haline gelmiştir. Geçmişte burası her sokağında belirli mesleklerin yer aldığı ve bunların da, el işi imalatının(manifaktür) sıkı denetim altında bulundurulduğu, ticari ahlak ve törelere çok saygı gösterilen bir çarşı idi.Her türlü değerli kumaş, mücevherat, silah, antika eşya, konusunda nesillerce uzmanlaşmış aileler tarafından, tam bir güven içinde satışa sunulurdu. Geçen yüzyılın sonlarında deprem ve birkaç büyük yangın geçiren Kapalıçarşı eskisi gibi onarılmışsa da, geçmişteki özellikleri değişikliğe uğramıştır.Bütün dükkânların genişliği aynı olacak şekilde inşa edilmiştir. Her sokakta ayrı ürünün ustaları loncalar halinde bulunurdu(yorgancılar, terlikçiler vs.) Satıcılar arasında rekâbet kesinlikle yasaktı.Hatta bir usta, tezgâhını dükkânın önüne çıkarıp kalabalığa göstererek ürün işleyemezdi. Ürünlere devletin belirlediğinden yüksek fiyat konulamazdı." +
                "Eskiden esnafa olan güven duygusu halkın birikmiş parasının, bir banka gibi onlara verilmesine ve işletilmesine neden olurdu. Günümüzde birçok sokaktaki dükkânlar fonksiyon değişikliğine uğramıştır. Yorgancılar, terlikçiler, fesçiler gibi meslek grupları sadece sokak ismi olarak kalmıştır. Çarşının ana caddesi sayılan sokakta çoğunlukla mücevher dükkânları, buraya açılan yan bir sokakta altıncılar bulunur. Oldukça küçük olan bu dükkânlar değişik fiyat ve pazarlıkla satış yaparlar. Kapalıçarşı renk ve atraksiyon olarak her ne kadar eski canlılığını koruyor ise de, 1970'li yıllardan itibaren İstanbul’u ziyarete gelen turist grupları için alışveriş olanakları, çarşının ana girişindeki modern ve büyük kuruluşlar tarafından sağlanmaktadır. Haliç kıyısındaki Mısır Çarşısı da daha küçük ölçüde bir kapalı çarşıdır. Galata semtinde 15. yüzyılda kalma diğer bir küçük kapalı çarşı da hâlen kullanılmaya devam etmektedir.Kapalı Çarşı günün her saatinde hareketli ve kalabalıktır. Esnaf, ziyaretçileri ısrarlı olarak kendi mağazasına çağırır. Çarşı girişinde gelişen konforlu, büyük mağazalar Türkiye’de elde imal edilen ve ihracatı yapılan hemen hemen bütün eşyaları satışa sunmaktadır.El halıları ve mücevherat geleneksel Türk sanatının en güzel örnekleridir. Bunlar kalite ve orijin belgeleri ile satılır ve dünyanın her tarafına garantili gönderme yapılır. Halı ve mücevheratın yanında meşhur Türk işi gümüşten yapılmış eserler, bakır, bronz hediyelik ve dekoratif eşya, seramik, oniks ve deriden mamul, üstün kaliteli, Türkiye hatıraları zengin bir koleksiyon oluştururlar.Batılı yazarlar, seyahatname ve anılarında Kapalıçarşı’ya geniş yer ayırmışlardır.İstanbul'un önemli turistik yerlerinden biridir.";
            pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\kapali.jpg";
            pictureBox2.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\kapali2.jpg";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }
    }
}
