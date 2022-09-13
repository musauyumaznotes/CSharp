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
    public partial class GorevListesiUI : Form
    {
        public GorevListesiUI()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
        public void Listele()
        {
            gridControl1.DataSource = (from g in db.Gorevler
                                       select new 
                                       {
                                           g.Id,
                                           g.Aciklama
                                       } ).ToList();
        }
        private void GorevListesiUI_Load(object sender, EventArgs e)
        {
            lblAktifGorev.Text = db.Gorevler.Where(x=>x.Durum==true).Count().ToString();
            lblPasifGorev.Text = db.Gorevler.Where(x => x.Durum == false).Count().ToString();
            lblToplamDepartman.Text = db.Departmanlar.Select(x=>x.Ad).Distinct().Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler",int.Parse(lblAktifGorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(lblPasifGorev.Text));
            Listele();
        }

       
    }
}
