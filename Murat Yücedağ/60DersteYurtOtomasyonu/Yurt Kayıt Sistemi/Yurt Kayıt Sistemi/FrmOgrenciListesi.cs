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
    public partial class FrmOgrenciListesi : Form
    {
        public FrmOgrenciListesi()
        {
            InitializeComponent();
        }

        private void FrmOgrenciListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet4.OgrenciListele' table. You can move, or remove it, as needed.
            Listele();

        }

        public void Listele()
        {
            this.ogrenciListeleTableAdapter.Fill(this.yurtKayitDataSet4.OgrenciListele);
        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrenciDuzenle fr = new FrmOgrenciDuzenle();
           
            fr.id =int.Parse(dataGridView1.Rows[secilen].Cells[0].Value.ToString());
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.tc = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.dogumTarihi = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.mail = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.odaNo = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.bolum = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.veliAdSoyad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.veliTelefon = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.veliAdres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();

            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            frm.Show();
            this.Hide();
        }
    }
}
