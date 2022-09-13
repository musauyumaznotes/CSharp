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
namespace Ders1_Connection_String_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            
            SqlDataAdapter da = new SqlDataAdapter("Select * from Kitaplar",bgl.baglanti());
            DataSet dataSet = new DataSet();
            da.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            

        }
    }
}
