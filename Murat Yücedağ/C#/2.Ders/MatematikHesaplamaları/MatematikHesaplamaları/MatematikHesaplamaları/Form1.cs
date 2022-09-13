using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikHesaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar = Convert.ToInt32(textBox1.Text);
            
            int alan = birkenar * birkenar;
            int cevre = 4 * birkenar;
            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();
            

            
           

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button3.Visible = false;
            panel1.Visible = true;
            label7.Visible = false;
            textBox2.Visible = false;
            label1.Text = "KARE";
            label4.Text = "";
            label5.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button3.Visible = true;
            panel1.Visible = true;
            label7.Visible = true;
            textBox2.Visible = true;
            label1.Text = "DİKDÖRTGEN";
            label2.Text = "Kısa Kenar";
            label4.Text = "";
            label5.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int uzunKenar = Convert.ToInt32(textBox1.Text);
            int kisaKenar = Convert.ToInt32(textBox2.Text);

            int alan = kisaKenar * uzunKenar;
            int cevre = (kisaKenar * 2) + (uzunKenar * 2);

            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();
        }
    } 
}
