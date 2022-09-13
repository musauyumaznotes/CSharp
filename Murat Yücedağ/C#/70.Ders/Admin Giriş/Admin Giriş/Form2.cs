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
namespace Admin_Giriş
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=guvenlik;Integrated Security=True");
        int id = 0;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update parola set Ad= @ad , Sifre=@sifre where id='"+id+"'",baglanti);
            komut.Parameters.AddWithValue();
            komut.ExecuteNonQuery();

            baglanti.Close();
            VerileriGoster();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from parola", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Sifre"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtKullaniciAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSifre.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
