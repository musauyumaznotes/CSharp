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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtEditKullaniciAdi.Text, sifre=textEditSifre.Text;
            
            if (kullaniciAdi=="Yönetici" && sifre=="12345")
            {
                Giris giris = new Giris();
                giris.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("");
            }
        }

        
    }
}
