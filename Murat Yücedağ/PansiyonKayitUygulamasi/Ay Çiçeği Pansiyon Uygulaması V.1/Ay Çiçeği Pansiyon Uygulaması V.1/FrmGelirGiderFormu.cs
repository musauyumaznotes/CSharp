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
namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmGelirGiderFormu : Form
    {
        public FrmGelirGiderFormu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        int gida = 0, icecek = 0, atistirmaliklar = 0, elektrik = 0, su = 0, internet = 0 ,kasa=0, toplam=0 , maas=0;

        private void FrmGelirGiderFormu_Load(object sender, EventArgs e)
        {
            GelirGider();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int personelSayisi = Convert.ToInt32(maskedTextBox1.Text);
            maas = (personelSayisi * 2826);
            lblPersonelMaas.Text = maas.ToString();

            toplam = kasa - (gida + icecek + atistirmaliklar + elektrik + su + internet+ maas);
            lblEldeKalan.Text = toplam.ToString();
        }

        private void GelirGider()
        {
            //Gıda
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select sum(Gıda) as Toplam from Stoklar ", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                gida = Convert.ToInt32(oku1["Toplam"]);
            }
            baglanti.Close();
            //İçecek
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Icecek) as Toplam from Stoklar ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                icecek = Convert.ToInt32(oku2["Toplam"]);
            }
            baglanti.Close();
            //Atıştırmalık
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(Cerezler) as Toplam from Stoklar ", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                atistirmaliklar = Convert.ToInt32(oku3["Toplam"]);
            }
            baglanti.Close();
            lblAlinanUrun.Text = (gida + icecek + atistirmaliklar).ToString();
            //kasa
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as Toplam from MusteriEkle ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kasa = Convert.ToInt32(oku["Toplam"]);
                lblKasa.Text = kasa.ToString();
            }
            baglanti.Close();

            

            //Elektrik
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Elektrik) as Toplam from Faturalar ", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                elektrik = Convert.ToInt32(oku4["Toplam"]);
            }
            baglanti.Close();
            //Su
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Su) as Toplam from Faturalar ", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                su = Convert.ToInt32(oku5["Toplam"]);
            }
            baglanti.Close();
            //İnternet
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Internet) as Toplam from Faturalar ", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                internet = Convert.ToInt32(oku6["Toplam"]);
            }
            baglanti.Close();

            lblFatura.Text = (elektrik + su + internet).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }
    }
}
