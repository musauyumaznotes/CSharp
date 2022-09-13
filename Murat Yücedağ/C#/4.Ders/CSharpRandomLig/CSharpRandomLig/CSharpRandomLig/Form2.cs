using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpRandomLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();

        int gsPuan = 0;
        int fbPuan = 0;
        int bjkPuan = 0;
        int tsPuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Visible = true;
           
            int a = rastgele.Next(0,5);
            int b = rastgele.Next(0,5);
            int c = rastgele.Next(0,5);
            int d = rastgele.Next(0,5);

            

            label5.Text = a.ToString();
            label6.Text = b.ToString();
            label8.Text = c.ToString();
            label7.Text = d.ToString();

            

            if (a>b)
            {
                gsPuan = gsPuan +3;
                lblGsPuan.Text = gsPuan.ToString();

            }
            else if (b>a)
            {
                fbPuan = fbPuan + 3;
                lblFbPuan.Text = fbPuan.ToString();
            }
            else
            {
                fbPuan = fbPuan + 1;
                gsPuan = gsPuan + 1;

                lblFbPuan.Text = fbPuan.ToString();
                lblGsPuan.Text = gsPuan.ToString();
            }

            if (c > d)
            {
                bjkPuan = bjkPuan + 3;
                lblBjkPuan.Text = bjkPuan.ToString();

            }
            else if (d > c)
            {
                tsPuan = tsPuan + 3;
                lblTsPuan.Text = tsPuan.ToString();
            }
            else
            {
                bjkPuan = bjkPuan + 1;
                tsPuan = tsPuan + 1;

                lblBjkPuan.Text = bjkPuan.ToString();
                lblTsPuan.Text = tsPuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Visible =true;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);



            label15.Text = a.ToString();
            label13.Text = b.ToString();
            label14.Text = c.ToString();
            label12.Text = d.ToString();



            if (a > b)
            {
                gsPuan = gsPuan + 3;
                lblGsPuan.Text = gsPuan.ToString();

            }
            else if (b > a)
            {
                bjkPuan = bjkPuan + 3;
                lblBjkPuan.Text = bjkPuan.ToString();
            }
            else
            {
                gsPuan = gsPuan + 1;
                bjkPuan = bjkPuan + 1;

                lblBjkPuan.Text = bjkPuan.ToString();
                lblGsPuan.Text = gsPuan.ToString();
            }

            if (c > d)
            {
                fbPuan = fbPuan + 3;
                lblFbPuan.Text = fbPuan.ToString();

            }
            else if (d > c)
            {
                tsPuan = tsPuan + 3;
                lblTsPuan.Text = tsPuan.ToString();
            }
            else
            {
                fbPuan = fbPuan + 1;
                tsPuan = tsPuan + 1;

                lblFbPuan.Text = fbPuan.ToString();
                lblTsPuan.Text = tsPuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible = true;
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);
           



            label29.Text = a.ToString();
            label27.Text = b.ToString();
            label28.Text = c.ToString();
            label26.Text = d.ToString();



            if (a > b)
            {
                gsPuan = gsPuan + 3;
                lblGsPuan.Text = gsPuan.ToString();

            }
            else if (b > a)
            {
                tsPuan = tsPuan + 3;
                lblTsPuan.Text = tsPuan.ToString();
            }
            else
            {
                gsPuan = gsPuan + 1;
                tsPuan = tsPuan + 1;

                lblTsPuan.Text = tsPuan.ToString();
                lblGsPuan.Text = gsPuan.ToString();
            }

            if (c > d)
            {
                fbPuan = fbPuan + 3;
                lblFbPuan.Text = fbPuan.ToString();

            }
            else if (d > c)
            {
                bjkPuan = bjkPuan + 3;
                lblBjkPuan.Text = bjkPuan.ToString();
            }
            else
            {
                fbPuan = fbPuan + 1;
                bjkPuan = bjkPuan + 1;

                lblFbPuan.Text = fbPuan.ToString();
                lblBjkPuan.Text = bjkPuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            axWindowsMediaPlayer1.Visible = true;
            int gsToplamPuan = Convert.ToInt32(lblGsPuan.Text);
            int bjkToplamPuan = Convert.ToInt32(lblBjkPuan.Text);
            int fbToplamPuan = Convert.ToInt32(lblFbPuan.Text);
            int tsToplamPuan = Convert.ToInt32(lblTsPuan.Text);

            if ((gsToplamPuan > bjkToplamPuan)&& (gsToplamPuan > fbToplamPuan)&& (gsToplamPuan > tsToplamPuan))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\4.Ders\\Müzikler\\gs.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\4.Ders\\Resimler\\gs.jpg";
            }
            else if ((fbToplamPuan > bjkToplamPuan) && (fbToplamPuan > gsToplamPuan) && (fbToplamPuan > tsToplamPuan))
                {
                axWindowsMediaPlayer1.URL = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\4.Ders\\Müzikler\\fb.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\4.Ders\\Resimler\\fb.png";
            }
            else if ((bjkToplamPuan > gsToplamPuan) && (bjkToplamPuan > fbToplamPuan) && (bjkToplamPuan > tsToplamPuan))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\4.Ders\\Müzikler\\bjk.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\4.Ders\\Resimler\\bjk.png";
            }
            else if ((tsToplamPuan > bjkToplamPuan) && (tsToplamPuan > fbToplamPuan) && (tsToplamPuan > gsToplamPuan))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\4.Ders\\Müzikler\\ts.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\4.Ders\\Resimler\\ts.jpg";
            }
            else
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\4.Ders\\Müzikler\\fb.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\4.Ders\\Resimler\\fb.png";

            }
        }
    }
}
