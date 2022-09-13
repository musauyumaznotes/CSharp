using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IstanbulKocaeliSeyahat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre;
            kullaniciAdi = txtKullaniciAdi.Text;
            sifre = txtSifre.Text;

            if (kullaniciAdi=="yönetici" && sifre=="1234")
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Giriş yaptınız Tekrar Deneyiniz");
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
            }

        }
    }
}
