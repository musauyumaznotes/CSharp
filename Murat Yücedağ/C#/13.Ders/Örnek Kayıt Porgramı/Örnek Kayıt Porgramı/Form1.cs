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

namespace Örnek_Kayıt_Porgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=localhost;Initial Catalog=kayıtlar;Integrated Security=True");
        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }
        private void veriGoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from gelenler",baglan);
            SqlDataReader oku= komut.ExecuteReader();

           

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["adSoyad"].ToString();
                ekle.SubItems.Add(oku["firma"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["semt"].ToString());
                listView1.Items.Add(ekle);
            }

            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            veriGoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            baglan.Open();

            SqlCommand komut = new SqlCommand("insert into gelenler(adSoyad,firma,telefon,semt) values('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+"','"+comboBox1.Text.ToString()+"') ",baglan);
            komut.ExecuteNonQuery();
            temizle();
            veriGoster();
            baglan.Close();
        }
    }
}
