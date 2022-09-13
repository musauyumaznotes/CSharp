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
namespace Apartman_Kayıt_Uygulaması
{
    public partial class KayıtIslemleri : Form
    {
        public KayıtIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=apartman;Integrated Security=True");
        private void btnVerileriGoster_Click(object sender, EventArgs e)
        {
            VerileriListele();
        }

        private void VerileriListele()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kisibilgi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Daire"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void Temizle()
        {
            textEditAd.Text = "";
            textEditSoyad.Text = "";
            textEditDaire.Text = "";
            textEditTelefon.Text = "";
            textEditMail.Text = "";
            textEditBorc.Text = "";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kisibilgi(Ad,Soyad,Daire,Telefon,Mail,Borclar) values(@ad,@soyad,@daire,@telefon,@mail,@borclar)",baglanti);
            komut.Parameters.AddWithValue("@ad",textEditAd.Text);
            komut.Parameters.AddWithValue("@soyad", textEditSoyad.Text);
            komut.Parameters.AddWithValue("@daire", textEditDaire.Text);
            komut.Parameters.AddWithValue("@telefon", textEditTelefon.Text);
            komut.Parameters.AddWithValue("@mail", textEditMail.Text);
            komut.Parameters.AddWithValue("@borclar", textEditBorc.Text);
            komut.ExecuteNonQuery();
            Temizle();
            
            baglanti.Close();
            VerileriListele();
        }
        int id = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kisibilgi where id='"+id+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriListele();
            Temizle();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textEditAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textEditSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textEditDaire.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textEditTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textEditMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textEditBorc.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kisibilgi set Ad=@ad, Soyad=@soyad, Daire=@daire, Telefon=@telefon, Mail=@mail , Borclar=@borc where id='"+id+"'",baglanti);
            komut.Parameters.AddWithValue("@ad",textEditAd.Text);
            komut.Parameters.AddWithValue("@soyad", textEditSoyad.Text);
            komut.Parameters.AddWithValue("@daire", textEditDaire.Text);
            komut.Parameters.AddWithValue("@telefon", textEditTelefon.Text);
            komut.Parameters.AddWithValue("@mail", textEditMail.Text);
            komut.Parameters.AddWithValue("@borc", textEditBorc.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriListele();
            Temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kisibilgi where Ad like '%" +textEditAra.Text+ "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Daire"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
            
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
