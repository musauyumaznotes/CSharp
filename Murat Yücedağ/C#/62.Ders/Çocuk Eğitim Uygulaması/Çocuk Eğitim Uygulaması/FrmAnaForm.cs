using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çocuk_Eğitim_Uygulaması
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmResimlerSesler frmResimlerSesler = new FrmResimlerSesler();
            frmResimlerSesler.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmEslestirKelime frmEslestirKelime = new FrmEslestirKelime();
            frmEslestirKelime.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmAritmetik frmAritmetik = new FrmAritmetik();
            frmAritmetik.Show();
            this.Hide();
        }
    }
}
