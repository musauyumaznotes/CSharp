using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayisalİslemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı, us, sonuc,karekok;
            
            sayı = Convert.ToDouble(txtSayi.Text);
            us = Convert.ToDouble(txtUs.Text);

            sonuc = Math.Pow(sayı,us);
            karekok = Math.Sqrt(sayı);
            lblSonuc.Text = sonuc.ToString();
            lblKarekok.Text = karekok.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModAlma modAlma = new ModAlma();
            modAlma.Show();
            this.Hide();
        }
    }
}
