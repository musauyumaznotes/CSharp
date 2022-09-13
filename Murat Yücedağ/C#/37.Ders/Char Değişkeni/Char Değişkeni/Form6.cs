using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Char_Değişkeni
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { int boy, yas;
            char cinsiyet = Convert.ToChar(comboBox1.Text);
             boy = Convert.ToInt32(textBox1.Text);
             yas = Convert.ToInt32(textBox2.Text);

            if (cinsiyet =='K')
            {
                double ideal = (boy-100 + (yas/10)) * 0.8;
                label5.Text = ideal.ToString();
            }
            else if (cinsiyet =='E')
            {
                double ideal = (boy - 100 + (yas / 10)) * 0.9;
                label5.Text = ideal.ToString();
            }

           
        }
    }
}
