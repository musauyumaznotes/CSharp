using DevExpress.XtraEditors;
using is_takip_proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Forms
{
    public partial class DepartmanUI : Form
    {
        public DepartmanUI()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
        void Listele()
        {
            var result = from depart in db.Departmanlar
                         select new
                         {
                             depart.Id,
                             depart.Ad
                         };
            gridControl1.DataSource = result.ToList();
        }
        void Temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Departmanlar departmanlar = new Departmanlar();
            departmanlar.Ad = txtAd.Text;
            db.Departmanlar.Add(departmanlar);
            db.SaveChanges();
            XtraMessageBox.Show("Departman eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.Departmanlar.Find(id);
            db.Departmanlar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Departman Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
            Temizle();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.Departmanlar.Find(id);
            deger.Ad = txtAd.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Departman Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
            Temizle();
        }
    }
}
