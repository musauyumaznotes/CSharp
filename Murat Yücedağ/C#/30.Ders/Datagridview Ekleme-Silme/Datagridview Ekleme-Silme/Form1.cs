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
namespace Datagridview_Ekleme_Silme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=kutuphane1;Integrated Security=True");

        public void VerileriGoster()
        {

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from kitaplar", baglanti);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kitaplar (ad,yazar,sayfano,basımevi,tür) values(@adi,@yazari,@sayfanosu,@basımyeri,@tur)", baglanti);
            komut.Parameters.AddWithValue("@adi", textBox1.Text);
            komut.Parameters.AddWithValue("@yazari", textBox2.Text);
            komut.Parameters.AddWithValue("@sayfanosu", textBox3.Text);
            komut.Parameters.AddWithValue("@basımyeri", textBox4.Text);
            komut.Parameters.AddWithValue("@tur", comboBox1.Text);
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from kitaplar where ad=@adi",baglanti);
            komut.Parameters.AddWithValue("@adi", textBox5.Text);
            komut.ExecuteNonQuery();
            VerileriGoster();
            baglanti.Close();
            textBox5.Clear();
        }
    }
}
