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
namespace Yurt_Kayıt_Sistemi
{
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
       SqlBaglanti baglanti = new SqlBaglanti();
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet.Bolumler' table. You can move, or remove it, as needed.
            Listele();

        }

        private void Listele()
        {
            this.bolumlerTableAdapter.Fill(this.yurtKayitDataSet.Bolumler);
        }

        private void pcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komut = new SqlCommand("insert into Bolumler values(@ad)", baglanti.Baglan());
                komut.Parameters.AddWithValue("@ad", txtBolumAd.Text);
                komut.ExecuteNonQuery();
                baglanti.Cikis(baglanti.Baglan());
                MessageBox.Show("Bölüm Eklendi");
                Listele();
                txtBolumAd.Clear();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Hata Oluştu " + exception.Message);
            }

        }

        private void pcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
               
                SqlCommand komut = new SqlCommand("Delete From Bolumler where Id='" + id + "'", baglanti.Baglan());
                komut.ExecuteNonQuery();
                baglanti.Cikis(baglanti.Baglan());
                Listele();
            }
            catch (Exception exception)
            {

                MessageBox.Show("hata Oluştu  " + exception.Message);
            }
            txtBolumAd.Clear();
            textBox1.Clear();


        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            textBox1.Text = id;
            txtBolumAd.Text = bolumad;
        }

        private void pcbBolumGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
               
                SqlCommand komut = new SqlCommand("Update Bolumler set Ad=@ad where Id=@id", baglanti.Baglan());
                komut.Parameters.AddWithValue("@ad", txtBolumAd.Text);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti.Cikis(baglanti.Baglan());
                Listele();
                txtBolumAd.Clear();
                textBox1.Clear();
            }
            catch (Exception exception)
            {

                MessageBox.Show("hata Oluştu  " + exception.Message);
            }
            txtBolumAd.Clear();
            textBox1.Clear();

          
        }
    }
}
