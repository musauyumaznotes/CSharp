using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafik_2._2
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
            Font yazıStilim = new System.Drawing.Font("Segoe Print",50,FontStyle.Bold);
            Brush fırca = new SolidBrush(System.Drawing.Color.HotPink);
            grafikNesnem.DrawString("C@ Dersleri Ders 72",yazıStilim,fırca,30,30);
        }
    }
}
