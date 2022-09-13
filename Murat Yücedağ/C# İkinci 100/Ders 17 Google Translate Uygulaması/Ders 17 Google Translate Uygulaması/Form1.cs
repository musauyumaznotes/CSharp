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
namespace Ders_17_Google_Translate_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool Test()
        {
            string adres = "http://www.google.com";
            try
            {
                WebRequest istek = WebRequest.Create(adres);
                WebResponse yanit = istek.GetResponse();

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Test())
            {
                this.Text = "Bağlantı Var";
            }
            else
            {
                this.Text = "Bağlantı Yok";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#tr/en/");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#en/tr/");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true )
            {
                textBox2.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
            if (radioButton2.Checked==true)
            {
                textBox1.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = textBox2.Text;
        }
    }
}
