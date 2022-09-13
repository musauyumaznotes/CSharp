using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şehir_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        string[] sehirListesi =
        {
            "ADANA","KOCAELİ","ADIYAMAN","KONYA","AFYONKARAHİSAR","KÜTAHYA","AĞRI","MALATYA","AMASYA","MANİSA","ANKARA",
            "KAHRAMANMARAŞ","ANTALYA","MARDİN","ARTVİN","MUĞLA","AYDIN","MUŞ","BALIKESİR","NEVŞEHİR","BİLECİK","NİĞDE","BİNGÖL",
            "ORDU","BİTLİS","RİZE","BOLU","SAKARYA","BURDUR" , "SAMSUN","BURSA","SİİRT","ÇANAKKALE","SİNOP","ÇANKIRI","SİVAS","ÇORUM",
            "TEKİRDAĞ","DENİZLİ","TOKAT","DİYARBAKIR","TRABZON","EDİRNE","TUNCELİ","ELAZIĞ","ŞANLIURFA","ERZİNCAN","UŞAK","ERZURUM",
            "VAN","ESKİŞEHİR","YOZGAT","GAZİANTEP","ZONGULDAK","GİRESUN","AKSARAY","GÜMÜŞHANE","BAYBURT","HAKKARİ","KARAMAN","HATAY",
            "KIRIKKALE","ISPARTA","BATMAN","MERSİN","ŞIRNAK","İSTANBUL","BARTIN","İZMİR","ARDAHAN","KARS","IĞDIR","KASTAMONU","YALOVA",
            "KAYSERİ","KARABÜK","KIRKLARELİ" ,"KİLİS","KIRŞEHİR","OSMANİYE","DÜZCE"
        };
        public Form1()
        {
            InitializeComponent();
        }
        string bulunacakSehirIsmi = "";
        int bulunanHarfSayisi=0;
        int kalanHak = 4;
        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            btnHarfGir.Enabled = false;
            btnTahmin.Enabled = false;

            this.AcceptButton = btnHarfGir;

        }
        private void YeniSehirSec()
        {
            int rastgeleSayi = rastgele.Next(0,sehirListesi.Length);
            bulunacakSehirIsmi = sehirListesi[rastgeleSayi];
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            bulunanHarfSayisi = 0;
            btnHarfGir.Enabled = true;
            btnTahmin.Enabled = true;
            lblGirilenHarfler.Text = "";
            kalanHak = 4;
            YeniSehirSec();

            grpOyunAlani.Controls.Clear();

            for (int i = 0; i < bulunacakSehirIsmi.Length; i++)
            {
                Label label = new Label();
                label.Location = new Point(20*i+30,20);
                label.Text = bulunacakSehirIsmi[i].ToString();
                label.Font = new System.Drawing.Font("Microsoft Sans Serif",8.50F,System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point,((byte)(162)));
                label.Size = new System.Drawing.Size(15, 20);
                label.BackColor = Color.Red;
                label.ForeColor = Color.Red;
                grpOyunAlani.Controls.Add(label);

            }
        }

        private void btnHarfGir_Click(object sender, EventArgs e)
        {
            bool harfVarmi = false;
            if (txtHarf.Text.Length !=1)
            {
                MessageBox.Show("Lütfen tek harf giriniz");
            }
            else
            {
                if (lblGirilenHarfler.Text.Contains(txtHarf.Text))
                {
                    MessageBox.Show("Bu harfi daha önce girdiniz");
                    txtHarf.Text = "";
                    txtHarf.Focus();

                    return;
                }
                foreach (Control item in grpOyunAlani.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        if (label.Text.ToUpper()==txtHarf.Text.ToUpper())
                        {
                            label.ForeColor = Color.Black;
                            label.BackColor = Color.Lime;
                            harfVarmi = true;
                            bulunanHarfSayisi++;
                        }
                    }
                }
            }
            if (!harfVarmi)
            {
                kalanHak--;
                lblKalanHak.Text = kalanHak.ToString();
                if (kalanHak==0)
                {
                    btnHarfGir.Enabled = false;
                    btnTahmin.Enabled = false;
                    MessageBox.Show("Oyun Bitti Kaybettiniz Yeni oyun için yeni oyun butonuna tıklayın   " +bulunacakSehirIsmi);
                }
            }
            lblGirilenHarfler.Text += txtHarf.Text + " ";
            if (bulunanHarfSayisi==bulunacakSehirIsmi.Length)
            {
                btnHarfGir.Enabled = false;
                btnTahmin.Enabled = false;
                MessageBox.Show("Oyun Bitti Tebrikler Gayet başarılı bir el geçirdiniz ve oyunu kazandınız :)");
            }
            txtHarf.Text = "";
            txtHarf.Focus();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (bulunacakSehirIsmi.ToUpper()==txtKelime.Text.ToUpper())
            {
                foreach (Control item in grpOyunAlani.Controls)
                {
                    if (item is Label)
                    {
                        Label label = item as Label;
                        label.ForeColor = Color.Black;
                        label.BackColor = Color.Lime;
                    }
                }
                MessageBox.Show("Oyun Bitti Tebrikler Kazandınız :)");
            }
            else
            {
                MessageBox.Show("Oyun Bitti Maalesef Kaybettiniz :(    "+bulunacakSehirIsmi);
            }
        }
    }
}
