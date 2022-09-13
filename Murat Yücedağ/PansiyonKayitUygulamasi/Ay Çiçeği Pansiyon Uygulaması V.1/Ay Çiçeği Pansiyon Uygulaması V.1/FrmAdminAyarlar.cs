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
namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmAdminAyarlar : Form
    {
        public FrmAdminAyarlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update AdminGiris set KullaniciAdi=@kullaniciAdi , Sifre=@sifre", baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kullanıcı Adı ve Şifre Güncellendi Kullanıcı Adı: " +txtKullaniciAdi.Text +" Şifre: "+ txtSifre.Text  );
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }
    }
}
