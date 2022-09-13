using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;
using excel = Microsoft.Office.Interop.Excel;
namespace Excel_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application excelDosya = new excel.Application();
            excelDosya.Visible = true;
            object missing = Type.Missing;
            Workbook calismaKitabi = excelDosya.Workbooks.Add(missing);
            Worksheet sheet1 = calismaKitabi.Sheets[1];
            int sutun = 1;
            int satir = 1;

            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {
                Range myRange = sheet1.Cells[satir,sutun+j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;

            }
            satir++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = sheet1.Cells[satir+i,sutun+j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j,i].Value;
                    myRange.Select();

                }
            }
        }
    }
}
