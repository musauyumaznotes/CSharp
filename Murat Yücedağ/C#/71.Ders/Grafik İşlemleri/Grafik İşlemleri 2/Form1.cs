using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafik_İşlemleri_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics grafikNesnem;
            grafikNesnem = this.CreateGraphics();
            Pen kalem = new Pen(System.Drawing.Color.BlueViolet,5);
            grafikNesnem.DrawLine(kalem,100,50,200,250);

            Rectangle dortgen = new Rectangle(20,20,250,200);
            grafikNesnem.DrawRectangle(kalem,dortgen);

            Rectangle elips = new Rectangle(20, 20, 250, 200);
            grafikNesnem.DrawEllipse(kalem, elips);
        }
    }
}
