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
        Random rastgele = new Random();
        int sure = 5;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            simpleButton1.Enabled = false;
            timer1.Start();
            int sayi1, sayi2, sayi3,sayi4,sayi5,sayi6,sayi7,sayi8,sayi9,sayi10,sayi11,sayi12;
            sayi1 = rastgele.Next(0, 50);
            sayi2 = rastgele.Next(0, 50);
            sayi3 = rastgele.Next(0, 50);
            sayi4 = rastgele.Next(0, 50);
            sayi5 = rastgele.Next(0, 50);
            sayi6 = rastgele.Next(0, 50);
            sayi7 = rastgele.Next(0, 50);
            sayi8 = rastgele.Next(0, 50);
            sayi9 = rastgele.Next(0, 50);
            sayi10 = rastgele.Next(0, 50);
            sayi11 = rastgele.Next(0, 50);
            sayi12 = rastgele.Next(0, 50);

            labelControl1.Text = sayi1.ToString();
            labelControl2.Text = sayi2.ToString();
            labelControl3.Text = sayi3.ToString();
            labelControl4.Text = sayi4.ToString();
            labelControl5.Text = sayi5.ToString();
            labelControl6.Text = sayi6.ToString();
            labelControl7.Text = sayi7.ToString();
            labelControl8.Text = sayi8.ToString();
            labelControl9.Text = sayi9.ToString();
            labelControl10.Text = sayi10.ToString();
            labelControl11.Text = sayi11.ToString();
            labelControl12.Text = sayi12.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (labelControl1.Text == textEdit1.Text && labelControl2.Text == textEdit2.Text && labelControl3.Text == textEdit3.Text && labelControl4.Text == textEdit4.Text && labelControl5.Text == textEdit5.Text && labelControl6.Text == textEdit6.Text && labelControl7.Text == textEdit7.Text && labelControl8.Text == textEdit8.Text && labelControl9.Text == textEdit9.Text && labelControl10.Text == textEdit10.Text && labelControl11.Text == textEdit11.Text && labelControl12.Text == textEdit12.Text)
            {
                MessageBox.Show("Tebrikler Oyunu Kazandınız Hafızanız Kuvvetli :)");
            }
            else
            {
                MessageBox.Show("Üzgünüz oyunu kaybettiniz daha güçlü bir hafıza ile yeniden deneyelim:(");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            labelControl13.Text = sure.ToString();

            if (sure==0)
            {
                timer1.Stop();
                sure = 5;
                groupBox1.Visible = false;
                
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            simpleButton1.Enabled = true;
            groupBox1.Visible = true;
            timer1.Start();
            simpleButton3.Enabled = true;
        }
    }
}
