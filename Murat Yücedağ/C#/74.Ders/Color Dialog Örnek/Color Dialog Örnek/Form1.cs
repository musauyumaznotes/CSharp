using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Dialog_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult pencere;
            pencere = colorDialog1.ShowDialog();
            if (pencere==DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}
