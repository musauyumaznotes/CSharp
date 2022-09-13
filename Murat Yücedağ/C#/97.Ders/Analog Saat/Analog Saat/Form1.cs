using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analog_Saat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics = Graphics.FromImage(bitmap);
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            int[] ibreKoordinat = new int[2];
            graphics.Clear(Color.White);
            graphics.DrawEllipse(new Pen(Color.Black, 1F), 0, 0, yukseklik, genislik);

            graphics.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
            graphics.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            graphics.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            graphics.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

            ibreKoordinat = mscoord(ss, saniyeIbre);
            graphics.DrawLine(new Pen(Color.Red, 1F), new Point(ortaX, ortaY), new Point(ibreKoordinat[0], ibreKoordinat[1]));

            ibreKoordinat = mscoord(mm, dakikaIbre);
            graphics.DrawLine(new Pen(Color.Orange, 2F), new Point(ortaX, ortaY), new Point(ibreKoordinat[0], ibreKoordinat[1]));

            ibreKoordinat = hrcoord(hh % 12,mm, saatIbre);
            graphics.DrawLine(new Pen(Color.ForestGreen, 3F), new Point(ortaX, ortaY), new Point(ibreKoordinat[0], ibreKoordinat[1]));

            pictureBox1.Image = bitmap;

            this.Text = "Saat: " + hh + ":" + mm + ":" + ss;
            graphics.Dispose();
        }


        Timer timer = new Timer();
        int genislik = 300, yukseklik = 300, saniyeIbre = 140, dakikaIbre = 110, saatIbre = 80;
        int ortaX, ortaY;
        Bitmap bitmap;
        Graphics graphics;

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(genislik + 1, yukseklik + 1);
            ortaX = genislik / 2;
            ortaY = yukseklik / 2;
            this.BackColor = Color.White;
            timer.Interval = 1000;
            timer.Tick += new EventHandler(this.timer1_Tick);
            timer.Start();
        }
        private int[] mscoord(int saniyeDeger, int saatAci)
        {
            int[] coord = new int[2];
            saniyeDeger *= 6;
            if (saniyeDeger >= 0 && saniyeDeger <= 180)
            {
                coord[0] = ortaX + (int)(saatAci * Math.Sin(Math.PI * saniyeDeger / 180));
                coord[1] = ortaY - (int)(saatAci * Math.Cos(Math.PI * saniyeDeger / 180));
            }
            else
            {
                coord[0] = ortaX - (int)(saatAci * -Math.Sin(Math.PI * saniyeDeger / 180));
                coord[1] = ortaY - (int)(saatAci * Math.Cos(Math.PI * saniyeDeger / 180));
            }
            return coord;
        }
        int[] coord = new int[2];
        private int[] hrcoord(int saatDeger, int dakikaDeger, int saatAci)
        {
            int val = (int)((saatDeger * 30) + (dakikaDeger * 0.5));
            if (val >= 0 && val <= 180)
            {
                coord[0] = ortaX + (int)(saatAci * Math.Sin(Math.PI * val / 180));
                coord[1] = ortaY - (int)(saatAci * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = ortaX - (int)(saatAci * -Math.Sin(Math.PI * val / 180));
                coord[1] = ortaY - (int)(saatAci * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
    }
}
