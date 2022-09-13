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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=AycicegiPansiyon;Integrated Security=True");
        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from AdminGiris where KullaniciAdi=@kullaniciAdi And Sifre=@sifre",baglanti);
                komut.Parameters.AddWithValue("@kullaniciAdi" ,txtKullaniciAdi.Text.Trim());
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text.Trim());
                
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);

                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count>0)
                {
                    FrmAnaForm frmAnaForm = new FrmAnaForm();
                    frmAnaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                }
                baglanti.Close();


            }
            catch (Exception)
            {

                MessageBox.Show("Hata!!!");
            }
            
           
        }
    }
}
