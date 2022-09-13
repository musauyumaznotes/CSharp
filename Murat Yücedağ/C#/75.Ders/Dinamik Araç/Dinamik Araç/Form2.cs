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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            Point txtKonum = new Point(20, 20);
            txt.Location = txtKonum;
            txt.Name = "TextBox1";
            groupBox1.Controls.Add(txt);

            Button btn = new Button();
            Point btnKonum = new Point(50,80);
            btn.Location = btnKonum;
            btn.Name = "Button1";
            btn.Text = "Merhaba Tıkla";
            btn.BackColor = Color.HotPink;
            groupBox1.Controls.Add(btn);

        }
    }
}
