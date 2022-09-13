using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Araç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label lbl = new Label();
            Point lblKonum = new Point(50,50);
            lbl.Location = lblKonum;
            lbl.Text = "Label1";
            lbl.Name = "lbl1";
            lbl.BackColor = Color.Green;
            this.Controls.Add(lbl);
        }
    }
}
