using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
namespace Excel_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            excel.Application uygulama = new excel.Application();
            uygulama.Visible = true;

            excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);

            excel.Worksheet sayfa1 = (excel.Worksheet)kitap.Sheets[1];

            excel.Range alan = (excel.Range)sayfa1.Cells[2,5];

            alan.Value2 = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
