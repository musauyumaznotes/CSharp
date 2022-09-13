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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            chart1.Titles.Add("Öğrenci Notları");

            chart1.Series["Notlar"].Points.AddXY("Baran",70);
            chart1.Series["Notlar"].Points.AddXY("Ayşe", 85);
            chart1.Series["Notlar"].Points.AddXY("Hasan", 60);
            chart1.Series["Notlar"].Points.AddXY("Ali", 100);
            chart1.Series["Notlar"].Points.AddXY("Emel", 90);
        }
    }
}
