using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araçlar_Örnek_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.BackColor =Color.MediumSlateBlue;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            linkLabel4.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel5.LinkBehavior = LinkBehavior.HoverUnderline;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Mspaint.exe");
        }
    }
}
