using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
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
        int dakika = 0;
        int saniye = 0;
        int salise = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            salise++;

            label6.Text = salise.ToString();

            if (salise ==60)
            {
                salise = 0;
                label6.Text =salise.ToString();
                saniye++;
                label1.Text =saniye.ToString();
            }
            else if (saniye == 60)
            {
                saniye = 0;
                label1.Text =saniye.ToString();
                dakika++;
                label2.Text = dakika.ToString();
                
            }
           

        }
    }
}
