using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace Excel_Örnek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int barkodDurum = ListeBarkodDenetle(urunlerList,txtBarkod.Text);
            if (txtBarkod.Text!="")
            {
                string[] elemanlar =
                {
                    txtBarkod.Text,
                    comboBoxKategori.Text,
                    txtUrunAd.Text,
                    txtFiyat.Text
                };
                ListViewItem veriler = new ListViewItem(elemanlar);
                urunlerList.Items.Add(veriler);
                Temizle();
            }
            else
            {
                MessageBox.Show("Geçersiz Barkod Girişi!!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            urunlerList.View = View.Details;
            deletedList.View = View.Details;

            urunlerList.FullRowSelect = true;
            deletedList.FullRowSelect = true;

            ListViewKolonlar(urunlerList);
            ListViewKolonlar(deletedList);
           
            
        }
        void ListViewKolonlar(ListView liste)
        {
            liste.Columns.Add("Barkod");
            liste.Columns.Add("Kategori");
            liste.Columns.Add("Ürün Adı");
            liste.Columns.Add("Fiyat");

        }
        int ListeBarkodDenetle(ListView liste, String barkod)
        {
            foreach (ListViewItem veri in liste.Items)
            {
                if (barkod==veri.Text)
                {
                    return 1; //eklenmek istenen barkod listede mevcut;
                }
            }
            return 0;   //eklenmek istenen barkod listede mevcut değil;
        }
        void Temizle()
        {
            txtBarkod.Clear();
            comboBoxKategori.Text = "";
            txtUrunAd.Clear();
            txtFiyat.Clear();
        }
        ListViewItem iptalListe;
        int i = 2, j = 1;

        private void verileriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExceleAktar(urunlerList);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem veri in urunlerList.SelectedItems)
            {
                string[] iptalEdilenVeri =
                {
                    veri.SubItems[0].Text,
                    veri.SubItems[1].Text,
                    veri.SubItems[2].Text,
                    veri.SubItems[3].Text,
                };
                deletedList.Items.Add(iptalListe = new ListViewItem(iptalEdilenVeri));
            }
            urunlerList.SelectedItems[0].Remove();
        }

        void ExceleAktar(ListView liste)
        {
            try
            {
                Application excel = new Application();
                excel.Visible = true;
                Workbook workbook = excel.Workbooks.Add(XlSheetType.xlWorksheet);
                Worksheet worksheet = excel.ActiveSheet;
                worksheet.Cells[1, 1] = "Barkod";
                worksheet.Cells[1, 2] = "Kategori";
                worksheet.Cells[1, 3] = "Ürün Adı";
                worksheet.Cells[1, 4] = "Fiyatı";

                foreach (ListViewItem item in liste.Items)
                {
                    worksheet.Cells[i, j] = item.Text.ToString();
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        worksheet.Cells[i, j] = subItem.Text.ToString();
                        j++;
                    }
                    j = 1;
                    i++;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Uygulama Hatası!!!");
            }
        }
    }
}
