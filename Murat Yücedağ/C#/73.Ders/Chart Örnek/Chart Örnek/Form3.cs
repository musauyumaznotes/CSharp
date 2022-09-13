using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Chart_Örnek
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            chart1.Titles.Add("Öğrenci-Bölüm-Kontenjan Bilgileri");

            string[] bolumler = {"Mühendislik","Öğretmenlik","Tıp","Hukuk","Besyo"};
            int[] kontenjan = {40,50,80,100,20};

            for (int i = 0; i < bolumler.Length; i++)
            {
                Series sutunlar = chart1.Series.Add(bolumler[i]);
                sutunlar.Points.Add(kontenjan[i]);
            }
        }
    }
}
