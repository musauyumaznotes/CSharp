using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo =0;
        int dogru=0;
        int yanlis = 0;
        int zaman = 20;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 20;
            label9.Text = zaman.ToString();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;

            button5.Text = "İleri";
            soruNo++;
            label2.Text = soruNo.ToString();

            if (soruNo==1)
            {
                richTextBox1.Text = "Mustafa Kemal Atatürk Kaç Yılında Doğmuştur?";
                button1.Text = "1880";
                button2.Text = "1881";
                button3.Text = "1882";
                button4.Text = "1883";
                label4.Text = "1881";
            }
            else if (soruNo==2)
            {
                richTextBox1.Text = "Türkiye Kaç Cografi Bölgeye Ayrılır";
                button1.Text = "7";
                button2.Text = "8";
                button3.Text = "5";
                button4.Text = "3";
                label4.Text = "7";
            }
            else if (soruNo == 3)
            {
                richTextBox1.Text = "Türkiye'nin En Büyük Yüzölçümüne Sahip İli Aşağıdakilerden Hangisidir?";
                button1.Text = "Ankara";
                button2.Text = "İstanbul";
                button3.Text = "Diyarbakır";
                button4.Text = "Konya";
                label4.Text = "Konya";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled =false;
            button1.Enabled = false;
            button2.Enabled=false;
            button3.Enabled=false;
            button4.Enabled=false;
            button5.Enabled = true;

            if (button1.Text ==label4.Text)
            {
                dogru++;
                label5.Text=dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            if (button2.Text == label4.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            if (button4.Text == label4.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            if (button3.Text == label4.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;
            label9.Text = zaman.ToString();

            if (zaman ==0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }
    }
}
