using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt_Kayıt_Sistemi
{
    public partial class FrmGiderDuzenle : Form
    {
        public FrmGiderDuzenle()
        {
            InitializeComponent();
        }
        FrmGiderListesi frmGiderListesi = new FrmGiderListesi();
        SqlBaglanti baglanti = new SqlBaglanti();
       
        public decimal elektrik, su, dogalgaz, internet, gida, personel, diger;

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }

        public int id;
        private void FrmGiderDuzenle_Load(object sender, EventArgs e)
        {
            txtElektrik.Text = elektrik.ToString();
            txtSu.Text = su.ToString();
            txtDogalgaz.Text = dogalgaz.ToString();
            txtInternet.Text = internet.ToString();
            txtGida.Text = gida.ToString();
            txtPersonel.Text = personel.ToString();
            txtDiger.Text = diger.ToString();
        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            elektrik =decimal.Parse(txtElektrik.Text);
            su = decimal.Parse(txtSu.Text);
            dogalgaz = decimal.Parse(txtDogalgaz.Text);
            internet = decimal.Parse(txtInternet.Text);
            personel = decimal.Parse(txtPersonel.Text);
            gida = decimal.Parse(txtGida.Text);
            diger = decimal.Parse(txtDiger.Text);


            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@elektrik,Su=@su,Dogalgaz=@dogalgaz,Internet=@internet,Gida=@gida,Personel=@personel,Diger=@diger where Id=@id ", baglanti.Baglan());
                komut.Parameters.AddWithValue("@elektrik", elektrik);
                komut.Parameters.AddWithValue("@su", su);
                komut.Parameters.AddWithValue("@dogalgaz", dogalgaz);
                komut.Parameters.AddWithValue("@internet", internet);
                komut.Parameters.AddWithValue("@gida", gida);
                komut.Parameters.AddWithValue("@personel", personel);
                komut.Parameters.AddWithValue("@diger", diger);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti.Cikis(baglanti.Baglan());
                MessageBox.Show("Veriler Güncellendi");

                frmGiderListesi.Listele();
                frmGiderListesi.Show();
                this.Hide();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Hata Mesajı: " + exception.Message);
                frmGiderListesi.Listele();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmGiderListesi.Listele();
            frmGiderListesi.Show();
            this.Hide();
        }
    }
}
