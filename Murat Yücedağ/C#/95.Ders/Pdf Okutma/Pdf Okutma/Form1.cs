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
namespace Pdf_Okutma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pdfAc = new OpenFileDialog();
            pdfAc.Title = "Pdf Aç";
            pdfAc.Filter = "PDF Dosyaları (*.Pdf)|*.Pdf";

            if (pdfAc.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = pdfAc.FileName;
                axAcroPDF1.LoadFile(pdfAc.FileName);
            }
        }
    }
}
