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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        string odaNo;
        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            OdaTakip();

        }

        public void OdaTakip()
        {
            Button[] buttons = { btnOda101, btnOda102, btnOda103, btnOda104, btnOda105, btnOda106, btnOda107, btnOda108, btnOda109, btnOda110, btnOda111, btnOda112, btnOda113, btnOda114, btnOda115 };
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Adi,Soyadi,OdaNo from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                odaNo = oku["OdaNo"].ToString();
                foreach (Button button in buttons)
                {
                    if (button.Text == odaNo)
                    {
                        button.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }


                }

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();

        }
    }
}
