using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


        int derece = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            derece++;
            label7.Text = derece.ToString();

            int birinciAtinGenisligi = pictureBox1.Width;
            int ikinciAtinGenisligi = pictureBox2.Width;
            int ucuncuAtinGenisligi = pictureBox3.Width;

            int bitisUzakligi = label5.Left;

            pictureBox1.Left += rastgele.Next(10,20);
            pictureBox2.Left += rastgele.Next(10,20);
            pictureBox3.Left += rastgele.Next(10,20);

            if (pictureBox1.Left>pictureBox2.Left +5&&pictureBox1.Left>pictureBox3.Left+5)
            {
                label6.Text = "1 Numaralı At Yarışı Önde Götürüyor";
            }
            else if (pictureBox2.Left > pictureBox1.Left+5 && pictureBox2.Left > pictureBox3.Left+5)
            {
                label6.Text = "2 Numaralı At İyi Bir Atakla Öne Geçti";
            }
            else if (pictureBox3.Left > pictureBox1.Left+5 && pictureBox3.Left > pictureBox2.Left+5)
            {
                label6.Text = "3 Numaralı At Liderliği Ele Geçirdi";
            }



            if (birinciAtinGenisligi + pictureBox1.Left >= bitisUzakligi)
            {
                timer1.Enabled =false;
                label6.Text =("1 Numaralı At Kazandı!!!");
            }
            else if (ikinciAtinGenisligi + pictureBox2.Left >= bitisUzakligi)
            {
                timer1.Enabled = false;
                label6.Text = ("2 Numaralı At Kazandı!!!");
            }
            else if (ucuncuAtinGenisligi + pictureBox3.Left >= bitisUzakligi)
            {
                timer1.Enabled = false;
                label6.Text = ("3 Numaralı At Kazandı!!!");
            }
        }
        int birinciAtSolUzaklik, ikinciAtSolUzaklik, ucuncuAtSolUzaklik;
        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciAtSolUzaklik = pictureBox1.Left;
            ikinciAtSolUzaklik = pictureBox2.Left;
            ucuncuAtSolUzaklik= pictureBox3.Left;

        }
    }
}
