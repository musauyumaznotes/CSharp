using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonOrnek
{
    public partial class MenuStrip : Form
    {
        public MenuStrip()
        {
            InitializeComponent();
        }

        private void esaretinBedeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(esaretinBedeliToolStripMenuItem.Text);
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void amelieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(amelieToolStripMenuItem.Text);
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void felektenBirGeceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(felektenBirGeceToolStripMenuItem.Text);
            listBox2.Items.Add(toolStripComboBox1.Text);
        }
    }
}
