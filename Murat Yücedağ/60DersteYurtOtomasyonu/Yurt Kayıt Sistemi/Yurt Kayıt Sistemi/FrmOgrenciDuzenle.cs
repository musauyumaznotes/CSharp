using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt_Kayıt_Sistemi
{
    public partial class FrmOgrenciDuzenle : Form
    {
        public FrmOgrenciDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        FrmOgrenciListesi frm = new FrmOgrenciListesi();
        private void OdalariListele()
        {


            //Odaları Listeleme
            SqlCommand komut1 = new SqlCommand("select * from Odalar where Kapasite != Aktif", baglanti.Baglan());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut1);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            cmbOdaNo.ValueMember = "Id";
            cmbOdaNo.DisplayMember = "OdaNo";
            cmbOdaNo.DataSource = dataTable;
            baglanti.Cikis(baglanti.Baglan());
        }

        private void BolumleriListele()
        {


            //Bölümleri Listeleme
            baglanti.Baglan();
            SqlCommand komut = new SqlCommand("select * from bolumler", baglanti.Baglan());
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            cmbOgrBolum.ValueMember = "Id";
            cmbOgrBolum.DisplayMember = "Ad";
            cmbOgrBolum.DataSource = dataTable;
            baglanti.Cikis(baglanti.Baglan());
        }
        public int id;
        public string ad, soyad, tc, telefon, dogumTarihi, bolum, mail, odaNo, veliAdSoyad, veliTelefon, veliAdres;

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("delete from Borclar where OgrId=@ogrId", baglanti.Baglan());
            komut1.Parameters.AddWithValue("@ogrId", id);
            komut1.ExecuteNonQuery();
            baglanti.Baglan().Close();

            SqlCommand komut = new SqlCommand("delete from Ogrenciler where Id=@id", baglanti.Baglan());
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti.Baglan().Close();

            //Öğrenci Oda Kontenjanı Arttırma

            SqlCommand komutoda = new SqlCommand("update Odalar set Aktif = Aktif-1 where OdaNo=@oda1", baglanti.Baglan());
            komutoda.Parameters.AddWithValue("@oda1", cmbOdaNo.ValueMember);
            komutoda.ExecuteNonQuery();
            baglanti.Cikis(baglanti.Baglan());
            OdalariListele();
            BolumleriListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Hide();
        }

        

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenciler set Ad=@ad , Soyad=@soyad ,Tc=@tc ,Telefon=@telefon, DogumTarihi=@dogum,Mail=@mail, BolumId=@bolum, OdaId=@odaNo ,VeliAdSoyad=@veliAdSoyad, VeliTelefon=@veliTelefon, VeliAdres=@veliAdres where Id='" + id + "'", baglanti.Baglan());
                komut.Parameters.AddWithValue("@ad", txtOgrAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@dogum", txtDogum.Text);
                komut.Parameters.AddWithValue("@bolum", cmbOgrBolum.SelectedValue);
                komut.Parameters.AddWithValue("@mail", txtMail.Text);
                komut.Parameters.AddWithValue("@odaNo", cmbOdaNo.SelectedValue);
                komut.Parameters.AddWithValue("@veliAdSoyad", txtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@veliTelefon", txtVeliTelefon.Text);
                komut.Parameters.AddWithValue("@veliAdres", txtVeliAdres.Text);
                komut.ExecuteNonQuery();
                baglanti.Cikis(baglanti.Baglan());



            }
            catch (Exception exception)
            {

                MessageBox.Show(txtOgrAd.Text + " Eklenemedi Lütfen Kontrol Ediniz Hata Mesajı: " + exception.Message);
                OdalariListele();
                BolumleriListele();
            }
            this.Hide();
            frm.Show();
            frm.Listele();
            frm.Refresh();

        }

        private void FrmOgrenciDuzenle_Load(object sender, EventArgs e)
        {
            label12.Text = id.ToString();
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            txtTc.Text = tc;
            txtTelefon.Text = telefon;
            txtDogum.Text = dogumTarihi;
            cmbOgrBolum.Text = bolum;
            cmbOdaNo.Text = odaNo;
            txtMail.Text = mail;
            txtVeliAdSoyad.Text = veliAdSoyad;
            txtVeliTelefon.Text = telefon;
            txtVeliAdres.Text = veliAdres;

            OdalariListele();
            BolumleriListele();
        }
    }
}
