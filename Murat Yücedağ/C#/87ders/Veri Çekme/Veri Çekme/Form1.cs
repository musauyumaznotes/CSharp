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
using System.Net;
namespace Veri_Çekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adres = "http://www.google.com.tr";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();
            int baslikBaslangic = gelen.IndexOf("<title>") + 7;
            int baslikBitis = gelen.Substring(baslikBaslangic).IndexOf("</title>");
            string baslik = gelen.Substring(baslikBaslangic, baslikBitis);
            MessageBox.Show(baslik);
        }
    }
}
