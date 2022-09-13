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
    public partial class FrmGelirIstatistik : Form
    {
        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(Miktar) from kasa", baglanti.Baglan());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasaToplam.Text = oku[0].ToString();
            }
            baglanti.Cikis(baglanti.Baglan());

            SqlCommand komut1 = new SqlCommand("set language turkish select distinct(datename(month,Tarih)) from Kasa", baglanti.Baglan());
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                cmbAy.Items.Add(oku1[0].ToString());

            }
            baglanti.Cikis(baglanti.Baglan());

            SqlCommand komut2 = new SqlCommand("set language turkish select distinct(datename(month,Tarih)) as 'Aylar', SUM(Miktar) as 'Toplam' from Kasa group by Tarih",baglanti.Baglan());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku2[0],oku2[1]);
            }
            baglanti.Cikis(baglanti.Baglan());
        }

        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("set language turkish select sum(Miktar) from Kasa where datename(month,Tarih) = @tarih", baglanti.Baglan());
            komut.Parameters.AddWithValue("@tarih", cmbAy.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblAyToplam.Text = oku[0].ToString();
            }
            baglanti.Cikis(baglanti.Baglan());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }
    }
}
