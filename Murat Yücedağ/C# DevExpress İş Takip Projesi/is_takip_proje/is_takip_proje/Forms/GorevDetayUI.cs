using is_takip_proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Forms
{
    public partial class GorevDetayUI : Form
    {
        public GorevDetayUI()
        {
            InitializeComponent();
        }
        DbIsTakipEntities db = new DbIsTakipEntities();
        private void GorevDetayUI_Load(object sender, EventArgs e)
        {
            db.Gorevler.Load();
            bindingSource1.DataSource = db.Gorevler.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void gorevSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
