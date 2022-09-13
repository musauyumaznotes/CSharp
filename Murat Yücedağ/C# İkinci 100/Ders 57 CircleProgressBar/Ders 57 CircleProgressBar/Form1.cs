using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_57_CircleProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;

            circularProgressBar1.Text = circularProgressBar1.Value.ToString();

            if (circularProgressBar1.Value==100)
            {
                timer1.Stop();
            }
        }
    }
}
