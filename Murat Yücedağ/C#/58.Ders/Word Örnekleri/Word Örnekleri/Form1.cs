using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wordeaktar = Microsoft.Office.Interop.Word;
namespace Word_Örnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wordeaktar.Application wordApp = new wordeaktar.Application();
            wordApp.Visible = true;
            wordeaktar.Document wordDoc;
            object wordObj = System.Reflection.Missing.Value;
            wordDoc = wordApp.Documents.Add(ref wordObj);
            wordApp.Selection.TypeText(richTextBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
