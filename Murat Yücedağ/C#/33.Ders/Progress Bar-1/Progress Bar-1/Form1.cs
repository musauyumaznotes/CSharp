using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Bar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           progressBar1.Value = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value +=10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
