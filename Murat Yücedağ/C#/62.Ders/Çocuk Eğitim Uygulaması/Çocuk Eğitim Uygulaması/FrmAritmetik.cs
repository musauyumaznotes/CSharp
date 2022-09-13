using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çocuk_Eğitim_Uygulaması
{
    public partial class FrmAritmetik : Form
    {
        public FrmAritmetik()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SoruUret();
                cevap = Convert.ToInt32(textBox1.Text);

                if (cevap == sonuc)
                {
                    puan += 10;
                    label7.Text = puan.ToString();
                }
                else
                {
                    puan -= 5;
                    label7.Text = puan.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");
            }
           

        }
        int cevap;
        int sonuc;
        int puan=0;
        private void SoruUret()
        {
            int a = rastgele.Next(11, 21);
            int b = rastgele.Next(1, 10);
            int c = rastgele.Next(1, 5);

            label1.Text = a.ToString();
            label3.Text = b.ToString();

            if (c == 1)
            {
                label2.Text = "+";
                sonuc = a + b;
            }
            if (c == 2)
            {
                label2.Text = "-";
                sonuc = a - b;
            }
            if (c == 3)
            {
                label2.Text = "*";
                sonuc = a * b;
            }
            if (c == 4)
            {
                label2.Text = "/";
                sonuc = a / b;
            }
        }

        private void FrmAritmetik_Load(object sender, EventArgs e)
        {
            SoruUret();
        }
    }
}
