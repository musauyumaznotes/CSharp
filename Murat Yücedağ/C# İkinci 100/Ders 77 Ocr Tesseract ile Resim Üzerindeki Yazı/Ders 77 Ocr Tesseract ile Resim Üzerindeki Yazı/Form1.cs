using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace Ders_77_Ocr_Tesseract_ile_Resim_Üzerindeki_Yazı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                var img = new Bitmap(openFileDialog1.FileName);
                var ocr = new TesseractEngine("./eng","eng");
                var sonuc = ocr.Process(img);
                richTextBox1.Text = sonuc.GetText();
            }
        }
    }
}
