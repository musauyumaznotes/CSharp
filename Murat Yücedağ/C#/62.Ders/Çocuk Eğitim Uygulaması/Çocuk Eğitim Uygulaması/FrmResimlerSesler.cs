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
    public partial class FrmResimlerSesler : Form
    {
        public FrmResimlerSesler()
        {
            InitializeComponent();
        }

        private void FrmResimlerSesler_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\62.Ders\müzikler\sarki.mp3";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\62.Ders\müzikler\kopek.mp3";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\62.Ders\müzikler\horoz.mp3";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\62.Ders\müzikler\inek.mp3";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\62.Ders\müzikler\koyun.mp3";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\62.Ders\müzikler\kedi.mp3";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\62.Ders\müzikler\ordek.mp3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frmAnaForm = new FrmAnaForm();
            frmAnaForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\62.Ders\müzikler\sarki.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
