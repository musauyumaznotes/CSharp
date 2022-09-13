using DevExpress.XtraEditors;
using is_takip_proje.Entity;
using is_takip_proje.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje
{
    public partial class GorevUI : Form
    {
        public GorevUI()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
 
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Gorevler gorev = new Gorevler();
            gorev.Aciklama = txtAciklama.Text;
            gorev.Durum = true;
            gorev.GorevAlanId = int.Parse(lookUpEditGorevAlan.EditValue.ToString());
            gorev.Tarih = DateTime.Parse(txtTarih.Text);
            gorev.GorevVerenId = int.Parse(txtGorevVeren.Text);
            db.Gorevler.Add(gorev);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Tanımlandı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();

        }

        private void GorevUI_Load(object sender, EventArgs e)
        {
            var personeller = (from x in db.Personeller
                               select new 
                               {
                                   Id = x.Id,
                                  AdSoyad =x.Ad +" "+ x.Soyad
                               } ).ToList();
            lookUpEditGorevAlan.Properties.ValueMember = "Id";
            lookUpEditGorevAlan.Properties.DisplayMember = "AdSoyad";
            lookUpEditGorevAlan.Properties.DataSource = personeller;
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
