using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarih_Zaman_Araçları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime ilkDeger = dateTimePicker1.Value;
            DateTime sonDeger = dateTimePicker2.Value;

            TimeSpan zaman = sonDeger.Subtract(ilkDeger);
            int toplamGun = Convert.ToInt32(zaman.TotalDays);
            int toplamSaat = Convert.ToInt32(zaman.TotalHours);
            int toplamDakika = Convert.ToInt32(zaman.TotalMinutes);
            int toplamSaniye = Convert.ToInt32(zaman.TotalSeconds);

            labelControl1.Text = toplamGun.ToString();
            labelControl3.Text = toplamSaat.ToString();
            labelControl6.Text = toplamDakika.ToString();
            labelControl8.Text = toplamSaniye.ToString();
        }

        
    }
}
