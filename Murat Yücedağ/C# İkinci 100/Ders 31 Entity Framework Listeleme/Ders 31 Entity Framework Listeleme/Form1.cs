using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_31_Entity_Framework_Listeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Personel2Entities ent = new Personel2Entities();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ent.Tbl_Personel.ToList();
        }
        void Temizle()
        {
            txtAd.Clear();
            txtMaas.Clear();
            txtSoyad.Clear();
            txtSehir.Clear();
        }
        Tbl_Personel tbl = new Tbl_Personel();
        private void btnEkle_Click(object sender, EventArgs e)
        {
          
            tbl.PerAd =txtAd.Text;
            tbl.PerSoyad = txtSoyad.Text;
            tbl.PerSehir = txtSehir.Text;
            tbl.PerMaas = Convert.ToInt16(txtMaas.Text);
            ent.Tbl_Personel.Add(tbl);
            ent.SaveChanges();
            MessageBox.Show("Personel Sisteme Dahil Oldu");
            dataGridView1.DataSource = ent.Tbl_Personel.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtId.Text);
            tbl = ent.Tbl_Personel.First(f=>f.Perid==id);
            ent.Tbl_Personel.Remove(tbl);
            ent.SaveChanges();
            MessageBox.Show("Personel Sistemden Silindi");
            dataGridView1.DataSource = ent.Tbl_Personel.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(txtId.Text);
            tbl = ent.Tbl_Personel.First(f => f.Perid == id);
            tbl.PerAd = txtAd.Text;
            tbl.PerSoyad = txtSoyad.Text;
            tbl.PerSehir = txtSehir.Text;
            tbl.PerMaas = Convert.ToInt16(txtMaas.Text);
            ent.SaveChanges();
            MessageBox.Show("Personel Güncellendi");
            dataGridView1.DataSource = ent.Tbl_Personel.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
