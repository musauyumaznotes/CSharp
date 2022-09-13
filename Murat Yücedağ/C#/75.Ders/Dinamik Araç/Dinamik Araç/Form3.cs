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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label[] lblDizi = new Label[10];
            for (int i = 0; i < lblDizi.Length; i++)
            {
                lblDizi[i] = new Label();
                lblDizi[i].Text = "Label" + i.ToString();
                this.Controls.Add(lblDizi[i]);
                lblDizi[i].Top = i * 30;
                lblDizi[i].Left = 100;
            }
        }
    }
}
