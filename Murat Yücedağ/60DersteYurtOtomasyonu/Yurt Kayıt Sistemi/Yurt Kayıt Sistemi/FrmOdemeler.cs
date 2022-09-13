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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet2.BorcDetay' table. You can move, or remove it, as needed.
            BorcListele();

        }
        SqlBaglanti baglanti = new SqlBaglanti();
        private void BorcListele()
        {
            this.borcDetayTableAdapter.Fill(this.yurtKayitDataSet2.BorcDetay);
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }
        void Temizle()
        {
            txtOgrenciId.Clear();
            txtAd.Clear();
            txtOdenenMiktar.Clear();
            txtSoyad.Clear();
            lblKalanBorc.Text = "";
            dtpTarih.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtOgrenciId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            lblKalanBorc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            int kalan, odenen, yeniborc;
            odenen = Convert.ToInt16(txtOdenenMiktar.Text);
            kalan = Convert.ToInt16(lblKalanBorc.Text);
            yeniborc = kalan - odenen;
            lblKalanBorc.Text = yeniborc.ToString();
            int id = int.Parse(txtOgrenciId.Text);
            try
            {
                
                SqlCommand komut = new SqlCommand("update borclar set KalanBorc=@kalanBorc where Id='" + id + "'", baglanti.Baglan());
                komut.Parameters.AddWithValue("@kalanBorc", yeniborc);
                komut.ExecuteNonQuery();
                BorcListele();
                Temizle();
                baglanti.Cikis(baglanti.Baglan());
            }
            catch (Exception exception)
            {

                MessageBox.Show("Ödeme Alınamadı Hata var!!! Hata Mesajı:",exception.Message);
            }
            //Kasa Tablosu Eklemesi
            try
            {
                
                SqlCommand komut1 = new SqlCommand("insert into kasa values(@ogrId,@miktar,@tarih)",baglanti.Baglan());
                komut1.Parameters.AddWithValue("@miktar",odenen);
                komut1.Parameters.AddWithValue("@tarih",dtpTarih.Value);
                komut1.Parameters.AddWithValue("@ogrId", id);
                komut1.ExecuteNonQuery();
                BorcListele();
                Temizle();
                baglanti.Cikis(baglanti.Baglan());
            }
            catch (Exception exception)
            {

                MessageBox.Show("Ödeme Alınamadı Hata var!!! Hata Mesajı:", exception.Message);
            }

        }
    }
}
