using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_13_Şifreleme_Algoritmaları_ToBase64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string anaMetin = textBox1.Text;
            byte [] veriDizim = ASCIIEncoding.ASCII.GetBytes(anaMetin);
            string sifreliMetin =Convert.ToBase64String(veriDizim);
            textBox2.Text = sifreliMetin;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metinCoz = textBox2.Text;
            byte[] veriDizimCozulen =Convert.FromBase64String(metinCoz);
            string anaMetin2 = ASCIIEncoding.ASCII.GetString(veriDizimCozulen);
            textBox1.Text = anaMetin2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
