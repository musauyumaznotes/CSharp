using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asansör_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            if (label8.Text =="1")
            {
                label4.BackColor = Color.Teal;
                label5.BackColor = Color.Teal;
                pictureBox1.Top -= 5;
                if (pictureBox1.Bottom <= 155)
                {
                    timer1.Stop();
                    label6.BackColor = Color.Yellow;
                    label7.BackColor = Color.Yellow;
                    button2.Enabled = true;
                    
                }
            }
            if (label8.Text =="0")
            {
                label6.BackColor = Color.Teal;
                label7.BackColor = Color.Teal;
                pictureBox1.Top += 5;
                if (pictureBox1.Bottom >= 420)
                {
                    timer1.Stop();
                    label4.BackColor = Color.Yellow;
                    label5.BackColor = Color.Yellow;
                    button1.Enabled = true;
                    
                }
            }
            
            
        }
    }
}
