using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minİstanbul
{
    public partial class FrmMetro : Form
    {
        public FrmMetro()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0,1);
        }

        private void FrmMetro_Load(object sender, EventArgs e)
        {
            textBox1.Text = " Minİstanbul Programı Metro Durakları";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "M1A Yenikapı-Atatürk Havalimanı Metro Hattı")
            {
                textBox1.Text = "Atatürk Havalimanı, DTM-İstanbul Fuar Merkezi, Yenibosna, Ataköy-Şirinevler, Bahçelievler, Bakırköy-İncirli, Zeytinburnu, Merter, Davutpaşa-YTÜ, Terazidere, Otogar, Kocatepe, Sağmalcılar, Bayrampaşa-Maltepe, Topkapı-Ulubatlı, Emniyet-Fatih, Aksaray, Yenikapı";
            }
            if (comboBox1.Text == "M1B Yenikapı-Kirazlı Metro Hattı")
            {
                textBox1.Text = "Kirazlı-Bağcılar, Bağcılar Meydan, Üçyüzlü, Menderes, Esenler, Otogar, Kocatepe, Sağmalcılar, Bayrampaşa-Maltepe, Topkapı-Ulubatlı, Emniyet-Fatih, Aksaray, Yenikapı";
            }
            if (comboBox1.Text== "M2 Yenikapı-Hacıosman Metro Hattı")
            {
                textBox1.Text = "Yenikapı, Vezneciler-İstanbul Ü., Haliç, Şişhane, Taksim, Osmanbey, Şişli-Mecidiyeköy, Gayrettepe, Levent, 4.Levent, Sanayi Mahallesi, Seyrantepe, İTÜ-Ayazağa, Atatürk Oto Sanayi, Darüşşafaka, Hacıosman";
            }
            if (comboBox1.Text== "M3 Kirazlı-Başakşehir/Metrokent Metro Hattı")
            {
                textBox1.Text = "Başakşehir-Metrokent, Başak Konutları, Siteler, Turgut Özal, İkitelli Sanayi, İSTOÇ, Mahmutbey, Yenimahalle, Kirazlı-Bağcılar";
            }
            if (comboBox1.Text== "M4 Kadıköy-Tavşantepe Metro Hattı")
            {
                textBox1.Text = "Kadıköy, Ayrılık Çeşmesi, Acıbadem, Ünalan, Göztepe, Yenisahra, Kozyatağı, Bostancı, Küçükyalı, Maltepe, Huzurevi, Gülsuyu, Esenkent, Hastane-Adliye, Soğanlık, Kartal, Yakacık-Adnan Kahveci, Pendik, Tavşantepe";
            }
            if (comboBox1.Text== "M5 Üsküdar-Çekmeköy Metro Hattı")
            {
                textBox1.Text = "Üsküdar, Fıstıkağacı, Bağlarbaşı, Altunizade, Kısıklı, Bulgurlu, Ümraniye, Çarşı, Yamanevler, Çakmak, Ihlamurkuyu, Altınşehir, İmam Hatip Lisesi, Dudullu, Necip Fazıl, Çekmeköy";
            }
            if (comboBox1.Text== "M6 Levent-Boğaziçi Ü./Hisarüstü Metro Hattı")
            {
                textBox1.Text = "Levent, Nispetiye, Etiler, Boğaziçi Ü.-Hisarüstü";
            }
            if (comboBox1.Text== "M7 Mecidiyeköy-Mahmutbey Metro Hattı")
            {
                textBox1.Text = "Mecidiyeköy, Çağlayan, Kağıthane, Nurtepe, Alibeyköy, Çırçır, Veysel Karani-Akşemsettin, Yeşilpınar, Kazım Karabekir, Yenimahalle, Karadeniz Mahallesi, Tekstilkent-Giyimkent, Oruç Reis, Göztepe Mahallesi, Mahmutbey";
            }
            if (comboBox1.Text== "M9 Bahariye-Olimpiyat Metro Hattı")
            {
                textBox1.Text = "";
            }
            if (comboBox1.Text== "T1 Kabataş-Bağcılar Tramvay Hattı")
            {
                textBox1.Text = "Bağcılar, Güneştepe, Yavuzselim, Soğanlı, Akıncılar, Güngören, Merter Tekstil Merkezi, Mehmet Akif, Zeytinburnu, Mithatpaşa, Seyitnizam-Akşemsettin, Merkezefendi, Cevizlibağ-AÖY, Topkapı, Pazartekke, Çapa-Şehremini, Fındıkzade, Haseki, Yusufpaşa, Aksaray, Laleli-İstanbul Ü., Beyazıt-Kapalıçarşı, Çemberlitaş, Sultanahmet, Gülhane, Sirkeci, Eminönü, Karaköy, Tophane, Fındıklı-Mimar Sinan Ü., Kabataş";
            }
            if (comboBox1.Text== "T3 Kadıköy-Moda Tramvay Hattı")
            {
                textBox1.Text = "İskele Cami, Çarşı, Altıyol, Bahariye, Kilise, Moda İlkokulu, Moda Caddesi, Mühürdar, Damga Sokak, Kadıköy İDO";
            }
            if (comboBox1.Text== "T4 Topkapı - Mescid-i Selam Tramvay Hattı")
            {
                textBox1.Text = "Mescid-i Selam, Cebeci, Sultançiftliği, Yenimahalle, Hacı Şükrü, 50.Yıl Baştabya, Cumhuriyet Mahallesi, Kiptaş-Venezia, Karadeniz, Taşköprü, Ali Fuat Başgil, Bosna Çukurçeşme, Sağmalcılar, Uluyol Bereç, Rami, Topçular, Demirkapı, Şehitlik, Edirnekapı, Vatan, Fetihkapı, Topkapı";
            }
            if (comboBox1.Text== "T5 Cibali-Alibeyköy Cep Otogarı Tramvay Hattı")
            {
                textBox1.Text = "";
            }
            if (comboBox1.Text== "F1 Taksim-Kabataş Füniküler Hattı")
            {
                textBox1.Text = "Kabataş, Taksim";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }
    }
}
