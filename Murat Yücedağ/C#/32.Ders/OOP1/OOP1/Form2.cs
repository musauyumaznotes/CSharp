using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil otomobil = new Otomobil();
            otomobil.Marka = "Hyundai";
            otomobil.Model = "Accent";
            otomobil.ModelYili = 2015;
            otomobil.Renk = "Mavi";
            otomobil.VitesTipi = "Otomatik";

            //string marka = otomobil.MarkaGetir();
            label10.Text = otomobil.Marka.ToString();
            label9.Text = otomobil.Model.ToString();
            label8.Text = otomobil.ModelYili.ToString();
            label7.Text = otomobil.Renk.ToString();
            label6.Text = otomobil.VitesTipi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
