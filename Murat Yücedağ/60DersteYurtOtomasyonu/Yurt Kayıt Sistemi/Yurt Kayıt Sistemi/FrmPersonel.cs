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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        void Temizle()
        {
            txtId.Clear();
            txtAdSoyad.Clear();
            cmbDepartman.Text ="";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbDepartman.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            btnGuncelle.Visible = true;
            btnSil.Visible = true;
            btnKaydet.Visible = false;
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet7.Personeller' table. You can move, or remove it, as needed.
            Listele();

        }

        private void Listele()
        {
            this.personellerTableAdapter.Fill(this.yurtKayitDataSet7.Personeller);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var baglan = baglanti.Baglan();
            SqlCommand komut = new SqlCommand("insert into personeller values (@adSoyad,@departman)", baglan);
            komut.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@departman", cmbDepartman.Text);
            komut.ExecuteNonQuery();
            baglanti.Cikis(baglan);
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personeller where Id=@id", baglanti.Baglan());
            komut.Parameters.AddWithValue("@id", txtId.Text);
            komut.ExecuteNonQuery();
            baglanti.Cikis(baglanti.Baglan());
            Listele();
            btnKaydet.Visible = true;
            btnGuncelle.Visible = false;
            btnSil.Visible = false;
            MessageBox.Show(txtAdSoyad.Text + " Silindi");
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personeller set AdSoyad=@adSoyad,Departman=@departman where Id=@id", baglanti.Baglan());
            komut.Parameters.AddWithValue("@id", txtId.Text);
            komut.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@departman", cmbDepartman.Text);
            komut.ExecuteNonQuery();
            baglanti.Cikis(baglanti.Baglan());
            Listele();
            btnKaydet.Visible = true;
            btnGuncelle.Visible = false;
            btnSil.Visible = false;
            MessageBox.Show(txtAdSoyad.Text + " Güncellendi");
            Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm  = new FrmAnaForm();
            frm.Show();
            this.Hide();
        }
    }
}
