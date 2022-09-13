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
namespace BiletYolcuBilgiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0 ;Data Source =C:\Users\musau\Desktop\Murat Yücedağ\C#\27.Ders\Bilet.mdb");
        OleDbCommand komut = new OleDbCommand();
        
        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            komut.CommandText = "Select * from Bilgiler";
            komut.Connection = baglanti;
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["SeferNo"].ToString();
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["Ücret"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Biniş"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into Bilgiler (SeferNo,Tarih,Saat,AdSoyad,Telefon,KoltukNo,Ücret,Cinsiyet,Biniş)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')";
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
            Temizle();
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.Text = "1";
            button4.Enabled = false;
            button4.BackColor = Color.Green;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = "2";
            button5.Enabled = false;
            button5.BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "3";
            button6.Enabled = false;
            button6.BackColor = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox6.Text = "4";
            button7.Enabled = false;
            button7.BackColor = Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox6.Text = "5";
            button8.Enabled = false;
            button8.BackColor = Color.Green;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox6.Text = "6";
            button9.Enabled = false;
            button9.BackColor = Color.Green;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox6.Text = "7";
            button10.Enabled = false;
            button10.BackColor = Color.Green;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Text = "0";
            button3.Enabled = false;
            button3.BackColor = Color.Green;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Delete From Bilgiler where AdSoyad = '"+textBox4.Text+"'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Bilgiler set SeferNo='"+textBox1.Text+ "',Tarih='" + textBox2.Text + "',Saat='" + textBox3.Text + "',Telefon='" + textBox5.Text + "',KoltukNo='" + textBox6.Text + "',Ücret='" + textBox7.Text + "',Cinsiyet='" + comboBox1.Text + "',Biniş='" + comboBox2.Text + "', where AdSoyad='"+textBox4.Text+"'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
            Temizle();
        }
    }
}
