using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
namespace Veri_Çekme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uri url = new Uri("http://www.onedio.com");
           
            WebClient client = new WebClient();
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes("//a");


            foreach (var baslik in basliklar)
            {
                string link = baslik.Attributes["href"].Value;
                listBox1.Items.Add(baslik.InnerText);
            }

        }
    }
}
