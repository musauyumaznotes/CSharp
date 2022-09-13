using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt_Kayıt_Sistemi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtKayitDataSet1.OgrenciAnaform' table. You can move, or remove it, as needed.
            this.ogrenciAnaformTableAdapter.Fill(this.yurtKayitDataSet1.OgrenciAnaform);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("MsPaint.exe");
        }

        private void radyo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.201/;type=mp3";

        }

        private void radyo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " https://listen.powerapp.com.tr/powerturk/abr/powerturk/128/playlist.m3u8";
        }

        private void radyo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://n10101m.mediatriple.net/videoonlylive/mtkgeuihrlfwlive/u_stream_5c9e2f95dcb16_1/playlist.m3u8";
        }

        private void durdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKayit frm = new FrmOgrKayit();
            frm.Show();
            this.Hide();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciListesi frm = new FrmOgrenciListesi();
            frm.Show();
            this.Hide();
        }

        private void öğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciDuzenle frm = new FrmOgrenciDuzenle();
            frm.Show();
            this.Hide();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler frm = new FrmBolumler();
            frm.Show();
            this.Hide();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler frm = new FrmBolumler();
            frm.Show();
            this.Hide();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler frm = new FrmOdemeler();
            frm.Show();
            this.Hide();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGider frm = new FrmGider();
            frm.Show();
            this.Hide();
        }

        private void giderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListesi frm = new FrmGiderListesi();
            frm.Show();
            this.Hide();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirIstatistik frm = new FrmGelirIstatistik();
            frm.Show();
            this.Hide();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciIslemleri frm = new FrmKullaniciIslemleri();
            frm.Show();
            this.Hide();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotEkle frm = new FrmNotEkle();
            frm.Show();
            this.Hide();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program Musa Uyumaz tarafından 11/09/2021 tarihinde tamamlanmıştır.","Öğrenci Yurt Otomasyonu",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
