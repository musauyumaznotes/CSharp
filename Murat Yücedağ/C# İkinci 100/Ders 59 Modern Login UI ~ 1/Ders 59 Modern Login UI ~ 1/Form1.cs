using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_59_Modern_Login_UI___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            textBox1.ForeColor = Color.FromArgb(0, 192, 192);

            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel3.BackColor = Color.White;
            textBox3.ForeColor = Color.White;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            textBox2.ForeColor = Color.FromArgb(0, 192, 192);

            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;

            panel3.BackColor = Color.White;
            textBox3.ForeColor = Color.White;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            panel3.BackColor = Color.FromArgb(0, 192, 192);
            textBox3.ForeColor = Color.FromArgb(0, 192, 192);

            panel2.BackColor = Color.White;
            textBox2.ForeColor = Color.White;

            panel1.BackColor = Color.White;
            textBox1.ForeColor = Color.White;
        }
        Form2 frm = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm.Left += 10;
            if (frm.Left >= 800)
            {
                timer1.Stop();
                this.TopMost = false;
                frm.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm.Left -= 10;
            if (frm.Left <= 500)
            {

            }timer2.Stop();
        }
    }
}
