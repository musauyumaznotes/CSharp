using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Komutları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnMutlak_Click(object sender, EventArgs e)
        {
            double deger = Convert.ToDouble(textEdit1.Text);
            double pozitif = Math.Abs(deger);
            labelControl2.Text = pozitif.ToString();
        }

        private void btnUsteYuvarla_Click(object sender, EventArgs e)
        {
            double deger= Convert.ToDouble(textEdit1.Text); ;
            double yuvarla = Math.Ceiling(deger);
            labelControl2.Text = yuvarla.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            double deger = Convert.ToDouble(textEdit1.Text); ;
            double yuvarla = Math.Floor(deger);
            labelControl2.Text = yuvarla.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            double buyukDeger = Math.Max(4,5);
            labelControl2.Text = buyukDeger.ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            double kucukDeger = Math.Min(4, 5);
            labelControl2.Text = kucukDeger.ToString();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            double us = Math.Pow(2, 5);
            labelControl2.Text = us.ToString();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            double kok = Math.Sqrt(625);
            labelControl2.Text = kok.ToString();

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            double pi = Math.PI;
            labelControl2.Text = pi.ToString();
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            double deger = Math.IEEERemainder(12,5);
            labelControl2.Text = deger.ToString();
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            double deger = Math.Sin(90);
            labelControl2.Text = deger.ToString();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            double deger = Math.Cos(90);
            labelControl2.Text = deger.ToString();
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            double deger = Math.Tan(90);
            labelControl2.Text = deger.ToString();
        }

       
    }
}
