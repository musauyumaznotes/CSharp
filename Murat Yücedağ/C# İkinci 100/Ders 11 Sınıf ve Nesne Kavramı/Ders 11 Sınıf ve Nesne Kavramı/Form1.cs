using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_11_Sınıf_ve_Nesne_Kavramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Arabalar rb = new Arabalar();
            rb.renk = "Mavi";
            rb.fiyat = 32.475;
            rb.durum = 's';
            rb.model = 2017;
            rb.hiz = 220;

            label1.Text = rb.renk;
            label2.Text = rb.model.ToString();
            label3.Text = rb.hiz.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();

            this.BackColor = Color.CadetBlue;
            
        }
    }
}
