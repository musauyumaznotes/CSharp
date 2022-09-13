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
namespace Ders_22_Excel_İle_Veri_Listeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\musau\Desktop\Murat Yücedağ\C# İkinci 100\Ders 22 Excel İle Veri Listeleme\Kitaplar.xlsx;Extended Properties='Excel 12.0 Xml; HDR=YES;'");
        void Veriler()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from [Sayfa1$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void Temizle()
        {
            txtKitapAd.Clear();
            txtFiyat.Clear();
            txtTur.Clear();
            txtYazar.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Veriler();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Veriler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into [Sayfa1$] values(@kitapad,@yazar,@tur,@fiyat)", baglanti);
            komut.Parameters.AddWithValue("@kitapad", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@tur", txtTur.Text);
            komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            Veriler();

        }
        int secilen = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update [Sayfa1$] set KitapAd=@kitapad,Yazar=@yazar,Tür=@tur,Fiyat=@fiyat where @Id=@id",baglanti);
            komut.Parameters.AddWithValue("@kitapad", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@tur", txtTur.Text);
            komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
            komut.Parameters.AddWithValue("@id", secilen);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Temizle();
            Veriler();
        }
    }
}
