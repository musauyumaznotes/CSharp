using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Kayıt
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                label3.Text = label3.Text.Substring(1) + label3.Text.Substring(0,1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, sifre;
            kullaniciAdi = textBox1.Text;
            sifre = textBox2.Text;
            if (kullaniciAdi=="Admin" &&sifre=="12345")
            {
                FrmKayitForm frmKayitForm= new FrmKayitForm();
                frmKayitForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız Yeniden Deneyin!!!");
                textBox1.Clear();
                textBox2.Clear();
            }
            if (checkBox1.Checked ==true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked ==false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

       
    }
}
