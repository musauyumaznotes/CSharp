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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics grafikNesne;
            grafikNesne = this.CreateGraphics();
            Pen kalem = new Pen(System.Drawing.Color.Brown,2);
            grafikNesne.DrawArc(kalem,120,80,170,180,90,90);


        }
    }
}
