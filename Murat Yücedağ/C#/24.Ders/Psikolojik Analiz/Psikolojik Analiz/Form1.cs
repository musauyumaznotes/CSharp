using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psikolojik_Analiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru;
        int toplam = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = false;
            button6.Text = "Sonraki";
            soru++;

            if (soru==1)
            {
                textBox1.Text = "1-)Sevgilinizle ya da eşinizle mükemmel bir akşam size aşağıdakilerden hangisini çağrıştırıyor?";
                button1.Text = "Bir konsere gitmek";
                button2.Text = "Lunaparka gitmek";
                button3.Text = "Sinemaya gitmek";
                button4.Text = "mum ışığında romantik yemek yemek";
                button5.Text = "arabayla turlamak";
            }
            if (soru == 2)
            {
                textBox1.Text = "2-)En sevdiğiniz müzik türü hangisidir?";
                button1.Text = "Alternatif";
                button2.Text = "Rock and Roll";
                button3.Text = "Pop";
                button4.Text = "Soft Rock";
                button5.Text = "Klasik";
            }
            if (soru == 3)
            {
                textBox1.Text = "3-)En çok hangi tür filmleri seversiniz?";
                button1.Text = "Korku";
                button2.Text = "Komedi";
                button3.Text = "Müzikal";
                button4.Text = "Romantik";
                button5.Text = "Belgesel";
            }
            if (soru == 4)
            {
                textBox1.Text = "4-)Aşağıdaki mesleklerden birini seçmeniz gerekseydi hangisi olurdunuz?";
                button1.Text = "Barmen/Barmaid";
                button2.Text = "Polis";
                button3.Text = "Öğretmen";
                button4.Text = "Garson";
                button5.Text = "Futbolcu";
            }
            if (soru == 5)
            {
                textBox1.Text = "5-)1 saat boş vaktiniz değerlendirmek için hangisi size daha uygun?";
                button1.Text = "Tv izlemek";
                button2.Text = "İnternette takılmak";
                button3.Text = "Uyumak";
                button4.Text = "Okumak";
                button5.Text = "Dışarıda çalışmak";
            }
            if (soru == 6)
            {
                textBox1.Text = "6-)Aşağıdaki renklerden birini seçiniz";
                button1.Text = "Sarı";
                button2.Text = "Kahverengi";
                button3.Text = "Mavi";
                button4.Text = "Kırmızı";
                button5.Text = "Beyaz";
            }
            if (soru == 7)
            {
                textBox1.Text = "7-)Şu an önünüzde aşağıdaki yiyeceklerden hangisi olsa dayanamayıp götürürsünüz?";
                button1.Text = "Suşi";
                button2.Text = "Pizza";
                button3.Text = "Dondurma";
                button4.Text = "Makarna";
                button5.Text = "Salata";
            }
            if (soru == 8)
            {
                textBox1.Text = "8-)En sevdiğiniz tatil,bayram ya da özel gün hangisi?";
                button1.Text = "23 nisan Çocuk Bayramı";
                button2.Text = "Yılbaşı";
                button3.Text = "Ramazan Bayramı";
                button4.Text = "Sevgililer Günü";
                button5.Text = "Kurban Bayramı";
            }
            if (soru == 9)
            {
                textBox1.Text = "9-)Şu an hangisinde bulunmak isterdin?";
                button1.Text = "Las Vegas";
                button2.Text = "Hawai";
                button3.Text = "Hollywood";
                button4.Text = "Paris";
                button5.Text = "İspanya";
            }
            if (soru == 10)
            {
                textBox1.Text = "10-)Nasıl biriyle vakit geçirmekten hoşlanırsınız?";
                button1.Text = "Parti canavarıyla";
                button2.Text = "Güzel/Yakışıklı biriyle";
                button3.Text = "Komik biriyle";
                button4.Text = "duygusal biriyle";
                button5.Text = "Akıllı biriyle";

                button6.Text = "Sonuç";
            }
            if (soru == 11)
            {
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                label2.Text =toplam.ToString();
                button6.Enabled = false;

                if (toplam<=17 && toplam >= 10)
                {
                    textBox1.Text = "Siz Vahşi ve çılgın birisiniz Eğleneyim derken uçuyorsunuz. " +
                        "Ama her zaman ne yaptığınızın farkındasınız hayatınızın kontrolünü kaybetmiyorsunuz." +
                        " İnsanlar olaylara sizin gibi bakmadığında bu sizi durdurmuyor . " +
                        "" +
                        "Tavsiye:Bu vahşi karakterinizle kendinizi ve etrafınızdakileri incitebilirsiniz dikkatli olun!!!" ;
                }
                if (toplam<=26 && toplam>=18)
                {
                    textBox1.Text = "Siz eğlenceli,arkadaş canlısı  ve popülersiniz Cıvıl cıvıl halinizle etrafa neşe saçıyorsunuz." +
                        " Çoğu zaman ikili ilişkilerinizde uçuk kaçık davransanızda inandığınız değerlerden asla taviz vermiyorsunuz" +
                        " Evlilik ve çocuk sahibi olmak  sizin için önemli ama öncelikle yeterince tecrübe edinmek istiyorsunuz." +
                        "" +
                        "Tavsiye:İnsanların aldığınız kararlarda sizi bu kadar etkilemelerine izin vermeyin." ;
                }
                if (toplam<=34 && toplam >= 27)
                {
                    textBox1.Text = "Öyle tatlısınız ki sizi sevmemek imkansız Siz insanların asla kaybetmek istemediği türden bir dostsunuz." +
                        "Kimseyi incitmemek için kendinizi incittiğiniz bile oluyor Siz genellikle olaylar karşısında olgun ve sakin bir tavır takınırsınız." +
                        "" +
                        "Tavsiye: Herkes göründüğü gibi değildir bunu unutmayın biraz kurnaz olun ";
                }
                if(toplam <= 42 && toplam >= 35)
                {
                    textBox1.Text = "Siz iflah olmaz bir romantiksiniz Şarap,kırmızı güller bunlar sizin yaşam tarzınız Söz verirsiniz ve o söz ne olursa olsun yerine getirirsiniz " +
                        "Ailenize çok bağlısınız annenizi her hafta sonu ararsınız  özel günleri asla unutmazsınız" +
                        "" +
                        "Tavsiye:Fazla romantizmin sizi gerçeklerden uzaklaştırmasına izin vermeyin";
                }
                if (toplam <= 50 && toplam >= 43)
                {
                    textBox1.Text = "Belirgin özelliğiniz hızlı ve doğru karar verebilmeniz Her olay için kafanızda bir planınız vardır " +
                        "Fiziksel ve zihinsel gücünüz çok fazla Mantıklı ılımlı ve yapıcı tavırlarınızla çoğu kişinin kendine örnek aldığı birisiniz" +
                        "" +
                        "Tavsiye:Küçük gibi görünen bazı olayları gözardı etmeniz ileride büyük sorunlara yol açabilir ";
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplam += 1;
            button1.Enabled =false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toplam += 2;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toplam += 3;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toplam +=4;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            toplam += 5;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\24.Ders\müzik\muzik.mp3";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }
    }
}
