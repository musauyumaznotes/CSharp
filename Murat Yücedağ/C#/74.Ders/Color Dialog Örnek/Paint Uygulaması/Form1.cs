using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool ciz;
        int baslaX, baslaY;
        int kalınlık = 3;
        ColorDialog renkSec = new ColorDialog();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
            baslaX = e.X;
            baslaY = e.Y;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(renkSec.Color,kalınlık);

            Point point1 = new Point(baslaX,baslaY);
            Point point2 = new Point(e.X, e.Y);

            if (ciz==true)
            {
                g.DrawLine(p,point1,point2);
                baslaX = e.X;
                baslaY = e.Y;
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            renkSec.ShowDialog();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kalınlık = int.Parse(comboBoxEdit1.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
