using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[10];
        string [] ilce = new string[10];
        string[] telefon = new string[10];
        int i = 0;
        
        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            isimler[i] = textBox1.Text;
            ilce[i] = textBox2.Text;
            telefon[i] = textBox3.Text;
            i++;
            Temizle();
        }
        
        private void btnGoruntule_Click(object sender, EventArgs e)
        {

            i--;
            lblIsim.Text = isimler[i];
            lblIlce.Text = ilce[i];
            lblTelefon.Text = telefon[i];
        }
    }
}
