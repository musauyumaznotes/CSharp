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
namespace Datagridview_Kütüphane_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=kutuphane1;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();

        }

        private void VerileriGoster()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from kitaplar", baglanti);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kitaplar (ad,yazar,sayfano,basımevi,tür) values (@kitapadi,@yazar,@sayfano,@basımevi,@tur)", baglanti);
            komut.Parameters.AddWithValue("@kitapadi", textBox1.Text);
            komut.Parameters.AddWithValue("@yazar", textBox2.Text);
            komut.Parameters.AddWithValue("@sayfano", textBox3.Text);
            komut.Parameters.AddWithValue("@basımevi", textBox4.Text);
            komut.Parameters.AddWithValue("@tur", textBox5.Text);
            komut.ExecuteNonQuery();
            VerileriGoster();
            baglanti.Close();

            Temizle();
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kitaplar where ad=@adi",baglanti);
            komut.Parameters.AddWithValue("@adi",textBox6.Text);
            komut.ExecuteNonQuery();
            VerileriGoster();
            
            baglanti.Close();
            textBox6.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kitaplar where ad like '%"+textBox7.Text+"%'",baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;
            string ad =dataGridView1.Rows[seciliAlan].Cells[0].Value.ToString();
            string yazar = dataGridView1.Rows[seciliAlan].Cells[1].Value.ToString();
            string sayfaNo = dataGridView1.Rows[seciliAlan].Cells[2].Value.ToString();
            string basımevi = dataGridView1.Rows[seciliAlan].Cells[3].Value.ToString();
            string tur = dataGridView1.Rows[seciliAlan].Cells[4].Value.ToString();

            textBox1.Text = ad;
            textBox2.Text = yazar;
            textBox3.Text = sayfaNo;
            textBox4.Text = basımevi;
            textBox5.Text = tur;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kitaplar set yazar='" + textBox2.Text + "' ,sayfano='" + textBox3.Text + "',basımevi='" + textBox4.Text + "',tür='" + textBox5.Text + "' where ad='" + textBox1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
            Temizle();

        }
    }
}
