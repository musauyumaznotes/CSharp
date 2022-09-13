using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminAyarlar frmAdminAyarlar = new FrmAdminAyarlar();
            frmAdminAyarlar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri frmYeniMusteri = new FrmYeniMusteri();
            frmYeniMusteri.Show();
            this.Hide();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler frmMusteriler = new FrmMusteriler();
            frmMusteriler.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayçiçeği Pansiyon Kayıt Uygulaması /2021 - Eskişehir");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar frmOdalar = new FrmOdalar();  
            frmOdalar.Show();
            this.Hide();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmGelirGiderFormu frmGelirGiderFormu = new FrmGelirGiderFormu();
            frmGelirGiderFormu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmStoklar frmStoklar = new FrmStoklar();
            frmStoklar.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle frmRadyoDinle = new FrmRadyoDinle();
            frmRadyoDinle.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMesajlar frmMesajlar = new FrmMesajlar();
            frmMesajlar.Show();
            this.Hide();
        }
    }
}
