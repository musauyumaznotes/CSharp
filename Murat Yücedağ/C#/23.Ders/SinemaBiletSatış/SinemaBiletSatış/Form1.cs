using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletSatış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0;
        int seansUcret = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            seans1++;
            seansUcret += 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seansUcret.ToString();

            if (seans1 == 30)
            {
                button1.Enabled = false;
            }
            if (seans1 >= 1)
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            seansUcret -= 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seansUcret.ToString();

            if (seans1 == 0)
            {
                button2.Enabled = false;
            }
            if (seans1 <= 10)
            {
                button1.Enabled = true;
            }
        }
        int seans2 = 0;
        int seans2Ucret = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            seans2++;
            seans2Ucret += 8;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2Ucret.ToString();

            if (seans2 == 30)
            {
                button4.Enabled = false;
            }
            if (seans2 >= 1)
            {
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seans2--;
            seans2Ucret -= 8;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2Ucret.ToString();

            if (seans2 == 0)
            {
                button3.Enabled = false;
            }
            if (seans2 <= 29)
            {
                button4.Enabled = true;
            }
        }

        int seans3 = 0;
        int seans3Ucret = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            seans3++;
            seans3Ucret += 8;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3Ucret.ToString();

            if (seans3 == 30)
            {
                button6.Enabled = false;
            }
            if (seans3 >= 1)
            {
                button5.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seans3--;
            seans3Ucret -= 8;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3Ucret.ToString();

            if (seans3 == 0)
            {
                button5.Enabled = false;
            }
            if (seans3 <= 29)
            {
                button6.Enabled = true;
            }
        }
        int mısır = 0;
        int mısırFiyat = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            mısır++;
            mısırFiyat += 3;
            textBox7.Text = mısır.ToString();
            textBox8.Text = mısırFiyat.ToString();

            if (mısır >=1)
            {
                button8.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mısır--;
            mısırFiyat -= 3;
            textBox7.Text = mısır.ToString();
            textBox8.Text = mısırFiyat.ToString();

            if (mısır == 0)
            {
                button8.Enabled = false;
            }
           
        }
        
       

        int kola = 0;
        int kolaFiyat = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            kola++;
            kolaFiyat += 2;
            textBox9.Text = kola.ToString();
            textBox10.Text = kolaFiyat.ToString();

            if (kola >= 1)
            {
                button9.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kola--;
            kolaFiyat -= 2;
            textBox9.Text = kola.ToString();
            textBox10.Text = kolaFiyat.ToString();

            if (kola == 0)
            {
                button9.Enabled = false;
            }

        }

        int su = 0;
        int suFiyat = 0;
        private void button12_Click(object sender, EventArgs e)
        {
            su++;
            suFiyat += 1;
            textBox11.Text = su.ToString();
            textBox12.Text = suFiyat.ToString();

            if (su >= 1)
            {
                button11.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            su--;
            suFiyat -= 1;
            textBox11.Text = su.ToString();
            textBox12.Text = suFiyat.ToString();

            if (su == 0)
            {
                button11.Enabled = false;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int seans1 =Convert.ToInt32(textBox1.Text);
            int seans2 =Convert.ToInt32(textBox3.Text);
            int seans3 =Convert.ToInt32(textBox5.Text);
            int seans1Ucret = Convert.ToInt32(textBox2.Text);
            int seans2Ucret = Convert.ToInt32(textBox4.Text);
            int seans3Ucret = Convert.ToInt32(textBox6.Text);
            int misirUcret = Convert.ToInt32(textBox8.Text);
            int kolaUcret = Convert.ToInt32(textBox10.Text);
            int suUcret = Convert.ToInt32(textBox12.Text);
            int toplamIcecekFiyati = misirUcret + kolaUcret + suUcret;

            int gunSonu = (seans1Ucret + seans2Ucret + seans3Ucret) + (misirUcret + kolaUcret + suUcret);
            int izleyiciToplam = seans1 + seans2 + seans3;
            label12.Text = izleyiciToplam.ToString();
            label13.Text = gunSonu.ToString() +" ₺";
            label17.Text = toplamIcecekFiyati.ToString()+" ₺" ;
        }
    }
}
