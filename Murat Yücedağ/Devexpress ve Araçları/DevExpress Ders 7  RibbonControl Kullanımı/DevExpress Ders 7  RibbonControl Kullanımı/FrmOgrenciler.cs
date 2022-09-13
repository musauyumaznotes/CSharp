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
using System.Threading;

namespace DevExpress_Ders_7__RibbonControl_Kullanımı
{
    public partial class FrmOgrenciler : Form
    {
        public FrmOgrenciler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=TestDevExpress;Integrated Security=True");
        public void Listele()
        {

            SqlDataAdapter da = new SqlDataAdapter("exec OgrenciListe", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        public string ad, soyad, numara, kulup,id,yol,ortalama;

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            soyad = txtSoyad.Text;
        }

        private void txtNumara_TextChanged(object sender, EventArgs e)
        {
            numara = txtNumara.Text;
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            kulup = lookUpEdit1.EditValue.ToString();
        }

        private void txtOrtalama_TextChanged(object sender, EventArgs e)
        {
            ortalama = txtOrtalama.Text;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            id = txtId.Text;
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            yol = pictureEdit1.GetLoadedImageLocation();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtId.Text = dr[0].ToString();
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                txtNumara.Text = dr[3].ToString();
                txtOrtalama.Text = dr[4].ToString();
                lookUpEdit1.Text = dr[5].ToString();
                //pictureEdit1.GetLoadedImageLocation();

            int ortalama = Convert.ToInt16(txtOrtalama.Text);
                if (ortalama >= 0 && ortalama < 50)
                {
                    ratingControl1.EditValue = 1;
                }
                if (ortalama >= 50 && ortalama < 65)
                {
                    ratingControl1.EditValue = 2;
                }
                if (ortalama >= 65 && ortalama < 75)
                {
                    ratingControl1.EditValue = 3;
                }
                if (ortalama >= 75 && ortalama < 85)
                {
                    ratingControl1.EditValue = 4;
                }
                if (ortalama >= 85 && ortalama <= 100)
                {
                    ratingControl1.EditValue = 5;
                }
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            ad = txtAd.Text;
        }
        void KulupListele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TBLKULUPLER", baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            lookUpEdit1.Properties.ValueMember = "Id";
            lookUpEdit1.Properties.DisplayMember = "Ad";
            lookUpEdit1.Properties.DataSource = dataTable;

        }
        private void FrmOgrenciler_Load(object sender, EventArgs e)
        {
   
            Listele();
            KulupListele();
        }
    }
}
