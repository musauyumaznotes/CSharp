using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çocuk_Eğitim_Uygulaması
{
    public partial class FrmEslestirKelime : Form
    {
        public FrmEslestirKelime()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = button5.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = button7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = button6.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Kedi" && label2.Text=="Cat")
            {
                button1.Enabled=false;
                button6.Enabled = false;
                button1.BackColor = Color.Yellow;
                button6.BackColor = Color.Yellow;

            }
            if (label1.Text == "Köpek" && label2.Text == "Dog")
            {
                button2.Enabled = false;
                button10.Enabled = false;
                button2.BackColor = Color.Yellow;
                button10.BackColor = Color.Yellow;
            }
            if (label1.Text == "At" && label2.Text == "Horse")
            {
                button3.Enabled = false;
                button7.Enabled = false;
                button3.BackColor = Color.Yellow;
                button7.BackColor = Color.Yellow;
            }
            if (label1.Text == "Kuş" && label2.Text == "Bird")
            {
                button4.Enabled = false;
                button9.Enabled = false;
                button4.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
            }
            if (label1.Text == "İnek" && label2.Text == "Cow")
            {
                button5.Enabled = false;
                button8.Enabled = false;
                button5.BackColor = Color.Yellow;
                button8.BackColor = Color.Yellow;
            }

        }
    }
}
