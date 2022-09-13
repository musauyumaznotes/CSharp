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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=AycicegiPansiyon;Integrated Security=True");

        private void verilerGoster()
        {
            listView1.Items.Clear();  
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerGoster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='"+txtAdi.Text+"',Soyadi='"+txtSoyadi.Text+"',Cinsiyet='"+comboBox1.Text+ "',Telefon='" + maskTxtTelofon.Text + "',Mail='" + txtMail.Text + "',TC='" + txtTcKimlikNo.Text + "',OdaNo='" + txtOdaNumarası.Text + "',Ucret='" + txtUcret.Text + "',GirisTarihi='" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where Musteriid ='"+id+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Temizle();
            verilerGoster();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from MusteriEkle where Musteriid=("+id+")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerGoster();
            Temizle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where Adi like '%"+txtIsim.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        int id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            button2.Enabled = true;
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskTxtTelofon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTcKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNumarası.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            comboBox1.Text = "";
            maskTxtTelofon.Clear();
            txtMail.Clear();
            txtTcKimlikNo.Clear();
            txtOdaNumarası.Clear();
            txtUcret.Clear();
            dtpCikisTarihi.Text = "";
            dtpGirisTarihi.Text = "";
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            button2.Enabled = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set OdaNo='' where Musteriid='"+id+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Temizle();
            verilerGoster();

        }

       
    }
}//Data Source=localhost;Initial Catalog=AycicegiPansiyon;Integrated Security=True
