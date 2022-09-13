using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_18_Datagridview_ile_Şartlı_Renklendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kisiDurumDataSet.PersonelBilgi' table. You can move, or remove it, as needed.
            this.personelBilgiTableAdapter.Fill(this.kisiDurumDataSet.PersonelBilgi);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value) <= 3000)
                {
                    renk.BackColor = Color.Pink;
                    renk.ForeColor = Color.Black;
                }
                else
                {
                    renk.BackColor = Color.Plum;
                    renk.ForeColor = Color.Black;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }

        }
    }
}
