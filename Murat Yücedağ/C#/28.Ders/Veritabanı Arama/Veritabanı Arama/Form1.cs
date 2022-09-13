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
namespace Veritabanı_Arama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=bilgi;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kisiler",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Yaş"].ToString());
                ekle.SubItems.Add(oku["İlçe"].ToString());
                ekle.SubItems.Add(oku["Meslek"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kisiler where Ad like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Yaş"].ToString());
                ekle.SubItems.Add(oku["İlçe"].ToString());
                ekle.SubItems.Add(oku["Meslek"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
