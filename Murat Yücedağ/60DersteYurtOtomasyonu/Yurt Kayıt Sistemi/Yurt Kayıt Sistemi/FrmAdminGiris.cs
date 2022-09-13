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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        private void btnGiris_Click(object sender, EventArgs e)
        {
           SqlCommand komut = new SqlCommand("select * from admin where KullaniciAd=@p1 and Sifre=@p2", baglanti.Baglan());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm frmAnaForm = new FrmAnaForm();
                frmAnaForm.Show();
                this.Hide();
              
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız Kullanıcı Adı ve Şifrenizi Kontrol ediniz");
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
                txtKullaniciAdi.Focus();

            }
            baglanti.Cikis(baglanti.Baglan());




        }
    }
}
