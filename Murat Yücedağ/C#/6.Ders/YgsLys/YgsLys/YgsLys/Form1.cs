using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YgsLys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkceNet, matematikNet, sosyalNet, fenNet;
            double ygs1,ygs2,ygs3,ygs4,ygs5,ygs6;

            turkceNet = Convert.ToDouble(txtTurkce.Text);
            matematikNet = Convert.ToDouble(txtMatematik.Text);
            sosyalNet = Convert.ToDouble(txtSosyal.Text);
            fenNet=Convert.ToDouble(txtFen.Text);

            ygs1 = 100.160 + (turkceNet*1.999)+(sosyalNet*1)+(matematikNet*3.998) +(fenNet*2.999);
            ygs2 = 100.160 + (turkceNet * 1.999) + (sosyalNet * 1) + (matematikNet * 2.999) + (fenNet * 3.998);
            ygs3 = 100.160 + (turkceNet * 3.998) + (sosyalNet * 2.999) + (matematikNet * 1.999) + (fenNet * 1);
            ygs4 = 100.160 + (turkceNet * 2.999) + (sosyalNet * 3.998) + (matematikNet * 1.999) + (fenNet * 1);
            ygs5 = 100.120 + (turkceNet * 3.699) + (sosyalNet * 1.999) + (matematikNet * 3.299) + (fenNet * 1);
            ygs6 = 100.120 + (turkceNet * 3.299) + (sosyalNet * 1) + (matematikNet * 3.699) + (fenNet * 1.999);

            lblYgs1.Text = ygs1.ToString();
            lblYgs2.Text = ygs2.ToString();
            lblYgs3.Text = ygs3.ToString();
            lblYgs4.Text = ygs4.ToString();
            lblYgs5.Text = ygs5.ToString();
            lblYgs6.Text = ygs6.ToString();

        }
    }
}
