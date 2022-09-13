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
    public partial class SaatDakikaMod : Form
    {
        public SaatDakikaMod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            int saat, dakika;
            sayi = Convert.ToInt32( txtDeger.Text);
            saat = sayi / 60;
            dakika = sayi % 60;
            lblSaat.Text = saat.ToString();
            lblDakika.Text = dakika.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModAlma modAlma = new ModAlma();
            modAlma.Show();
            this.Hide();
        }
    }
}
