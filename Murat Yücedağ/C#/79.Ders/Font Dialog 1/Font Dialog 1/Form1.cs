using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Font_Dialog_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fontum = new FontDialog();
            fontum.ShowDialog();
            labelControl1.Font = fontum.Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text, soyad = textBox2.Text;
            string ilce = Interaction.InputBox("İlçe Girin:","Kişi Bilgiler","İlçe:",50,50);
            labelControl1.Text = ad + " " + soyad + " " + ilce;
        }
    }
}
