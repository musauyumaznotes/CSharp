using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int toplamBen = 0;
        int toplamPc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(1,7);
            int b = rastgele.Next(1,7);
            int c = rastgele.Next(1,7);
            int d = rastgele.Next(1,7);

            toplamBen += a + b;
            toplamPc += c + d;

            lblToplamPuan.Text = toplamBen.ToString();
            label10.Text = toplamBen.ToString();

            lblPcToplamPuan.Text = toplamPc.ToString();
            label7.Text = toplamPc.ToString();
            if (a==1 ||c ==1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\11.Ders\\Resimler\\1.jpg";
            }
            else if (a == 2 ||c==2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\11.Ders\\Resimler\\2.jpg";
            }
            else if (a == 3 ||c==3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\11.Ders\\Resimler\\3.jpg";
            }
            else if (a == 4 ||c==4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\11.Ders\\Resimler\\4.jpg";
            }
            else if (a == 5 || c==5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\11.Ders\\Resimler\\5.jpg";
            }
            else if (a == 6 ||c==6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\11.Ders\\Resimler\\6.png";
            }


            if (b == 1 ||d==1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\11.Ders\\Resimler\\1.jpg";
            }
            else if (b == 2 ||d==2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\11.Ders\\Resimler\\2.jpg";
            }
            else if (b == 3||d==3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\11.Ders\\Resimler\\3.jpg";
            }
            else if (b == 4 ||d==4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\11.Ders\\Resimler\\4.jpg";
            }
            else if (b == 5 ||d==5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\11.Ders\\Resimler\\5.jpg";
            }
            else if (b == 6 ||d==6)
            { 
                pictureBox2.ImageLocation = "C:\\Users\\musau\\Desktop\\Murat Yücedağ\\C#\\11.Ders\\Resimler\\6.png";
            }




            lblZar1.Text = a.ToString();
            lblZar2.Text = b.ToString();
            lblPcZar1.Text = c.ToString();
            lblPcZar2.Text = d.ToString();
        }
    }
}
