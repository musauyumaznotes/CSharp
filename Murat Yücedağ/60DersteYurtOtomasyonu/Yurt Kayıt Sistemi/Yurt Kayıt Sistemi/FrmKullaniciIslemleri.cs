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
    public partial class FrmKullaniciIslemleri : Form
    {
        public FrmKullaniciIslemleri()
        {
            InitializeComponent();
        }

        private void FrmKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet6.Admin' table. You can move, or remove it, as needed.
            Listele();

        }
        void Temizle()
        {
            txtId.Clear();
            txtKullaniciAd.Clear();
            txtSifre.Clear();
        }
        private void Listele()
        {
            this.adminTableAdapter.Fill(this.yurtKayitDataSet6.Admin);
        }

        SqlBaglanti baglanti = new SqlBaglanti();
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var baglan = baglanti.Baglan();
            SqlCommand komut = new SqlCommand("insert into admin values (@kullaniciAdi,@sifre)",baglan);
            komut.Parameters.AddWithValue("@kullaniciAdi",txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Cikis(baglan);
            Listele();
            Temizle();

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKullaniciAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            btnGuncelle.Visible = true;
            btnSil.Visible = true;
            btnKaydet.Visible = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from admin where Id=@id",baglanti.Baglan());
            komut.Parameters.AddWithValue("@id",txtId.Text);
            komut.ExecuteNonQuery();
            baglanti.Cikis(baglanti.Baglan());
            Listele();
            btnKaydet.Visible = true;
            btnGuncelle.Visible = false;
            btnSil.Visible = false;
            MessageBox.Show(txtKullaniciAd.Text+" Silindi");
            Temizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update admin set KullaniciAd=@kullaniciAdi,Sifre=@sifre where Id=@id", baglanti.Baglan());
            komut.Parameters.AddWithValue("@id", txtId.Text);
            komut.Parameters.AddWithValue("kullaniciAdi",txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("sifre",txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Cikis(baglanti.Baglan());
            Listele();
            btnKaydet.Visible = true;
            btnGuncelle.Visible = false;
            btnSil.Visible = false;
            MessageBox.Show(txtKullaniciAd.Text+" Güncellendi");
            Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Hide();
        }
    }
}
