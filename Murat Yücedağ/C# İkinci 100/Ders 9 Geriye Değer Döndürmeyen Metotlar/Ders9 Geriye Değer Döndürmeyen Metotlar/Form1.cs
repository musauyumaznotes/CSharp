using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders9_Geriye_Değer_Döndürmeyen_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void metot1()
        {
            label1.Text = "29 Ağustos 2021";
            label2.Text = "Sıcak Bir Yaz Günü";
            label3.Text = "Peynir - Karpuz -su";
            label4.Text = "Eskişehir/Sivrihisar";
        }
        void metot2()
        {
            label1.BackColor = Color.OrangeRed;
            label2.BackColor = Color.Blue;
            label3.BackColor = Color.LightPink;
            label4.BackColor = Color.LemonChiffon;
        }
        void metot3()
        {
            label1.ForeColor = Color.White;
            this.Text = "C# Ders9/İkinci 100";
            MessageBox.Show("Ders Bitti");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            metot1();
            metot2();
            metot3();
        }
    }
}
