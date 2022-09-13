using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Xml_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
            string eskiGun = "http://www.tcmb.gov.tr/kurlar/201501/15012015.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(eskiGun);
            DateTime tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            string EURO = xmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            string GBP = xmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;


            label1.Text = string.Format("Tarih {0}; USD: {1}",tarih.ToShortDateString(),USD);
            label2.Text = string.Format("Tarih {0}; EURO: {1}", tarih.ToShortDateString(), EURO);
            label3.Text = string.Format("Tarih {0}; GBP: {1}", tarih.ToShortDateString(), GBP);
        }
    }
}
