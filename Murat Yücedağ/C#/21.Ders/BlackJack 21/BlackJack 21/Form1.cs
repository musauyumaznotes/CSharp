using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayac = 0;
        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            sayac++;
            if (sayac == 1)
            {

                int a1, a2;
                a1 = rastgele.Next(1, 11);
                a2 = rastgele.Next(1, 11);
                toplam = a1 + a2;

                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                lblToplam.Text = toplam.ToString();

            }
            else if (sayac == 2)
            {
                int a3 = rastgele.Next(1, 11);
                toplam += a3;
                label3.Text = a3.ToString();
                lblToplam.Text = toplam.ToString();
            }
            else if (sayac == 3)
            {
                int a4 = rastgele.Next(1, 11);
                toplam += a4;
                label4.Text = a4.ToString();
                lblToplam.Text = toplam.ToString();
                button1.Enabled = false;
            }

            if (toplam == 21)
            {

            }
            else if (toplam > 21)
            {

            }
            else if (toplam < 21)
            {

            }
            //-------------------------------------------------------------------//
            if (label1.Text == "1")
            {
                p1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\21.Ders\resimler\as.png";
            }
            if (label1.Text == "2")
            {
                p1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\21.Ders\resimler\2.png";
            }
            if (label1.Text == "3")
            {
                p1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\21.Ders\resimler\3.png";
            }
            if (label1.Text == "4")
            {
                p1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\21.Ders\resimler\4.png";
            }
            if (label1.Text == "5")
            {
                p1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\21.Ders\resimler\5.png";
            }
            if (label1.Text == "6")
            {
                p1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\21.Ders\resimler\6.png";
            }
            if (label1.Text == "7")
            {
                p1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\21.Ders\resimler\7.png";
            }
            if (label1.Text == "8")
            {
                p1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\21.Ders\resimler\8.png";
            }
            if (label1.Text == "9")
            {
                p1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\21.Ders\resimler\9.png";
            }
            if (label1.Text == "10")
            {
                p1.ImageLocation = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\21.Ders\resimler\kız.png";
            }


        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            int b1, b2,pcToplam;
            b1 = rastgele.Next(1, 11);
            b2 = rastgele.Next(1, 11);
            pcToplam = b1 + b2;


            label5.Text = b1.ToString();
            label6.Text = b2.ToString();
           lblPcToplam.Text = pcToplam.ToString();
           

            if (pcToplam < 18)
            {
                int b3 = rastgele.Next(1, 11);
                label7.Text = b3.ToString();
               
                pcToplam += b3;
                lblPcToplam.Text = pcToplam.ToString();
                if (pcToplam < 18)
                {
                    int b4 = rastgele.Next(1, 11);
                    label8.Text = b4.ToString();
                    pcToplam += b4;
                    lblPcToplam.Text = pcToplam.ToString();
                }
            }


            







        }
        int oyuncuPuan = 0;
        int bilgisayarPuan = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled= false;
            button4.Enabled = true;
            int oyuncuToplam, bilgisayarToplam;
            oyuncuToplam = Convert.ToInt32(lblToplam.Text);
            bilgisayarToplam = Convert.ToInt32(lblPcToplam.Text);

            if (oyuncuToplam>bilgisayarToplam && oyuncuToplam <=21)
            {
                oyuncuPuan += 10;
                label18.Text = oyuncuPuan.ToString();
            }
            else if (bilgisayarToplam > oyuncuPuan && bilgisayarToplam <= 21)
            {
                bilgisayarPuan += 10;
                label19.Text = bilgisayarPuan.ToString(); 
            }
            else if (bilgisayarToplam >21 && oyuncuToplam>21)
            {
                MessageBox.Show("Değerler büyük kazanan yok");
            }
            else if (bilgisayarToplam == oyuncuToplam &&oyuncuToplam<=21 &&bilgisayarToplam<=21)
            {
                MessageBox.Show("Beraberlik");
            }
            else if (bilgisayarToplam<=21 && oyuncuToplam > 21)
            {
                bilgisayarPuan += 10;
                label19.Text = bilgisayarPuan.ToString();
            }
            else if (oyuncuToplam <= 21 && bilgisayarToplam > 21)
            {
                oyuncuPuan += 10;
                label18.Text = oyuncuPuan.ToString();
            }

            if (oyuncuPuan ==50)
            {
                MessageBox.Show("Tebrikler Kazandınız");
            }
            if (bilgisayarPuan==50)
            {
                MessageBox.Show("Maalesef Kaybettiniz");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button4.Enabled = false;
        }
    }
}
