using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            int kontrol = 0;
            int sayi = Convert.ToInt32(txtSayi.Text);

            if (sayi==0 && sayi==1)
            {
                textBox2.Text = "Sayı Asal Değildir";
            }
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol++;
                    break;
                }
               
            }
            if (kontrol!=0)
            {
                textBox2.Text = "Sayı Asal Değildir";
            }
            else
            {
                textBox2.Text = "Asal Sayıdır";
            }
        }
    }
}
