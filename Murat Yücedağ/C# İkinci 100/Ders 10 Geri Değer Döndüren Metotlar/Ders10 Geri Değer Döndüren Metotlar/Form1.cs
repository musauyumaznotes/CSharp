using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders10_Geri_Değer_Döndüren_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int toplam(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }
        private int carpim(int s1, int s2)
        {
            int s3 = s1 * s2;
            return s3;
        }
        private int bolum(int s1, int s2)
        {
            int s3 = s1 / s2;
            return s3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = toplam(7,3).ToString();
            label2.Text = carpim(9,3).ToString();
            label3.Text = bolum(18,6).ToString();
        }
    }
}
