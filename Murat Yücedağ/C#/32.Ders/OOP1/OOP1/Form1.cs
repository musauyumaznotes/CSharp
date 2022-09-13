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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil otomobil = new Otomobil();
            otomobil.Marka = "Hyundai";
            otomobil.Model = "Getz";
            otomobil.ModelYili = 2013;
            otomobil.Renk = "Beyaz";
            otomobil.VitesTipi = "Manuel";

            //string marka = otomobil.MarkaGetir();
            label10.Text = otomobil.Marka.ToString();
            label9.Text = otomobil.Model.ToString();
            label8.Text = otomobil.ModelYili.ToString();
            label7.Text = otomobil.Renk.ToString();
            label6.Text = otomobil.VitesTipi.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
