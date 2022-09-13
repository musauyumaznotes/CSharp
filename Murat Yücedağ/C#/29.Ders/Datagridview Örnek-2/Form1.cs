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
namespace Datagridview_Örnek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=bilgi;Integrated Security=True");
        public void VerileriGoster(string veriler)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(veriler, baglanti);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];


        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster("Select * from kisiler");
        }
    }
}
