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
    public partial class Borclar : Form
    {
        public Borclar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=apartman;Integrated Security=True");
        private void Borclar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Ad,Soyad,Borclar from kisibilgi",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Borclar"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
