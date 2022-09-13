using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders7_Struct_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct Kitap
        {
            public string kitapAd;
            public string tur;
            public string yazar;
            public int sayfa;
            public double puan;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap= new Kitap();
            kitap.kitapAd = "Beyaz Zambaklar Ülkesinde";
            kitap.tur = "Roman";
            kitap.yazar = "Grigory Petrov";
            kitap.sayfa =220;
            kitap.puan = 7.8;
            label4.Text = kitap.kitapAd;
            label5.Text =kitap.yazar;
            label6.Text =kitap.sayfa.ToString();
            label10.Text =kitap.tur;
            label11.Text =kitap.puan.ToString();
        }
    }
}
