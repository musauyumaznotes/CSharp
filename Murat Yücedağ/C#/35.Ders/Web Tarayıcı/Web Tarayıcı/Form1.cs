using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Web_Tarayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.yandex.com.tr");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.yahoo.com.tr");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.bing.com.tr");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.201:80/";
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://listen.powerapp.com.tr/powerturkeniyiler/abr/powerturkeniyiler/128/playlist.m3u8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://cast1.taksim.fm:8014/; ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void milliyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
        }

        private void fanatikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.fanatik.com.tr/");
        }

        private void onedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://onedio.com/");
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DodgerBlue;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void pempeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(webBrowser1.DocumentTitle.ToString());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(webBrowser1.DocumentText);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox1.Text = webBrowser1.Url.ToString();
            string tarih = DateTime.Now.Day+"."+DateTime.Now.Month+"."+DateTime.Now.Year;
            string zaman = DateTime.Now.Hour + "." + DateTime.Now.Minute + "." + DateTime.Now.Second;

            FileStream f = new FileStream("Gecmis.txt",FileMode.Append);
            StreamWriter yaz = new StreamWriter(f);
            yaz.WriteLine(tarih+"/"+zaman+"/"+webBrowser1.Url);
            yaz.Close();
            GecmisiYukle();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = webBrowser1.StatusText;

        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
            }
            catch (Exception)
            {

                toolStripProgressBar1.Minimum = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            GecmisiYukle();
        }
        private void GecmisiYukle()
        {
            listBox1.Items.Clear();
            StreamReader dosya = new StreamReader("Gecmis.txt");
            while (!dosya.EndOfStream)
            {
                listBox1.Items.Add(dosya.ReadLine());
            }
            dosya.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            StreamWriter dosya = new StreamWriter("Gecmis.txt");
            dosya.Write("");
            dosya.Close();
            GecmisiYukle();
        }
    }
}
