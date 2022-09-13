using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_75_Live_Chart_Geo_Map_ile_Dünya_Haritası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GeoMap g = new GeoMap();
            Dictionary<string, double> d = new Dictionary<string, double>();
            d["TR"] = 100;
            d["RU"] = 50;
            d["FR"] = 10;
            d["CZ"] = 30;
            d["US"] = 5;
            g.HeatMap = d;
            g.Source =$"{Application.StartupPath}\\world.xml" ;
            this.Controls.Add(g);
            g.Dock =DockStyle.Fill;
        }
    }
}
