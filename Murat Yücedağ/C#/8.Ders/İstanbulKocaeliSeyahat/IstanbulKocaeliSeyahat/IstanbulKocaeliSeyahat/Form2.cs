using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IstanbulKocaeliSeyahat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnYolcu1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked ==true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked==true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyeti Seçiniz");
                return;
            }
            listBox7.Items.Add("1");
            listBox2.Items.Add(txtAdSoyad.Text);
            listBox3.Items.Add(txtTelefon.Text);
            listBox4.Items.Add(comboBoxIlce.Text);
            listBox6.Items.Add(comboBoxSeferSaati.Text);
            
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            comboBoxIlce.Text = "";
            comboBoxSeferSaati.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
           
            btnYolcu1.Enabled = false;
        }

      

        private void btnYolcu2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyeti Seçiniz");
                return;
            }
            listBox7.Items.Add("2");
            listBox2.Items.Add(txtAdSoyad.Text);
            listBox3.Items.Add(txtTelefon.Text);
            listBox4.Items.Add(comboBoxIlce.Text);
            listBox6.Items.Add(comboBoxSeferSaati.Text);

            txtAdSoyad.Clear();
            txtTelefon.Clear();
            comboBoxIlce.Text = "";
            comboBoxSeferSaati.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            btnYolcu2.Enabled = false;
        }

        private void btnYolcu3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyeti Seçiniz");
                return;
            }
            listBox7.Items.Add("3");
            listBox2.Items.Add(txtAdSoyad.Text);
            listBox3.Items.Add(txtTelefon.Text);
            listBox4.Items.Add(comboBoxIlce.Text);
            listBox6.Items.Add(comboBoxSeferSaati.Text);

            txtAdSoyad.Clear();
            txtTelefon.Clear();
            comboBoxIlce.Text = "";
            comboBoxSeferSaati.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            btnYolcu3.Enabled = false;
        }

        private void btnYolcu4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyeti Seçiniz");
                return;
            }
            listBox7.Items.Add("4");
            listBox2.Items.Add(txtAdSoyad.Text);
            listBox3.Items.Add(txtTelefon.Text);
            listBox4.Items.Add(comboBoxIlce.Text);
            listBox6.Items.Add(comboBoxSeferSaati.Text);

            txtAdSoyad.Clear();
            txtTelefon.Clear();
            comboBoxIlce.Text = "";
            comboBoxSeferSaati.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            btnYolcu4.Enabled = false;
        }

        private void btnYolcu5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyeti Seçiniz");
                return;
            }
            listBox7.Items.Add("5");
            listBox2.Items.Add(txtAdSoyad.Text);
            listBox3.Items.Add(txtTelefon.Text);
            listBox4.Items.Add(comboBoxIlce.Text);
            listBox6.Items.Add(comboBoxSeferSaati.Text);

            txtAdSoyad.Clear();
            txtTelefon.Clear();
            comboBoxIlce.Text = "";
            comboBoxSeferSaati.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            btnYolcu5.Enabled = false;
        }

        private void btnYolcu6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                listBox5.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked == true)
            {
                listBox5.Items.Add(radioButton2.Text);
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyeti Seçiniz");
                return;
            }
            listBox7.Items.Add("6");
            listBox2.Items.Add(txtAdSoyad.Text);
            listBox3.Items.Add(txtTelefon.Text);
            listBox4.Items.Add(comboBoxIlce.Text);
            listBox6.Items.Add(comboBoxSeferSaati.Text);

            txtAdSoyad.Clear();
            txtTelefon.Clear();
            comboBoxIlce.Text = "";
            comboBoxSeferSaati.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            btnYolcu6.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void btnSofor_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtAdSoyad.Text);

            txtAdSoyad.Clear();
            btnSofor.Enabled = false;
        }
    }
}
