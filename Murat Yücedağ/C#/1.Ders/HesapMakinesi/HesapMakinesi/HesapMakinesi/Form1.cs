using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 =Convert.ToInt32 (textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int toplam = sayi1 + sayi2;
            label3.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox4.Text);
            int sonuc = a * b;
            label7.Text = sonuc.ToString();
        }
    }
}
