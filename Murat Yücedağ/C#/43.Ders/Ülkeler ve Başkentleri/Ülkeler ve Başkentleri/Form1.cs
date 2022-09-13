using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ülkeler_ve_Başkentleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        string dogruCevap;
        int puan=0;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            button5.Enabled = false;
            btnA.BackColor = Color.White;
            btnB.BackColor = Color.White;
            btnC.BackColor = Color.White;
            btnD.BackColor = Color.White;
            button5.BackColor =Color.White;
            sayac++;
            button5.Text = "Sonraki";
            label1.Text = "";
            btnA.Text = "";
            btnB.Text = "";
            btnC.Text = "";
            btnD.Text = "";
            if (sayac==1)
            {
                label1.Text = "Türkiye";
                btnA.Text = "İstanbul";
                btnB.Text = "İzmir";
                btnC.Text = "Ankara";
                btnD.Text = "Adana";
                pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\43.Ders\resimler\ankara.jpg";
                dogruCevap = "Ankara";
            }
            if (sayac ==2 )
            {
                label1.Text = "Almanya";
                btnA.Text = "Köln";
                btnB.Text = "Frankurt";
                btnC.Text = "Stutgart";
                btnD.Text = "Berlin";
                pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\43.Ders\resimler\berlin.jpg";
                dogruCevap = "Berlin";

            }
            if (sayac == 3)
            {
                label1.Text = "Mısır";
                btnA.Text = "Kahire";
                btnB.Text = "Dimyat";
                btnC.Text = "İskenderiye";
                btnD.Text = "Süveyş";
                pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\43.Ders\resimler\kahire.jpg";
                dogruCevap = "Kahire";

            }
            if (sayac == 4)
            {
                label1.Text = "İspanya";
                btnA.Text = "Barselona";
                btnB.Text = "Madrid";
                btnC.Text = "Malaga";
                btnD.Text = "Kurtuba";
                pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\43.Ders\resimler\madrid.jpg";
                dogruCevap = "Madrid";
            }
            if (sayac == 5)
            {
                label1.Text = "Rusya";
                btnA.Text = "Kazan";
                btnB.Text = "Rostov";
                btnC.Text = "Moskova";
                btnD.Text = "Petersburg";
                pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\43.Ders\resimler\moskova.jpg";
                dogruCevap = "Moskova";
            }
            if (sayac == 6)
            {
                label1.Text = "Fransa";
                btnA.Text = "Lyon";
                btnB.Text = "Lille";
                btnC.Text = "Marsilya";
                btnD.Text = "Paris";
                pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\43.Ders\resimler\paris.jpg";
                dogruCevap = "Paris";
            }
            if (sayac == 7)
            {
                label1.Text = "Çin";
                btnA.Text = "Makao";
                btnB.Text = "Hong Kong";
                btnC.Text = "Altay";
                btnD.Text = "Pekin";
                pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\43.Ders\resimler\pekin.jpg";
                dogruCevap = "Pekin";
            }
            if (sayac == 8)
            {
                label1.Text = "Suudi Arabistan";
                btnA.Text = "Mekke";
                btnB.Text = "Medine";
                btnC.Text = "Riyad";
                btnD.Text = "Cidde";
                pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\43.Ders\resimler\riyad.jpg";
                dogruCevap = "Riyad";
            }
            if (sayac == 9)
            {
                label1.Text = "İtalya";
                btnA.Text = "Venedik";
                btnB.Text = "Roma";
                btnC.Text = "Floransa";
                btnD.Text = "Milano";
                pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\43.Ders\resimler\roma.jpg";
                dogruCevap = "Roma";
            }
            if (sayac == 10)
            {
                label1.Text = "Japonya";
                btnA.Text = "Hiroshima";
                btnB.Text = "Osaka";
                btnC.Text = "Fukishima";
                btnD.Text = "Tokyo";
                pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\43.Ders\resimler\tokyo.jpg";
                dogruCevap = "Tokyo";
            }
            if (sayac == 11)
            {
                timer1.Stop();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                button5.Enabled = false;
                label1.Text = "Yarışma Bitti İlginize Teşekkürler";
                puan = sure + puan;
                label3.Text = puan.ToString();
                
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text == dogruCevap)
            {
                puan += 10;
                label3.Text = puan.ToString();
                btnA.BackColor = Color.YellowGreen;

            }
            else if (btnA.Text !=dogruCevap)
            {
                btnA.BackColor = Color.IndianRed;
            }
            
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            button5.Enabled = true;
            button5.BackColor = Color.GreenYellow;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == dogruCevap)
            {
                puan += 10;
                label3.Text = puan.ToString();
                btnB.BackColor = Color.YellowGreen;
            }
            else if (btnB.Text != dogruCevap)
            {
                btnB.BackColor = Color.IndianRed;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            button5.Enabled = true;
            button5.BackColor = Color.GreenYellow;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == dogruCevap)
            {
                puan += 10;
                label3.Text = puan.ToString();
                btnC.BackColor = Color.YellowGreen;
            }
            else if (btnC.Text != dogruCevap)
            {
                btnC.BackColor = Color.IndianRed;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            button5.Enabled = true;
            button5.BackColor = Color.GreenYellow;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == dogruCevap)
            {
                puan += 10;
                label3.Text = puan.ToString();
                btnD.BackColor = Color.YellowGreen;
            }
            else if (btnD.Text != dogruCevap)
            {
                btnD.BackColor = Color.IndianRed;
            }
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            button5.Enabled = true;
            button5.BackColor = Color.GreenYellow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\24.Ders\müzik\muzik.mp3";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

        }
        int sure = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label4.Text = sure.ToString();
        }
    }
}
