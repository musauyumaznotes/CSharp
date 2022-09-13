using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = {1,2,3,4,5};
            int eleman = sayilar.Length;
            label1.Text = sayilar.Length.ToString();


            int[] sayilar2 = {1,2,3,4, 5,6,7,8,9,10 };
            int toplam = 0;

            foreach (int sayi in sayilar2)
            {
                toplam = toplam + sayi;
            }
            label1.Text = toplam.ToString();

            int[] sayilar3 = { 11, 12, 25, 36, 48, 66, 154,-25,-27,-39,-41 };

            foreach (int  sayi in sayilar3)
            {
                if (sayi%3==0 && sayi<0)
                {
                    listBox1.Items.Add(sayi);
                }
            }
        }

    }
}
