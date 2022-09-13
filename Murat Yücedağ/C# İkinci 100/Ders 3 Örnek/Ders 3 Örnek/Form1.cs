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
namespace Ders_3_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Dbo_FilmArsiv;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string s1, s2, v1, v2;
            s1 = textBox2.Text;
            s2 = textBox3.Text;
            v1 = textBox4.Text;
            v2 = textBox5.Text;

            try
            {
                baglanti.Open();
                // SqlCommand komut = new SqlCommand("Create Table " + textBox1.Text + "(Id tinyint, TurAd varchar(10),TurResim varchar(100))", baglanti);
                SqlCommand komut = new SqlCommand("Create Table " + textBox1.Text + "(" + s1 + " " + v1 + "," + s2 + " " + v2 + " )", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tablo Oluşturuldu");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu");
            }
        }
    }
}
