using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress_Ders_7__RibbonControl_Kullanımı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arcScaleComponent1.Value += 1;
            if (arcScaleComponent1.Value >= 100)
            {
                timer1.Stop();
                timer2.Start();
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            arcScaleComponent1.Value -= 1;
            if (arcScaleComponent1.Value <= 0)
            {
                timer2.Stop();
                timer1.Start();
            }
        } 
    }
}
