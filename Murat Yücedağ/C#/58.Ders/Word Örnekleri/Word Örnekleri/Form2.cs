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

namespace Word_Örnekleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object omissing = System.Reflection.Missing.Value;
            object dokumansonu = "\\endofdoc";

            word.Application olustur = new word.Application();
            word.Document icerik;
            olustur.Visible = true;
            icerik = olustur.Documents.Add(ref omissing);

            word.Paragraph paragraf1;
            paragraf1 = icerik.Content.Paragraphs.Add(ref omissing);
            paragraf1.Range.Text = richTextBox1.Text;
            paragraf1.Range.Font.Bold = 1;
            paragraf1.Format.SpaceAfter = 20;
            paragraf1.Range.InsertParagraphAfter();

            word.Paragraph paragraf2;
            object hedef = icerik.Bookmarks.get_Item(ref dokumansonu).Range;
            paragraf2=icerik.Content.Paragraphs.Add(ref hedef);
            paragraf2.Range.Text = "İkinci Paragraf canlı yayın donmakta";
            paragraf2.Format.SpaceAfter = 100;
            paragraf2.Range.InsertParagraphAfter();
      
            word.Paragraph paragraf3;
            hedef = icerik.Bookmarks.get_Item(ref dokumansonu).Range;
            paragraf3 =icerik.Content.Paragraphs.Add(ref hedef);
            paragraf3.Range.Text = "Deneme Metni Yazdık";
            paragraf3.Range.Font.Bold = 1;
            paragraf3.Format.SpaceAfter = 30; 
            paragraf3.Range.InsertParagraphAfter();

            word.Table olusturTablo;
            word.Range wrdrng = icerik.Bookmarks.get_Item(ref dokumansonu).Range;
            olusturTablo = icerik.Tables.Add(wrdrng,3,5,ref omissing, ref omissing );
            olusturTablo.Range.ParagraphFormat.SpaceAfter = 10;
            int r, c;
            string strText;
            for (r = 1; r <= 3; r++)
            {
                for ( c = 1; c <= 5; c++)
                {
                    strText = "Satır" + r + "Sütun" + c;
                    olusturTablo.Cell(r, c).Range.Text = strText;
                }
                olusturTablo.Rows[1].Range.Font.Bold = 1;
                olusturTablo.Rows[1].Range.Font.Italic = 1;
            }
        }
    }
}
