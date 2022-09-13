using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayıtDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
            label6.Text = textBox2.Text;
            label11.Text = textBox3.Text;
            label8.Text = comboBox1.Text;
        }

       
    }
}
