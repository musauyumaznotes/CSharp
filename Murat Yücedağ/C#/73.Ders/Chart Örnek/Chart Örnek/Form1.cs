using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Add("5 Büyük Şehir Kitap Okuma Oranı");

            this.chart1.Series["İstanbul"].Points.AddY(20);
            this.chart1.Series["Ankara"].Points.AddY(15);
            this.chart1.Series["İzmir"].Points.AddY(25);
            this.chart1.Series["Adana"].Points.AddY(13);
            this.chart1.Series["Bursa"].Points.AddY(12);

        }
    }
}
