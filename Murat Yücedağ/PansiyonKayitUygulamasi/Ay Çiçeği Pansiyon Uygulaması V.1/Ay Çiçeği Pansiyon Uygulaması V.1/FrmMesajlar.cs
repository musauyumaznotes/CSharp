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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar(AdSoyad,Mesaj) values (@adSoyad,@mesaj)", baglanti);
            komut.Parameters.AddWithValue("@adSoyad", textBox1.Text);
            komut.Parameters.AddWithValue("@mesaj", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MesajlarıListele();
            textBox1.Clear();
            textBox2.Clear();

        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            MesajlarıListele();
        }

        private void MesajlarıListele()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MesajId"].ToString();
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        int id = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
