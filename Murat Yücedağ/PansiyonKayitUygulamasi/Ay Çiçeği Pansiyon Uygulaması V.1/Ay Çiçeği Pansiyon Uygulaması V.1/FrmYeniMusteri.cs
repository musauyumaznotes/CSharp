using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "101";
        }
        
        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "102";
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "103";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "105";
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "106";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "109";
        }

        private void btnOda110_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "110";
        }

        private void btnOda111_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "111";
        }

        private void btnOda112_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "112";
        }

        private void btnOda113_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "113";
        }

        private void btnOda114_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "114";
        }

        private void btnOda115_Click(object sender, EventArgs e)
        {
            txtOdaNumarası.Text = "115";
        }

        private void btnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void btnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpCikisTarihi.Text);
            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label12.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label12.Text) * 250;
            txtUcret.Text = Ucret.ToString();

        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + comboBox1.Text + "','" + maskTxtTelofon.Text + "','" + txtMail.Text + "','" + txtTcKimlikNo.Text + "','" + txtOdaNumarası.Text + "','" + txtUcret.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");
            Temizle();
            DolulukKontrol();
            
        }

        private void Temizle()
        {
            txtAdi.Clear();
            txtMail.Clear();
            txtOdaNumarası.Clear();
            txtSoyadi.Clear();
            txtTcKimlikNo.Clear();
            txtUcret.Clear();
            maskTxtTelofon.Clear();
            dtpGirisTarihi.Text = "";
            dtpCikisTarihi.Text = "";
            comboBox1.Text = "";
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }
        string odaNo;
        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            DolulukKontrol();
        }

        private void DolulukKontrol()
        {
            Button[] buttons = { btnOda101, btnOda102, btnOda103, btnOda104, btnOda105, btnOda106, btnOda107, btnOda108, btnOda109, btnOda110, btnOda111, btnOda112, btnOda113, btnOda114, btnOda115 };
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Adi,Soyadi,OdaNo from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                odaNo = oku["OdaNo"].ToString();
                foreach (Button button in buttons)
                {
                    if (button.Text == odaNo)
                    {

                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }


                }

            }
            baglanti.Close();
        }
    } //Data Source=localhost;Initial Catalog=AycicegiPansiyon;Integrated Security=True
}
