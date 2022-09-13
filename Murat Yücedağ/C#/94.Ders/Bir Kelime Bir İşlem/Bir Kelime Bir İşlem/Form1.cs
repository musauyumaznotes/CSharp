using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bir_Kelime_Bir_İşlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int harfSayac = 0;
        int sayiSayac = 0;
        private void btnHarfGetir_Click(object sender, EventArgs e)
        {
            harfSayac++;
            string karakter1, karakter2, karakter3, karakter4, karakter5, karakter6, karakter7, karakter8;
            int harfler;
            string[] dizi = { "A","B","C","Ç","D","E","F","G","Ğ","H","I","İ","J","K","L","M","N","O","Ö","P","R","S","Ş","T","U","Ü","V","Y","Z"};

            if (harfSayac==1)
            {
                harfler = rastgele.Next(0,dizi.Length);
                karakter1 = dizi[harfler];
                btnHarf1.Text = karakter1;
                btnHarf1.Visible = true;
            }
            if (harfSayac == 2)
            {
                harfler = rastgele.Next(0, dizi.Length);
                karakter2 = dizi[harfler];
                btnHarf2.Text = karakter2;
                btnHarf2.Visible = true;
            }
            if (harfSayac == 3)
            {
                harfler = rastgele.Next(0, dizi.Length);
                karakter3 = dizi[harfler];
                btnHarf3.Text = karakter3;
                btnHarf3.Visible = true;
            }
            if (harfSayac == 4)
            {
                harfler = rastgele.Next(0, dizi.Length);
                karakter4 = dizi[harfler];
                btnHarf4.Text = karakter4;
                btnHarf4.Visible = true;
            }
            if (harfSayac == 5)
            {
                harfler = rastgele.Next(0, dizi.Length);
                karakter5 = dizi[harfler];
                btnHarf5.Text = karakter5;
                btnHarf5.Visible = true;
            }
            if (harfSayac == 6)
            {
                harfler = rastgele.Next(0, dizi.Length);
                karakter6 = dizi[harfler];
                btnHarf6.Text = karakter6;
                btnHarf6.Visible = true;
            }
            if (harfSayac == 7)
            {
                harfler = rastgele.Next(0, dizi.Length);
                karakter7 = dizi[harfler];
                btnHarf7.Text = karakter7;
                btnHarf7.Visible = true;
            }
            if (harfSayac == 8)
            {
                harfler = rastgele.Next(0, dizi.Length);
                karakter8 = dizi[harfler];
                btnHarf8.Text = karakter8;
                btnHarf8.Visible = true;
                btnHarfJoker.Visible = true;
                btnHarfJoker.Text = "?";
            }
        }

        private void btnSayiGetir_Click(object sender, EventArgs e)
        {
            sayiSayac++;
            string deger1, deger2, deger3, deger4, deger5, deger6;
            string[] dizi2 = {"1","2","3","4","5","6","7","8","9" };
            string[] dizi3 = { "50","60","70"};
            int sayilar,deger7;

            if (sayiSayac==1)
            {
                sayilar = rastgele.Next(0,dizi2.Length);
                deger1 = dizi2[sayilar];
                btnSayi1.Text = deger1;
                btnSayi1.Visible = true;
            }
            if (sayiSayac == 2)
            {
                sayilar = rastgele.Next(0, dizi2.Length);
                deger2 = dizi2[sayilar];
                btnSayi2.Text = deger2;
                btnSayi2.Visible = true;
            }
            if (sayiSayac == 3)
            {
                sayilar = rastgele.Next(0, dizi2.Length);
                deger3 = dizi2[sayilar];
                btnSayi3.Text = deger3;
                btnSayi3.Visible = true;
            }
            if (sayiSayac == 4)
            {
                sayilar = rastgele.Next(0, dizi2.Length);
                deger4 = dizi2[sayilar];
                btnSayi4.Text = deger4;
                btnSayi4.Visible = true;
            }
            if (sayiSayac == 5)
            {
                sayilar = rastgele.Next(0, dizi2.Length);
                deger5 = dizi2[sayilar];
                btnSayi5.Text = deger5;
                btnSayi5.Visible = true;
            }
            if (sayiSayac == 6)
            {
                sayilar = rastgele.Next(0, dizi3.Length);
                deger6 = dizi3[sayilar];
                btnSayi6.Text = deger6;
                btnSayi6.Visible = true;
               
                
                deger7 = rastgele.Next(100, 500);
                btnSayi8.Text = deger7.ToString();
                btnSayi8.Visible = true;
                btnSayi7.Visible = true;
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            harfSayac = 0;
            sayiSayac = 0;
            btnSayi1.Visible = false;
            btnSayi2.Visible = false;
            btnSayi3.Visible = false;
            btnSayi4.Visible = false;
            btnSayi5.Visible = false;
            btnSayi6.Visible = false;
            btnSayi7.Visible = false;
            btnSayi8.Visible = false;
            btnHarfJoker.Visible = false;

            btnSayi1.Visible = false;
            btnSayi2.Visible = false;
            btnSayi3.Visible = false;
            btnSayi4.Visible = false;
            btnSayi5.Visible = false;
            btnSayi6.Visible = false;
            btnSayi7.Visible = false;
            btnSayi8.Visible = false;
        }
    }
}
