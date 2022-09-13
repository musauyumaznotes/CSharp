using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace EntityOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSınavOgrenciEntities dbSınavOgrenciEntities = new DbSınavOgrenciEntities();
        private void btnDersListele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbSınavOgrenci;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLDERSLER",baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrenciLislete_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = dbSınavOgrenciEntities.TBLOGRENCI.ToList();
        }

        private void btnNotListele_Click(object sender, EventArgs e)
        {
            var query = from item in dbSınavOgrenciEntities.TBLNOTLAR
                        select new { item.ID, item.TBLOGRENCI.AD, item.TBLDERSLER.DERSAD, item.SINAV1, item.SINAV2, item.SINAV3, item.ORTALAMA, item.DURUM };
            dataGridView1.DataSource = query.ToList();
            //dataGridView1.DataSource = dbSınavOgrenciEntities.TBLNOTLAR.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCI ogrenci = new TBLOGRENCI();
            ogrenci.AD = txtOgrenciAd.Text.ToUpper();
            ogrenci.SOYAD = txtOgrenciSoyad.Text.ToUpper();

            dbSınavOgrenciEntities.TBLOGRENCI.Add(ogrenci);
            dbSınavOgrenciEntities.SaveChanges();
            MessageBox.Show(ogrenci.AD+" sisteme dahil oldu");
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            TBLDERSLER ders = new TBLDERSLER();
            ders.DERSAD =txtDersAd.Text.ToUpper();
            dbSınavOgrenciEntities.TBLDERSLER.Add(ders);
            dbSınavOgrenciEntities.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrenciId.Text);
            var silinecekOgrenci =dbSınavOgrenciEntities.TBLOGRENCI.Find(id);
            dbSınavOgrenciEntities.TBLOGRENCI.Remove(silinecekOgrenci);
            dbSınavOgrenciEntities.SaveChanges();
            MessageBox.Show("Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrenciId.Text);
            var x = dbSınavOgrenciEntities.TBLOGRENCI.Find(id);
            x.AD = txtOgrenciAd.Text.ToUpper();
            x.SOYAD = txtOgrenciSoyad.Text.ToUpper();
            x.FOTOGRAF = txtFotograf.Text.ToUpper();
            dbSınavOgrenciEntities.SaveChanges();
            MessageBox.Show("Öğrenci bilgileri basşarıyla güncellendi");
        }

        private void btnProsedur_Click(object sender, EventArgs e)
        {
            //var enYuksek = dbSınavOgrenciEntities.TBLNOTLAR.Max(p => p.SINAV1)Where(p=>p.SINAV1==enYuksek);
            dataGridView1.DataSource = dbSınavOgrenciEntities.NOTLISTESI().ToList();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbSınavOgrenciEntities.TBLOGRENCI.Where(x=>x.AD==txtOgrenciAd.Text || x.SOYAD==txtOgrenciSoyad.Text).ToList();
        }

        private void txtOgrenciAd_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtOgrenciAd.Text;
            var degerler = from item in dbSınavOgrenciEntities.TBLOGRENCI
                           where item.AD.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                List<TBLOGRENCI> liste1 = dbSınavOgrenciEntities.TBLOGRENCI.OrderBy(p=>p.AD).ToList();
                dataGridView1.DataSource = liste1;
            }
            if (radioButton2.Checked==true)
            {
                List<TBLOGRENCI> liste2 = dbSınavOgrenciEntities.TBLOGRENCI.OrderByDescending(p => p.AD).ToList();
                dataGridView1.DataSource= liste2;
            }
            if (radioButton3.Checked == true)
            {
                List<TBLOGRENCI> liste3 = dbSınavOgrenciEntities.TBLOGRENCI.OrderByDescending(p => p.AD).Take(3).ToList();
                dataGridView1.DataSource = liste3;
            }
            if (radioButton4.Checked==true)
            {
                List<TBLOGRENCI> liste4 = dbSınavOgrenciEntities.TBLOGRENCI.Where(p => p.ID==5).ToList();
                dataGridView1.DataSource = liste4;
            }
            if (radioButton5.Checked == true)
            {
                List<TBLOGRENCI> liste5 = dbSınavOgrenciEntities.TBLOGRENCI.Where(p => p.AD.StartsWith("a")).ToList();
                dataGridView1.DataSource = liste5;
            }
            if (radioButton6.Checked == true)
            {
                List<TBLOGRENCI> liste6 = dbSınavOgrenciEntities.TBLOGRENCI.Where(p => p.AD.EndsWith("a")).ToList();
                dataGridView1.DataSource = liste6;
            }
            if (radioButton7.Checked == true)
            {
               bool deger = dbSınavOgrenciEntities.TBLOGRENCI.Any();
                MessageBox.Show(deger.ToString(),"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (radioButton8.Checked == true)
            {
               int toplam = dbSınavOgrenciEntities.TBLOGRENCI.Count();
               MessageBox.Show(toplam.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton9.Checked == true)
            {
                var toplam = dbSınavOgrenciEntities.TBLNOTLAR.Sum(p=>p.SINAV1);
                MessageBox.Show(toplam.ToString(), "Toplam Sınav Puanı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton10.Checked == true)
            {
                var toplam = dbSınavOgrenciEntities.TBLNOTLAR.Average(p => p.SINAV1);
                MessageBox.Show(toplam.ToString(), "1.Sınav Ortalaması", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton11.Checked == true)
            {
                var enYuksek = dbSınavOgrenciEntities.TBLNOTLAR.Max(p => p.SINAV1);
                MessageBox.Show(enYuksek.ToString(), "1.Sınav En YÜksek Not", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton12.Checked == true)
            {
                var enDusuk = dbSınavOgrenciEntities.TBLNOTLAR.Min(p => p.SINAV1);
                MessageBox.Show(enDusuk.ToString(), "1.Sınav En Düşük Not", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var sorgu = from notlar in dbSınavOgrenciEntities.TBLNOTLAR
                        join ogrenciler in dbSınavOgrenciEntities.TBLOGRENCI
                         on notlar.OGRID equals ogrenciler.ID
                        join ders in dbSınavOgrenciEntities.TBLDERSLER
                        on notlar.DERSID equals ders.ID
                       
                        select new
                        {
                            Öğrenci=ogrenciler.AD + " " +ogrenciler.SOYAD,
                            Ders = ders.DERSAD,
                            //Soyad =ogrenciler.SOYAD,
                            Sınav1 =notlar.SINAV1,
                            Sınav2 =notlar.SINAV2,
                            Sınav3 = notlar.SINAV3,
                            Ortalama = notlar.ORTALAMA

                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
