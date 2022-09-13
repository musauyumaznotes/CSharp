using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Yurt_Kayıt_Sistemi
{
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        private void Form1_Load(object sender, EventArgs e)
        {
            BolumleriListele();
            OdalariListele();

        }

        public void OdalariListele()
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

        public void BolumleriListele()
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut = new SqlCommand("insert into Ogrenciler(Ad, Soyad, Tc, Telefon, DogumTarihi,Mail, BolumId, OdaId, VeliAdSoyad, VeliTelefon, VeliAdres) values(@ad,@soyad,@tc,@telefon,@dogum,@mail,@bolum,@odaNo,@veliAdSoyad,@veliTelefon,@veliAdres)", baglanti.Baglan());
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
                MessageBox.Show(txtOgrAd.Text + " Eklendi");
                Temizle();
                OdalariListele();
                BolumleriListele();

                SqlCommand komut2 = new SqlCommand("select Id From Ogrenciler",baglanti.Baglan());
                SqlDataReader oku = komut2.ExecuteReader();
                while (oku.Read())
                {
                   
                    label12.Text = oku[0].ToString();
                }


                int ogrId = int.Parse(label12.Text);
                SqlCommand komut1 = new SqlCommand("insert into Borclar(OgrId) values(@b1)",baglanti.Baglan());
                komut1.Parameters.AddWithValue("@b1",ogrId);
                komut1.ExecuteNonQuery();
                baglanti.Cikis(baglanti.Baglan());

            }
            catch (Exception exception)
            {

                MessageBox.Show(txtOgrAd.Text + " Eklenemedi Lütfen Kontrol Ediniz Hata Mesajı: " + exception.Message);
                OdalariListele();
                BolumleriListele();

            }

            //Öğrenci Oda Kontenjanı Arttırma

            SqlCommand komutoda = new SqlCommand("update Odalar set Aktif=Aktif+1 where OdaNo=@odaNo",baglanti.Baglan());
            komutoda.Parameters.AddWithValue("@odaNo",cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            baglanti.Cikis(baglanti.Baglan());
            OdalariListele();
            BolumleriListele();

        }
        void Temizle()
        {
            txtOgrAd.Clear();
            txtOgrSoyad.Clear();
            txtTc.Clear();
            txtTelefon.Clear();
            txtDogum.Clear();
            cmbOgrBolum.Text = "";
            txtMail.Clear();
            cmbOdaNo.Text = "";
            txtVeliAdSoyad.Clear();
            txtVeliTelefon.Clear();
            txtVeliAdres.Clear();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }
    }
}
