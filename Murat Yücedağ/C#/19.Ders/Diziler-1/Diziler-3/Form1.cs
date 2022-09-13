using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac;
        string[] isimler = new string[5];
        private void button1_Click(object sender, EventArgs e)
        {
            isimler[sayac] = textBox1.Text;
            sayac++;

            if (sayac==5)
            {
                sayac = 0;
                label1.Text = (sayac + 1) + ". ismi girin";
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                listBox1.Items.Add(isimler[i]);
            }
        }
    }
}
