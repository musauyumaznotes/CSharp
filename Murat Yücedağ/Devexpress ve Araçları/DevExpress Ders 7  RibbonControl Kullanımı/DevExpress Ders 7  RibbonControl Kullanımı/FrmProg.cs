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
    public partial class FrmProg : Form
    {
        public FrmProg()
        {
            InitializeComponent();
        }

        private void FrmProg_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            progressBarControl1.EditValue = i;
        }
    }
}
