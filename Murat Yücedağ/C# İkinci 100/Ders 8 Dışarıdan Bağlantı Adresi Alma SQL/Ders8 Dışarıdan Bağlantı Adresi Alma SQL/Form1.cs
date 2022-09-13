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
using System.IO;
namespace Ders8_Dışarıdan_Bağlantı_Adresi_Alma_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string baglantiAdresi;
        private void button1_Click(object sender, EventArgs e)
        {
           
            StreamReader oku = new StreamReader(@"C:\Users\musau\Desktop\Murat Yücedağ\C# İkinci 100\Ders8 Dışarıdan Bağlantı Adresi Alma SQL\BaglantiAdresi\adres.txt");
            string satir = oku.ReadLine();
            while (satir != null)
            {
                baglantiAdresi = satir;
                satir=oku.ReadLine();
            }
            SqlConnection baglanti = new SqlConnection(baglantiAdresi);
            SqlDataAdapter da = new SqlDataAdapter("Select * from bilgiler",baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource=ds.Tables[0];
        }
    }
}
