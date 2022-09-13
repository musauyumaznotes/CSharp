using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanıcıKayıtRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "deneme Dünya !!!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "C# dili derslerine hoşgeldiniz";        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Deneme Deneme";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }
    }
}
