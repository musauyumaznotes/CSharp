using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DörtİşlemTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sonuc;
        

        private void IslemUret()
        {
            int sayi1, sayi2, islem;

            sayi1 = rastgele.Next(0, 51);
            sayi2 = rastgele.Next(0, 51);
            islem = rastgele.Next(1, 5);

            label1.Text = sayi1.ToString();
            label3.Text = sayi2.ToString();

            if (islem == 1)
            {
                label2.Text = "+";
                sonuc = sayi1 + sayi2;

            }
            else if (islem == 2)
            {
                label2.Text = "-";
                sonuc = sayi1 - sayi2;
            }
            else if (islem == 3)
            {
                label2.Text = "*";
                sonuc = sayi1 * sayi2;
            }
            else if (islem == 4)
            {
                label2.Text = "/";
                sonuc = sayi1 / sayi2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sure = 100;
            int cevap = Convert.ToInt32(textBox1.Text);
            if (cevap ==sonuc)
            {
                
                puan += 10;
                label7.Text = puan.ToString();
                IslemUret();
            }else
            {
                puan -= 10;
                label7.Text = puan.ToString();
                MessageBox.Show("Yanlış Tekrar Dene");
            }
            textBox1.Clear();
        }
        int puan = 0;
        int sure = 10;
        public void Form1_Load(object sender, EventArgs e)
        {
            IslemUret();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            label8.Text = sure.ToString();

            if (sure==0)
            {
                timer1.Stop();
                button2.Enabled = false;
                sure = 100;
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IslemUret();
            button2.Enabled = true;
            timer1.Start();
            puan = 0;
            label7.Text = puan.ToString();
            textBox1.Clear();
            button1.Visible = false;
        }
    }
}
