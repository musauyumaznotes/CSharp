using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafik2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics grafikNesne;
            grafikNesne = this.CreateGraphics();
            Brush fırca = new SolidBrush(System.Drawing.Color.Red);
            grafikNesne.FillRectangle(fırca, 20, 20, 200, 100);
            Brush fırca2 = new SolidBrush(System.Drawing.Color.Olive);
            grafikNesne.FillEllipse(fırca2,250,250,200,100);
        }
    }
}
