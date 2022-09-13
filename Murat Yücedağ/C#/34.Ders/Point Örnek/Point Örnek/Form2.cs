using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Örnek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point a = new Point();
            a.X = Convert.ToInt32(textBox1.Text);
            a.Y = Convert.ToInt32(textBox2.Text);
            pictureBox1.Location = a;
        }
    }
}
