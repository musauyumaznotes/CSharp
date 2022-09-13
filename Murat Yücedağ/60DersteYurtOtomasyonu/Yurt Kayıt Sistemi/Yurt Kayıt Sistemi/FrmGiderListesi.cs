using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt_Kayıt_Sistemi
{
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }
        
        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet5.Giderler' table. You can move, or remove it, as needed.
            Listele();

        }

        public void Listele()
        {
            this.giderlerTableAdapter.Fill(this.yurtKayitDataSet5.Giderler);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmGiderDuzenle frm = new FrmGiderDuzenle();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            frm.id =int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            frm.elektrik = decimal.Parse(dataGridView1.Rows[secilen].Cells[1].Value.ToString());
            frm.su = decimal.Parse(dataGridView1.Rows[secilen].Cells[2].Value.ToString());
            frm.dogalgaz = decimal.Parse(dataGridView1.Rows[secilen].Cells[3].Value.ToString());
            frm.diger = decimal.Parse(dataGridView1.Rows[secilen].Cells[7].Value.ToString());
            frm.gida = decimal.Parse(dataGridView1.Rows[secilen].Cells[5].Value.ToString());
            frm.personel = decimal.Parse(dataGridView1.Rows[secilen].Cells[6].Value.ToString());
            frm.internet = decimal.Parse(dataGridView1.Rows[secilen].Cells[4].Value.ToString());

            
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }
    }
}
