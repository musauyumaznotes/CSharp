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
namespace Ders_21_SQL_de_Mükerrer_Kayıt_Engelleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=DersVeriTabanı;Integrated Security=True");
        bool durum;
        void mukerrer()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from bilgi where Numara=@numara", baglanti);
            komut.Parameters.AddWithValue("@numara", txtNumara.Text);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mukerrer();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into bilgi values(@numara,@adsoyad)", baglanti);
                komut.Parameters.AddWithValue("@numara", txtNumara.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtAdSoyad.Clear();
                txtNumara.Clear();
                MessageBox.Show("Kayıt Eklendi");
            }
            else
            {
                MessageBox.Show("Bu Numara daha önceden kullanıldı");
            }

        }
    }
}
