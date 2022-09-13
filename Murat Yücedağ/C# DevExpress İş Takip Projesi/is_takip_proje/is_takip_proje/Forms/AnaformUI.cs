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
    public partial class AnaformUI : Form
    {
        public AnaformUI()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
        private void AnaformUI_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from g in db.Gorevler
                                       select new
                                       {
                                           Açıklama = g.Aciklama,
                                           Personel = g.Personeller.Ad + " " + g.Personeller.Soyad,
                                           Durum = g.Durum
                                       }).ToList().Where(x => x.Durum == true);
            //gridView1.Columns["Durum"].Visible = false;
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            gridControl2.DataSource = (from g in db.Gorevler
                                       select new
                                       {

                                           g.Aciklama,
                                           g.Tarih,
                                           g.Durum
                                       }).Where(x => x.Tarih == bugun).ToList();
            gridControl3.DataSource = (from x in db.Cagrilar
                                       select new
                                       {
                                           FirmaAdı = x.Firmalar.FirmaAdi,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(z => z.Durum == true).ToList();
            gridView3.Columns["Durum"].Visible = false;

            gridControl4.DataSource = (from x in db.Firmalar
                                       select new
                                       {
                                           x.FirmaAdi,
                                           x.Telefon,
                                           x.Mail
                                       }).ToList();

            int aktifCagri = db.Cagrilar.Where(x => x.Durum == true).Count();
            int pasifCagri = db.Cagrilar.Where(x => x.Durum == false).Count();

            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrılar",aktifCagri);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrılar",pasifCagri);
        }


    }
}
