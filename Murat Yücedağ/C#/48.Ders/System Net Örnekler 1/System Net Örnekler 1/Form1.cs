using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace System_Net_Örnekler_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text =Dns.GetHostName();
            foreach (IPAddress adress in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                label3.Text = adress.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
