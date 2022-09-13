using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Bilgilerr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +Application.StartupPath +"\\Bilgiler.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from Kisiler", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Sehir"].ToString());
                ekle.SubItems.Add(oku["Meslek"].ToString());
                ekle.SubItems.Add(oku["Yas"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kisiler (Ad,Soyad,Sehir,Meslek,Yas) values (@ad,@soyad,@sehir,@meslek,@yas)",baglanti);
            komut.Parameters.AddWithValue("@ad",textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@sehir", textBox3.Text);
            komut.Parameters.AddWithValue("@meslek", textBox4.Text);
            komut.Parameters.AddWithValue("@yas", textBox5.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }
    }
}
