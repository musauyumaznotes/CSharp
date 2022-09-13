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
namespace Ders_15_İlişkili_Tablolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=DboSehirListesi;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SehirAd from Tbl_Sehirler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0]);
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IlceAd from Tbl_Ilceler where IlId=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", comboBox1.SelectedIndex + 1);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox2.Items.Add(oku[0]);
            }
            baglanti.Close();
        }
    }
}
