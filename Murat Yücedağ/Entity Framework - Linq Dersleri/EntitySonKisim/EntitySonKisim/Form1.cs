using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySonKisim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSınavOgrenciEntities ogrenciEntities = new DbSınavOgrenciEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var degerler = ogrenciEntities.TBLOGRENCI.OrderBy(x => x.SEHIR).GroupBy(y => y.SEHIR).Select(z => new { Şehir = z.Key, Toplam = z.Count() });//.OrderByDescending(c=>c.Toplam);
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //label1.Text = ogrenciEntities.TBLNOTLAR.Max(x=>x.ORTALAMA).ToString();
            //label2.Text = ogrenciEntities.TBLNOTLAR.Min(x => x.SINAV1).ToString();
            //label1.Text = ogrenciEntities.TBLNOTLAR.Where(x=>x.DURUM==false).Max(z=>z.ORTALAMA).ToString();
            //label1.Text = ogrenciEntities.TBLURUN.Count().ToString();
            //label2.Text = ogrenciEntities.TBLURUN.Sum(x=>x.STOK).ToString();
            //label1.Text = ogrenciEntities.TBLURUN.Count(x => x.AD == "BUZDOLABI").ToString();
            //label1.Text = ogrenciEntities.TBLURUN.Average(x => x.FİYAT).ToString();
            //label1.Text = ogrenciEntities.TBLURUN.Where(x => x.AD == "Buzdolabı").Average(x => x.FİYAT).ToString();
            //label1.Text = (from x in ogrenciEntities.TBLURUN
            //               orderby x.STOK descending
            //               select x.AD).First(); 

            dataGridView1.DataSource = ogrenciEntities.Kulupler().ToList();
        }
    }
}
