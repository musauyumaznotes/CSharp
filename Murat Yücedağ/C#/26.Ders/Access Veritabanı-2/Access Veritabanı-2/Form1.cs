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
namespace Access_Veritabanı_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\musau\Desktop\Murat Yücedağ\C#\26.Ders\Veritabanı\KişiBilgileri.mdb; Persist Security Info=True");
        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from Kişiler",baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["İlçe"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kişiler (id,Ad,Soyad,İlçe,Ücret) values ('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString() + "','"+textBox3.Text.ToString() + "','"+textBox4.Text.ToString() + "','"+textBox5.Text.ToString() + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Delete From Kişiler Where id ='"+textBox6.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Update Kişiler set Ad='"+textBox2.Text+"',Soyad='"+textBox3.Text+"',İlçe='"+textBox4.Text+"',Ücret='"+textBox5.Text+"'where id='"+textBox1.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }
    }
}
