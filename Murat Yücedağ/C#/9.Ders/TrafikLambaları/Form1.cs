using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafikLambaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
        }
        int sayi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi++;
             label1.Text = sayi.ToString();

            if (sayi==0)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;

            }
            else if (sayi==20)
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Yellow;
            }
            else if (sayi == 30)
            {

                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
            }
            else if (sayi == 60)
            {
                sayi = 0;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            
        }
    }
}
