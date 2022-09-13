using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityOrnek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DbSınavOgrenciEntities dbSınavOgrenciEntities = new DbSınavOgrenciEntities();
        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var deger = dbSınavOgrenciEntities.TBLNOTLAR.Where(p => p.SINAV1 < 50);
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton2.Checked == true)
            {
                var deger = dbSınavOgrenciEntities.TBLOGRENCI.Where(p => p.AD == "Ali");
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton3.Checked == true)
            {
                var deger = dbSınavOgrenciEntities.TBLOGRENCI.Where(p => p.AD == textBox1.Text || p.SOYAD == textBox1.Text);
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton4.Checked == true)
            {
                var deger = dbSınavOgrenciEntities.TBLOGRENCI.Select(x => new { soyadı = x.SOYAD });
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton5.Checked == true)
            {
                var deger = dbSınavOgrenciEntities.TBLOGRENCI.Select(x => new { Adı = x.AD.ToUpper(), Soyadı = x.SOYAD.ToLower() });
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton6.Checked == true)
            {
                var deger = dbSınavOgrenciEntities.TBLOGRENCI.Select(x => new { Adı = x.AD.ToUpper(), Soyadı = x.SOYAD.ToLower() }).Where(x => x.Adı != "Ali");
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton7.Checked == true)
            {
                var deger = dbSınavOgrenciEntities.TBLNOTLAR.Select(x => new
                {
                    OgrenciAd = x.OGRID,
                    Ortalaması = x.ORTALAMA,
                    Durum = x.DURUM == true ? "Geçti" : "Kaldı"

                });
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton8.Checked == true)
            {
                var deger = dbSınavOgrenciEntities.TBLNOTLAR.SelectMany(x => dbSınavOgrenciEntities.TBLOGRENCI.Where(y => y.ID == x.OGRID), (x, y) => new
                {
                    Ad = y.AD,
                    Soyad = y.SOYAD,
                    Ortalama = x.ORTALAMA,
                    Durum = x.DURUM == true ? "Geçti" : "Kaldı"
                });
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton9.Checked == true)
            {
                var deger = dbSınavOgrenciEntities.TBLOGRENCI.OrderBy(x=>x.ID).Take(3);
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton10.Checked == true)
            {
                var deger = dbSınavOgrenciEntities.TBLOGRENCI.OrderByDescending(x=>x.ID).Take(3);
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton11.Checked == true)
            {
                var deger = dbSınavOgrenciEntities.TBLOGRENCI.OrderBy(x => x.AD);
                dataGridView1.DataSource = deger.ToList();
            }
            if (radioButton12.Checked == true)
            {
                var deger = dbSınavOgrenciEntities.TBLOGRENCI.OrderBy(x=>x.ID).Skip(5);
                dataGridView1.DataSource = deger.ToList();
            }
            //if (radioButton13.Checked == true)
            //{
            //    var deger = dbSınavOgrenciEntities.TBLOGRENCI.OrderBy(x => x.ID).Skip(5).ThenBy(x=>x.AD);
            //    dataGridView1.DataSource = deger.ToList();
            //}
        }
    }
}
