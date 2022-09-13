using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devexpress_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxControl1.Items.Add("Pendik");
            listBoxControl1.Items.Add("Üsküdar");

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Add("Kartal");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Add(textEdit1.Text);
        }

        private void checkEdit5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            imageSlider imageSlider = new imageSlider();
            imageSlider.Show();
            this.Hide();
        }
    }
}
