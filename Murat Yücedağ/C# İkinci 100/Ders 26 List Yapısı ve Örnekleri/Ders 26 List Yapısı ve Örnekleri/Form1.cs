using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_26_List_Yapısı_ve_Örnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ekleme
            List<string> kisiler = new List<string>();
            kisiler.Add("Baran");
            kisiler.Add("Eylül");
            kisiler.Add("Aslan");
            kisiler.Add("Eda");

            label1.Text = kisiler[2];

            for (int i = 0; i < kisiler.Count; i++)
            {
                listBox1.Items.Add(kisiler[i]);
            }
        }
    }
}
