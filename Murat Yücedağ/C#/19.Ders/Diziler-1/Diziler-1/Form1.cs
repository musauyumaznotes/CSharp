using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] gunler = new string[7];
            gunler[0] = "Pazartesi";
            gunler[1] = "Salı";
            gunler[2] = "Çarşamba";
            gunler[3] = "Perşembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";

            int[] dizi = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] sayilar = { 5, 6, 7 };
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            label1.Text = toplam.ToString();

        }
    }
}
