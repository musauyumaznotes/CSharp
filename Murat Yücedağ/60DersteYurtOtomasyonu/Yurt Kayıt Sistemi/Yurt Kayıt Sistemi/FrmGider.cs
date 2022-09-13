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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();

        void Temizle()
        {
            txtDiger.Clear();
            txtDogalgaz.Clear();
            txtElektrik.Clear();
            txtGida.Clear();
            txtInternet.Clear();
            txtPersonel.Clear();
            txtSu.Clear();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            decimal elektrik = Convert.ToDecimal(txtElektrik.Text);
            decimal su = Convert.ToDecimal(txtSu.Text);
            decimal dogalgaz = Convert.ToDecimal(txtDogalgaz.Text);
            decimal internet = Convert.ToDecimal(txtInternet.Text);
            decimal personel = Convert.ToDecimal(txtPersonel.Text);
            decimal diger = Convert.ToDecimal(txtDiger.Text);
            decimal gida = Convert.ToDecimal(txtGida.Text);
            try
            {
                SqlCommand komut = new SqlCommand("insert into Giderler values(@elektrik,@su,@dogalgaz,@internet,@gida,@personel,@diger)", baglanti.Baglan());
                komut.Parameters.AddWithValue("@elektrik",elektrik );
                komut.Parameters.AddWithValue("@su", su);
                komut.Parameters.AddWithValue("@dogalgaz", dogalgaz);
                komut.Parameters.AddWithValue("@internet",internet);
                komut.Parameters.AddWithValue("@gida", gida);
                komut.Parameters.AddWithValue("@personel",personel);
                komut.Parameters.AddWithValue("@diger", diger);
                komut.ExecuteNonQuery();
                baglanti.Cikis(baglanti.Baglan());
                MessageBox.Show("Veriler Kaydedildi");
            }
            catch (Exception exception)
            {

                MessageBox.Show("Hata Mesajı: "+exception.Message);
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }
    }
}
