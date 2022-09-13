using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renklerin_Dili
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Mavi")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi="+ " Mutluluğun ve pozitifliğin rengidir :) ";
                button2.BackColor = Color.Blue;
            }
            else if (comboBox1.Text == "Sarı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi=" + " İyimserliğin rengidir :) ";
                button2.BackColor = Color.Yellow;
            }
            else if (comboBox1.Text == "Yeşil")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi=" + " Bereketin rengidir :) ";
                button2.BackColor = Color.Green;
            }
            else if (comboBox1.Text == "Siyah")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi=" + " Karamsarlığın rengidir :) ";
                button2.BackColor = Color.Black;
            }
            else if (comboBox1.Text == "Kırmızı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi=" + " Tutkunun rengidir :) ";
                button2.BackColor = Color.Red;
            }
            else if (comboBox1.Text == "Beyaz")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + " rengi=" + " Mutluluğun ve pozitifliğin rengidir :) ";
                button2.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Seçim Yapılmadı");
            }

        }
    }
}
