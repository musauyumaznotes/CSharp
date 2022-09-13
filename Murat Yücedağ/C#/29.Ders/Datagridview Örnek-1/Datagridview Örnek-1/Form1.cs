using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datagridview_Örnek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Sıra No";
            dataGridView1.Columns[1].Name = "Ad";
            dataGridView1.Columns[2].Name = "Soyad";
            dataGridView1.Columns[3].Name = "Meslek";
            dataGridView1.Columns[4].Name = "Şehir";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Add();
            i = 0;
            dataGridView1.Rows[i].Cells[0].Value = 1;
            dataGridView1.Rows[i].Cells[1].Value = "Baran";
            dataGridView1.Rows[i].Cells[2].Value = "Yücedağ";
            dataGridView1.Rows[i].Cells[3].Value = "Öğretmen";
            dataGridView1.Rows[i].Cells[4].Value = "İstanbul";

            i = 1;
            dataGridView1.Rows[i].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[i].Cells[3].Value = textBox4.Text;
            dataGridView1.Rows[i].Cells[4].Value = comboBox1.Text;
        }
    }
}
