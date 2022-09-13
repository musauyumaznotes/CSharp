using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmaOrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tekToplam = 0;
        int ciftToplam = 0;
        private void Temizle()
        {
            textBox1.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi%2==0)
            {
                ciftToplam = sayi + ciftToplam;
                lblCiftSayilarToplam.Text = ciftToplam.ToString();
            }
            else if (sayi %2 ==1)
            {
                tekToplam = sayi + tekToplam;
                lblTekSayilarToplam.Text = tekToplam.ToString();
            }
            Temizle();
        }
    }
}
