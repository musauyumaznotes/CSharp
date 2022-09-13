using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renklerin_Dili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;
            if (kullaniciAdi=="yönetici"&& sifre=="12345")
            {
                Form2 renkFormu = new Form2();
                renkFormu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Giriş Yaptınız Yeniden Deneyiniz!!!");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
