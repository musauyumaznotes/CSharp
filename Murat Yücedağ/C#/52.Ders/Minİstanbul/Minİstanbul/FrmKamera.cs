using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minİstanbul
{
    public partial class FrmKamera : Form
    {
        public FrmKamera()
        {
            InitializeComponent();
        }

       

        private void FrmKamera_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.istanbul/camera");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
            frmAnasayfa.Show();
            this.Hide();
        }
    }
}
