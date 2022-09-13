using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Kayıt_Uygulaması
{
    public partial class Daireler : Form
    {
        public Daireler()
        {
            InitializeComponent();
        }
        private void Renkler()
        {
            btnDaire1.BackColor = Color.Gray;
            btnDaire2.BackColor = Color.Gray;
            btnDaire3.BackColor = Color.Gray;
            btnDaire4.BackColor = Color.Gray;
            btnDaire5.BackColor = Color.Gray;
            btnDaire6.BackColor = Color.Gray;
            btnDaire7.BackColor = Color.Gray;
            btnDaire8.BackColor = Color.Gray;
        }
        private void btnDaire1_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire1.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Murat Yücedağ";
        }

        private void Daireler_Load(object sender, EventArgs e)
        {
            Renkler();
        }

        private void btnDaire2_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire2.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Baran Yücedağ";
        }

        private void btnDaire3_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire3.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Ali Yıldız";
        }

        private void btnDaire4_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire4.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Emel Kaya";
        }

        private void btnDaire5_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire5.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Musa Uyumaz";
        }

        private void btnDaire6_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire6.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Serhat Uyumaz";
        }

        private void btnDaire7_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire7.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Hasan Yeşil";
        }

        private void btnDaire8_Click(object sender, EventArgs e)
        {
            Renkler();
            btnDaire8.BackColor = Color.CadetBlue;
            lblAdSoyad.Text = "Nisan Öztürk";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
