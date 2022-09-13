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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Random sayi = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            char karakter;
            char[] dizi = { 'A', 'B', 'C', 'D', 'E' };
            int rakam = sayi.Next(0,dizi.Length);
            karakter = (dizi[rakam]);
            label1.Text = karakter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
