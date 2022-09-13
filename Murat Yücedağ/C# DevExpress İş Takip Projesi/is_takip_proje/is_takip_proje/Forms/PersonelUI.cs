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
    public partial class PersonelUI : Form
    {
        public PersonelUI()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
        void Listele()
        {
            var degerler = (from person in db.Personeller
                            select new
                            {
                                person.Id,
                                person.Ad,
                                person.Soyad,
                                person.Mail,
                                person.Telefon,
                                Departman = person.Departmanlar.Ad,
                                person.Durum

                            }).Where(x=>x.Durum == true).ToList();
            gridControl1.DataSource = degerler;
        }

        private void PersonelUI_Load(object sender, EventArgs e)
        {
            Listele();

            var departmanlar = from d in db.Departmanlar
                               select new
                               {
                                   d.Id,
                                   d.Ad
                               };
            LUEDepartman.Properties.ValueMember = "Id";
            LUEDepartman.Properties.DisplayMember = "Ad";

            LUEDepartman.Properties.DataSource = departmanlar.ToList();
        }
        void Temizle()
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtMail.Text = "";
            txtTelefon.Text = "";
            txtGorsel.Text = "";
            LUEDepartman.Text = "";
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personeller personel = new Personeller();
            personel.Ad = txtAd.Text;
            personel.Soyad = txtSoyad.Text;
            personel.Mail = txtMail.Text;
            personel.Telefon = txtTelefon.Text;
            personel.DepartmanId = int.Parse(LUEDepartman.EditValue.ToString());
            personel.Gorsel = txtGorsel.Text;
            db.Personeller.Add(personel);
            db.SaveChanges();
            XtraMessageBox.Show("Personel Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            var deger = db.Personeller.Find(id);
            deger.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel silindi. Silinmiş personel listesinden tüm personel bilgilerine ulaşabilirsiniz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            Listele();
            Temizle();


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            txtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            //txtGorsel.Text = gridView1.GetFocusedRowCellValue("Gorsel").ToString();
            //LUEDepartman.Text = gridView1.GetFocusedRowCellValue("DepartmanId").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            var deger = db.Personeller.Find(id);
            deger.Ad = txtAd.Text;
            deger.Soyad = txtSoyad.Text;
            deger.Mail = txtMail.Text;
            deger.Telefon = txtTelefon.Text;
            deger.Gorsel = txtGorsel.Text;
            deger.DepartmanId = int.Parse(LUEDepartman.EditValue.ToString());
            db.SaveChanges();
            Listele();
            Temizle();
            XtraMessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
