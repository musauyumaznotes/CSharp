using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode ekle = new TreeNode("Windows");
            treeView1.Nodes.Add(ekle);

            ekle = new TreeNode("Linux");
            treeView1.Nodes.Add(ekle);

            TreeNode cocuk1 = new TreeNode("C#");
            TreeNode cocuk2 = new TreeNode("Visual Basic");
            TreeNode cocuk3 = new TreeNode("Asp.Net");

            TreeNode[] array = new TreeNode[] { cocuk1, cocuk2, cocuk3 };
            ekle = new TreeNode("Programlama Dilleri",array);
            treeView1.Nodes.Add(ekle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
