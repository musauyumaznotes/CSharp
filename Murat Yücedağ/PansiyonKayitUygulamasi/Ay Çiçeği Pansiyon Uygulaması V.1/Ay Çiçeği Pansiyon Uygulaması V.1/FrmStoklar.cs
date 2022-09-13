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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar (Gıda,Icecek,Cerezler) values(@gida,@icecek,@cerez)",baglanti);
            komut.Parameters.AddWithValue("@gida",txtGida.Text);
            komut.Parameters.AddWithValue("@icecek", txtIcecek.Text);
            komut.Parameters.AddWithValue("@cerez", txtAtistirmalik.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriListele();
            txtGida.Clear();
            txtIcecek.Clear();
            txtAtistirmalik.Clear();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            VerileriListele();
            FaturalariListele();
        }

        private void VerileriListele()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gıda"].ToString();
                ekle.SubItems.Add(oku["Icecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void FaturalariListele()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Elektrik"].ToString();
                ekle.SubItems.Add(oku["Su"].ToString());
                ekle.SubItems.Add(oku["Internet"].ToString());

                listView2.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Faturalar (Elektrik,Su,Internet) values(@elektrik,@su,@internet)", baglanti);
            komut.Parameters.AddWithValue("@elektrik", txtElektrik.Text);
            komut.Parameters.AddWithValue("@su", txtSu.Text);
            komut.Parameters.AddWithValue("@internet", txtInternet.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            FaturalariListele();
            txtElektrik.Clear();
            txtSu.Clear();
            txtInternet.Clear();
        }
    }
}
