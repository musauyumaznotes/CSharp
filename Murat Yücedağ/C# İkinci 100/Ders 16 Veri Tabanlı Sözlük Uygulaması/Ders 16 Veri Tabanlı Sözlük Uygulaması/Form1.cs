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
namespace Ders_16_Veri_Tabanlı_Sözlük_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\musau\Desktop\Murat Yücedağ\C# İkinci 100\Ders 16 Veri Tabanlı Sözlük Uygulaması\Database\dbSozluk.mdb");
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select ingilizce from sozluk", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                listBox1.Items.Add(dr[0].ToString());
            }
            baglanti.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox2.Text = listBox1.SelectedItem.ToString();
            baglanti.Open();
            OleDbCommand komutgetir = new OleDbCommand("select turkce from sozluk where ingilizce=@p1", baglanti);
            komutgetir.Parameters.AddWithValue("@p1", listBox1.SelectedItem);
            OleDbDataReader oku = komutgetir.ExecuteReader();
            while (oku.Read())
            {
                textBox2.Text = oku[0].ToString();
            }
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select ingilizce from sozluk where ingilizce like '" + textBox1.Text + "%'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                listBox1.Items.Add(oku[0].ToString());
            }

            baglanti.Close();
        }
    }
}
