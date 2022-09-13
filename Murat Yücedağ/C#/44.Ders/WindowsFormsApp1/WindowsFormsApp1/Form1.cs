using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac=0;
        string dogruCevap;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right && x<1000)
            {
                x += 5;
            }
            else if (e.KeyCode==Keys.Left && x > 0)
            {
                x -= 5;
            }
            else if (e.KeyCode==Keys.Up &&y<1000)
            {
                y -= 5;
            }
            else if (e.KeyCode==Keys.Down && y<500)
            {
                y += 5;
            }
            pictureBox1.Location = new Point(x,y);

            if (pictureBox1.Location.X>=640)
            {
                if (sayac==0)
                {
                    lblSoru.Text = "Türkiye Kaç Coğrafi Bölgeden Oluşur?";
                    lblA.Text = "7";
                    lblB.Text = "21";
                    lblC.Text = "63";
                    lblD.Text = "81";
                    dogruCevap = "7";
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblA_Click(object sender, EventArgs e)
        {
            if (lblA.Text == dogruCevap)
            {
                sayac += 1;
                lblSayac.Text = sayac.ToString();
            }
            else if (lblA.Text !=dogruCevap)
            {
                Point a = new Point();
                a.X = 0;
                a.Y = 120;
                pictureBox1.Location = a;

            }
        }

        private void lblB_Click(object sender, EventArgs e)
        {
            if (lblB.Text == dogruCevap)
            {
                sayac += 1;
                lblSayac.Text = sayac.ToString();
            }
            else if (lblB.Text !=dogruCevap)
            {
                Point a = new Point();
                a.X = 0;
                a.Y = 120;
                pictureBox1.Location = a;
            }

        }

        private void lblC_Click(object sender, EventArgs e)
        {
            if (lblC.Text == dogruCevap)
            {
                sayac += 1;
                lblSayac.Text = sayac.ToString();
            }
            else if (lblC.Text !=dogruCevap)
            {
                Point a = new Point();
                a.X = 0;
                a.Y = 120;
                pictureBox1.Location = a;
            }
        }

        private void lblD_Click(object sender, EventArgs e)
        {
            if (lblD.Text == dogruCevap)
            {
                sayac += 1;
                lblSayac.Text = sayac.ToString();
            }
            else if (lblD.Text !=dogruCevap)
            {
                Point a = new Point();
                a.X = 0;
                a.Y = 120;
                pictureBox1.Location = a;
            }
        }
    }
}
