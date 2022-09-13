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
namespace Admin_Giriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=guvenlik;Integrated Security=True");
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from parola where Ad=@ad AND Sifre=@sifre",baglanti);
                SqlParameter prm1 = new SqlParameter("ad", txtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", txtSifre.Text.Trim());
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count > 0)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                //SqlParameter a =komut.Parameters.AddWithValue("ad", txtKullaniciAdi.Text.Trim());
                //SqlParameter b =komut.Parameters.AddWithValue("sifre", txtSifre.Text.Trim());
                //komut.ExecuteNonQuery();

            }
            catch (Exception)
            {
                
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
