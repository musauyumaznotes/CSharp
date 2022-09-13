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
namespace Ders_5_Resim_Ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Dbo_FilmArsiv;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox5.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Filmler values(@filmad,@tur,@puan,@kategori,@resim)",baglanti);
            komut.Parameters.AddWithValue("@filmad",textBox1.Text);
            komut.Parameters.AddWithValue("@tur", textBox2.Text);
            komut.Parameters.AddWithValue("@puan",float.Parse(textBox3.Text));
            komut.Parameters.AddWithValue("@kategori", textBox4.Text);
            komut.Parameters.AddWithValue("@resim", textBox5.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbo_FilmArsivDataSet1.Tbl_Filmler' table. You can move, or remove it, as needed.
            this.tbl_FilmlerTableAdapter1.Fill(this.dbo_FilmArsivDataSet1.Tbl_Filmler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox6.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            pictureBox1.ImageLocation= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
