using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klavye_Kontrolü_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.D)
            {
                x += 5;
            } 
            else if (e.KeyCode == Keys.A)
            {
                x -= 5;
            }
            else if (e.KeyCode == Keys.W)
            {
                y -= 5;
            }
            else if (e.KeyCode == Keys.S)
            {
                y += 5;
            }
            pictureBox1.Location = new Point(x, y);

            if (pictureBox1.Right>= label1.Left)
            {
                label1.BackColor = Color.Turquoise;
            }
            if (pictureBox1.Left <= label2.Right)
            {
                label2.BackColor = Color.Yellow;
            }
            if (pictureBox1.Bottom >= label3.Top)
            {
                label3.BackColor = Color.Tomato;
            }
            if (pictureBox1.Top <= label4.Bottom)
            {
                label4.BackColor = Color.Silver;
            }
        }
    }
}
