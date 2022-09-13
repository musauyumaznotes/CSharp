using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Char_Değişkeni
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = textBox1.Text;
            char harf = Convert.ToChar(textBox2.Text);
            int toplam = 0;

            foreach (char karakter in cumle)
            {
                if (harf==karakter)
                {
                    toplam ++;
                }
            }
            label4.Text = toplam.ToString();
        }
    }
}
