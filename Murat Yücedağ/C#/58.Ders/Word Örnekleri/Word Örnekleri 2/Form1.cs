using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using System.Reflection;
namespace Word_Örnekleri_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object omissing = System.Reflection.Missing.Value;
            object dokumansonu = "\\endofdoc";

            word.Application olustur;
            word.Document icerik;

            olustur = new word.Application();
            olustur.Visible = true;
            icerik = olustur.Documents.Add(ref omissing);

            word.Paragraph ad;
            ad=icerik.Content.Paragraphs.Add(ref omissing);
            ad.Range.Text = "Ad: "+textBox1.Text;
            ad.Format.SpaceAfter = 10;
            ad.Range.InsertParagraphAfter();


            word.Paragraph soyad;
            object orng = icerik.Bookmarks.get_Item(ref dokumansonu).Range;
            soyad = icerik.Content.Paragraphs.Add(ref orng);
            soyad.Range.Text = "Soyad: "+textBox2.Text;
            soyad.Format.SpaceAfter = 10;
            soyad.Range.InsertParagraphAfter();

            word.Paragraph yas;
            orng = icerik.Bookmarks.get_Item(ref dokumansonu).Range;
            yas = icerik.Content.Paragraphs.Add(ref orng);
            yas.Range.Text = "Yaş: " + textBox3.Text;
            yas.Format.SpaceAfter = 10;
            yas.Range.InsertParagraphAfter();

            word.Paragraph sehir;
            orng = icerik.Bookmarks.get_Item(ref dokumansonu).Range;
            sehir = icerik.Content.Paragraphs.Add(ref orng);
            sehir.Range.Text = "Şehir: " + comboBox1.Text;
            sehir.Format.SpaceAfter = 10;
            sehir.Range.InsertParagraphAfter();
            
            word.Paragraph telefon;
            orng = icerik.Bookmarks.get_Item(ref dokumansonu).Range;
            telefon = icerik.Content.Paragraphs.Add(ref orng);
            telefon.Range.Text = "Telefon: " + textBox4.Text;
            telefon.Format.SpaceAfter = 10;
            telefon.Range.InsertParagraphAfter();
            
            word.Paragraph meslek;
            orng = icerik.Bookmarks.get_Item(ref dokumansonu).Range;
            meslek = icerik.Content.Paragraphs.Add(ref orng);
            meslek.Range.Text = "Meslek: " + textBox5.Text;
            meslek.Format.SpaceAfter = 10;
            meslek.Range.InsertParagraphAfter();
        }
    }
}
