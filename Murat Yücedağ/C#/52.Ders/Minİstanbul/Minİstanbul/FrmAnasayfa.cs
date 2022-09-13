using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minİstanbul
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCamiler camiler = new FrmCamiler();
            camiler.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FrmHarita harita = new FrmHarita();
            harita.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmKamera frmKamera = new FrmKamera();
            frmKamera.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FrmMetro frmMetro = new FrmMetro();
            frmMetro.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FrmMetrobus frmMetrobus = new FrmMetrobus();
            frmMetrobus.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmNeAlinir frmNeAlinir = new FrmNeAlinir();
            frmNeAlinir.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmNeYenir frmNeYenir = new FrmNeYenir();
            frmNeYenir.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Kopruler kopruler = new Kopruler();
            kopruler.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmMuzeler frmMuzeler = new FrmMuzeler();
            frmMuzeler.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmKorular frmKorular = new FrmKorular();
            frmKorular.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCarsılar frmCarsılar = new FrmCarsılar();
            frmCarsılar.Show();
            this.Hide();
        }
    }
}
