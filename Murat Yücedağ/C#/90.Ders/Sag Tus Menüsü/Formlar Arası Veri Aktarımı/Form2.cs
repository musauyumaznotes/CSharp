using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arası_Veri_Aktarımı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string kullaniciAdi;
        public string sifre;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = kullaniciAdi.ToString();
            label2.Text = sifre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
