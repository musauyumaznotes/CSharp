using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafik_İşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            float d1, d2, d3, toplam;
            d1 = float.Parse(txtDeger1.Text);
            d2 = float.Parse(txtDeger2.Text);
            d3 = float.Parse(txtDeger3.Text);

            toplam = d1 + d2 + d3;

            float pd1, pd2, pd3;
            pd1 = (d1 / toplam) * 360;
            pd2 = (d2 / toplam) * 360;
            pd3 = (d3 / toplam) * 360;

            Pen p = new Pen(Color.Black,4);

            Graphics g = this.CreateGraphics();

            Rectangle rec = new Rectangle(txtDeger1.Location.X + txtDeger1.Location.Y +200,100,250,260);

            Brush b1 = new SolidBrush(Color.Green);
            Brush b2 = new SolidBrush(Color.Pink);
            Brush b3 = new SolidBrush(Color.Yellow);

            g.Clear(Form1.DefaultBackColor);
            g.DrawPie(p,rec,0,pd1);
            g.FillPie(b1,rec,0,pd1);
            g.DrawPie(p, rec, pd1, pd2);
            g.FillPie(b2, rec, pd1, pd2);
            g.DrawPie(p, rec, pd1+pd2, pd3);
            g.FillPie(b3, rec, pd1+pd2, pd3);
        }
    }
}
