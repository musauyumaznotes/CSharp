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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        PersonelUI personelUI;
        DepartmanUI departmanUI;
        PersonelIstatistikUI personelIstatistikUI;
        GorevListesiUI gorevListesiUI;
        GorevUI gorevUI;
        GorevDetayUI gorevDetayUI;
        AnaformUI anaformUI;
        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personelUI == null || personelUI.IsDisposed)
            {
                personelUI = new PersonelUI();
                personelUI.MdiParent = this;
                personelUI.Show();

            }

        }

        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (departmanUI == null || departmanUI.IsDisposed)
            {
                departmanUI = new DepartmanUI();
                departmanUI.MdiParent = this;
                departmanUI.Show();
            }

        }

        private void btnPersonelIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personelIstatistikUI == null || personelIstatistikUI.IsDisposed)
            {
                personelIstatistikUI = new PersonelIstatistikUI();
                personelIstatistikUI.MdiParent = this;
                personelIstatistikUI.Show();
            }

        }

        private void btnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gorevListesiUI == null || gorevListesiUI.IsDisposed)
            {
                gorevListesiUI = new GorevListesiUI();
                gorevListesiUI.MdiParent = this;
                gorevListesiUI.Show();
            }

        }

        private void btnYeniGorev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gorevUI == null || gorevUI.IsDisposed)
            {
                gorevUI = new GorevUI();
                gorevUI.Show();
            }

        }

        private void btnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gorevUI == null || gorevUI.IsDisposed)
            {
                gorevDetayUI = new GorevDetayUI();
                gorevDetayUI.Show();
            }

        }

        private void btnAnaform_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anaformUI == null || anaformUI.IsDisposed)
            {
                anaformUI = new AnaformUI();
                anaformUI.MdiParent = this;
                anaformUI.Show();
            }
        }
    }
}
