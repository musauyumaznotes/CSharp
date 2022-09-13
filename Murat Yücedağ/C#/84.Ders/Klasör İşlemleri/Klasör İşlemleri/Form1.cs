using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Klasör_İşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlasorOlustur_Click(object sender, EventArgs e)
        {
            string klasör = textEdit1.Text;
            Directory.CreateDirectory(@"C:\Users\musau\Desktop\Murat Yücedağ\C#\84.Ders\" + klasör);
        }

        private void btnKlasorSil_Click(object sender, EventArgs e)
        {
            string klasör = textEdit1.Text;
            Directory.Delete(@"C:\Users\musau\Desktop\Murat Yücedağ\C#\84.Ders\" + klasör);
        }

        private void btnYolVarMı_Click(object sender, EventArgs e)
        {
            string klasör = textEdit1.Text;
            string yol = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\84.Ders\" + klasör;
            MessageBox.Show(Directory.Exists(yol).ToString());
        }

        private void btnOlusturmaTarihi_Click(object sender, EventArgs e)
        {
            string klasör = textEdit1.Text;
            string adres = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\84.Ders\" + klasör;
            MessageBox.Show(Directory.GetCreationTime(adres).ToString());
        }

        private void btnAktifProgramYolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Directory.GetCurrentDirectory().ToString());
        }

        private void btnProgramFiles_Click(object sender, EventArgs e)
        {
            string adres = @"‪C:\Program Files";
            string[] klasor = Directory.GetDirectories(adres);
            foreach (string item in klasor)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string klasör = textEdit1.Text;
            string yol = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\84.Ders\" + klasör;
            MessageBox.Show(Directory.GetLastAccessTime(yol).ToString());
        }

        private void btnKlasorAdDegistir_Click(object sender, EventArgs e)
        {
            string klasör = textEdit1.Text;
            string yol = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\84.Ders\" + klasör;
            Directory.Move(yol, @"C:\Users\musau\Desktop\Murat Yücedağ\C#\84.Ders\abc");
        }

        private void btnSuruculer_Click(object sender, EventArgs e)
        {
            string[] dizi = Directory.GetLogicalDrives();
            listBox1.Items.AddRange(dizi);

            //foreach (var item in dizi)
            //{
            //    listBox1.Items.Add(item);
            //}

        }

        private void btnUstDizin_Click(object sender, EventArgs e)
        {
            string klasör = textEdit1.Text;
            string yol = @"C:\Users\musau\Desktop\Murat Yücedağ\C#\84.Ders\" + klasör;
            DirectoryInfo ustDizin = Directory.GetParent(yol);
            MessageBox.Show(ustDizin.ToString());
        }
    }
}
