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
namespace Devexpress_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=kisibilgiler;Integrated Security=True");
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            VerileriGoster();

        }

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from kisiler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ad"].ToString();
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["meslek"].ToString());
                ekle.SubItems.Add(oku["sehir"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kisiler(ad,soyad,meslek,sehir) values(@ad,@soyad,@meslek,@sehir)",baglanti);
            komut.Parameters.AddWithValue("@ad",textEdit1.Text);
            komut.Parameters.AddWithValue("@soyad", textEdit2.Text);
            komut.Parameters.AddWithValue("@meslek", textEdit3.Text);
            komut.Parameters.AddWithValue("@sehir", textEdit4.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }
    }
}
