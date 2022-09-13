using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace DevExpress_Ders_7__RibbonControl_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=TestDevExpress;Integrated Security=True");
        FrmOgrenciler ogrenciler = new FrmOgrenciler();
        private void btnOgrenciler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ogrenciler == null || ogrenciler.IsDisposed)
            {
                ogrenciler.MdiParent = this;
                ogrenciler.Show();
            }

        }

        private void btnOgrenciEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmProg frm = new FrmProg();
            frm.Show();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCILER(Ad,Soyad,Numara,KulupId) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", ogrenciler.ad);
            komut.Parameters.AddWithValue("@p2", ogrenciler.soyad);
            komut.Parameters.AddWithValue("@p3", ogrenciler.numara);
            komut.Parameters.AddWithValue("@p4", ogrenciler.kulup);
            komut.ExecuteNonQuery();
            baglanti.Close();
            XtraMessageBox.Show(ogrenciler.ad + " Kaydı sisteme yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrenciler.Listele();
            Temizle();
            frm.Hide();


        }
        void Temizle()
        {
            ogrenciler.txtId.Text = "";
            ogrenciler.txtAd.Text = "";
            ogrenciler.txtSoyad.Text = "";
            ogrenciler.txtNumara.Text = "";
            ogrenciler.txtOrtalama.Text = "";
            ogrenciler.lookUpEdit1.Text = "";
            ogrenciler.pictureEdit1.Image = null;
        }
        FrmHarita fr3;
        private void btnHaritalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr3 == null && fr3.IsDisposed)
            {
                fr3 = new FrmHarita();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBLOGRENCILER where Id=@id", baglanti);
            komut.Parameters.AddWithValue("@id", ogrenciler.id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            XtraMessageBox.Show(ogrenciler.ad + " Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrenciler.Listele();
            Temizle();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
        }

        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLOGRENCILER set KulupId=@kulup,Ad=@ad,Soyad=@soyad,Numara=@numara,Ortalama=@ortalama,Fotograf=@fotograf where Id=@id", baglanti);
            komut.Parameters.AddWithValue("@kulup", ogrenciler.kulup);
            komut.Parameters.AddWithValue("@ad", ogrenciler.ad);
            komut.Parameters.AddWithValue("@soyad", ogrenciler.soyad);
            komut.Parameters.AddWithValue("@numara", ogrenciler.numara);
            komut.Parameters.AddWithValue("@ortalama", ogrenciler.ortalama);
            komut.Parameters.AddWithValue("@fotograf", ogrenciler.yol);
            komut.Parameters.AddWithValue("@id", ogrenciler.id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            ogrenciler.Listele();
            Temizle();
        }
    }
}
