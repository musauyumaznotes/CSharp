using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Minİstanbul
{
    public partial class FrmCamiler : Form
    {
        public FrmCamiler()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\veritabanı\cami.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select sultanahmet from CamiAd",baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox1.Text = oku["sultanahmet"].ToString();
            }
            baglanti.Close();

            

            pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\sultanahmetcami.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/place/Sultan+Ahmet+Camii/@41.0054096,28.9768138,15z/data=!4m5!3m4!1s0x0:0xe52df7368a157ca4!8m2!3d41.0054096!4d28.9768138");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAnasayfa anasayfa = new FrmAnasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select yenicami from CamiAd", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox1.Text = oku["yenicami"].ToString();
            }
            baglanti.Close();



            pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\yenicami.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/dir//Valide+Sultan+Camii/data=!4m6!4m5!1m1!4e2!1m2!1m1!1s0x14caba280340572d:0x94e6767546b5cf37?sa=X&ved=2ahUKEwi274m-gJfyAhWT_7sIHZb4BUYQ9RcwJHoECGYQBA");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select ayasofya from CamiAd", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox1.Text = oku["ayasofya"].ToString();
            }
            baglanti.Close();



            pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\ayasofya.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/dir/39.4513302,31.5255809/ayasofya+cami/@40.2234559,28.561322,7z/data=!3m1!4b1!4m9!4m8!1m1!4e1!1m5!1m1!1s0x14cab9be92011c27:0x236e6f6f37444fae!2m2!1d28.980175!2d41.008583");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select ortaköy from CamiAd", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox1.Text = oku["ortaköy"].ToString();
            }
            baglanti.Close();



            pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\ortaköy.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/dir/39.4513302,31.5255809/ortak%C3%B6y+cami/@40.2234559,28.5794933,7z/data=!3m1!4b1!4m9!4m8!1m1!4e1!1m5!1m1!1s0x14cab7c8e42887ad:0xfd73f2a29eafc8bc!2m2!1d29.027009!2d41.0472515");

        }

        private void button5_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select fatih from CamiAd", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox1.Text = oku["fatih"].ToString();
            }
            baglanti.Close();



            pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\fatih.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/dir/39.4513302,31.5255809/fatih+cami+istanbul+nerede/@40.2042496,28.5504197,7z/data=!3m1!4b1!4m9!4m8!1m1!4e1!1m5!1m1!1s0x14caba21ca2b1031:0xbcb8746d3c867663!2m2!1d28.9501!2d41.0194314");


        }

        private void button6_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select beyazid from CamiAd", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox1.Text = oku["beyazid"].ToString();
            }
            baglanti.Close();



            pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\bayezid.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/dir/39.4513302,31.5255809/bayezid+cami/@40.1995581,28.5522434,7z/data=!3m1!4b1!4m9!4m8!1m1!4e1!1m5!1m1!1s0x14cab991d73292a1:0xc5894f505ceb16fa!2m2!1d28.9648614!2d41.010005");


        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select süleymaniye from CamiAd", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                richTextBox1.Text = oku["süleymaniye"].ToString();
            }
            baglanti.Close();



            pictureBox1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\52.Ders\resimler\süleymaniye.jpg";
            webBrowser1.Navigate("https://www.google.com/maps/dir//s%C3%BCleymaniye+cami/data=!4m6!4m5!1m1!4e2!1m2!1m1!1s0x14cab98d3ac01031:0x8accf5042157cfed?sa=X&ved=2ahUKEwj2zIeDgpfyAhWV_7sIHZ85B-kQ9RcwJnoECHIQBA");

        }

       
    }
}
