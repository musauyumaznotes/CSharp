using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartman_Kayıt_Uygulaması
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnDaireler_Click(object sender, EventArgs e)
        {
            Daireler daireler = new Daireler();
            daireler.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKayitlar_Click(object sender, EventArgs e)
        {
            KayıtIslemleri kayıtIslemleri = new KayıtIslemleri();
            kayıtIslemleri.Show();
            this.Hide();
        }

        private void btnFotograf_Click(object sender, EventArgs e)
        {
            FrmResim frmResim = new FrmResim();
            frmResim.Show();
            this.Hide();
        }

        private void btnBorclar_Click(object sender, EventArgs e)
        {
            Borclar borclar = new Borclar();
            borclar.Show();
            this.Hide();
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DevExpress kullanarak Apartman kayıt uygulaması gerçekleştirdik Ağustos 7");
        }
    }
}
