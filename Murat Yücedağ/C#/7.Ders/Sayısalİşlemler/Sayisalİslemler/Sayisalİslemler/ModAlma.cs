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
    public partial class ModAlma : Form
    {
        public ModAlma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);

            sonuc = sayi1 % sayi2;
            lblSonuc.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaatDakikaMod saatDakikaMod = new SaatDakikaMod();
            saatDakikaMod.Show();
            this.Hide();
        }
    }
}
