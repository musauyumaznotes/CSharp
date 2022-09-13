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
namespace Takvim_Örnek_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=takvim;Integrated Security=True");
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelControl1.Text = DateTime.Now.ToLongDateString();
            labelControl2.Text = DateTime.Now.ToLongTimeString();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void VerileriGoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from veriler where id="+comboBoxEdit1.Text+"", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                txtTarihteBugun.Text = oku["tarihtebugun"].ToString();
                txtSoz.Text = oku["gununsozu"].ToString();
                txtMenu.Text = oku["gununyemegi"].ToString();
                txtPratikBilgi.Text = oku["pratikbilgiler"].ToString();
                txtIsim.Text = oku["cocukismi"].ToString();
                txtKıssa.Text = oku["kıssadanhisse"].ToString();
            }
            baglanti.Close();
        }
    }
}
