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
    public partial class PersonelIstatistikUI : Form
    {
        public PersonelIstatistikUI()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
        private void PersonelIstatistikUI_Load(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;
            lblBugunkuIsSayisi.Text = bugun.ToString();
            lblDepartmanSayısı.Text = db.Departmanlar.Count().ToString();
            lblFirmaSayisi.Text = db.Firmalar.Count().ToString();
            lblPersonelSayısı.Text = db.Personeller.Count().ToString();
            lblAktifIsSayisi.Text = db.Gorevler.Count(x => x.Durum == true).ToString();
            lblPasifIsSayisi.Text = db.Gorevler.Count(x => x.Durum == false).ToString();
            lblSonGorev.Text = db.Gorevler.OrderByDescending(x => x.Id).Select(x => x.Aciklama).FirstOrDefault().ToString();
            lblIsYapilanSehir.Text = db.Firmalar.Select(x => x.SehirId).Distinct().Count().ToString();
            lblBugunkuIsSayisi.Text = db.Gorevler.Count(x => x.Tarih == bugun).ToString();
            lblToplamSektorSayisi.Text = db.Sektorler.Select(x => x.SektorAdi).Distinct().Count().ToString();
            lblIlceSayisi.Text = db.Ilceler.Count().ToString();
            var d1 = db.Gorevler.GroupBy(x => x.GorevAlanId).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            lblAyinPersoneli.Text = db.Personeller.Where(x => x.Id == d1).Select(y=>y.Ad +" "+y.Soyad).FirstOrDefault().ToString();
        }
    }
}
