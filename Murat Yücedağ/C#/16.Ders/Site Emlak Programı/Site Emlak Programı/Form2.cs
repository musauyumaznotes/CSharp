using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Site_Emlak_Programı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Orkide Sitesi")
            {
                btnOrkide.BackColor = Color.Gold;
                btnGul.BackColor = Color.Gray;
                btnMenekse.BackColor = Color.Gray;
                btnPapatya.BackColor = Color.Gray;
            }
            else if (comboBox1.Text == "Menekşe Sitesi")
            {
                btnOrkide.BackColor = Color.Gray;
                btnGul.BackColor = Color.Gray;
                btnMenekse.BackColor = Color.Gold;
                btnPapatya.BackColor = Color.Gray;
            }
            else if (comboBox1.Text == "Gül Sitesi")
            {
                btnOrkide.BackColor = Color.Gray;
                btnGul.BackColor = Color.Gold;
                btnMenekse.BackColor = Color.Gray;
                btnPapatya.BackColor = Color.Gray;
            }
            else if (comboBox1.Text == "Papatya Sitesi")
            {
                btnOrkide.BackColor = Color.Gray;
                btnGul.BackColor = Color.Gray;
                btnMenekse.BackColor = Color.Gray;
                btnPapatya.BackColor = Color.Gold;
            }
        }
        SqlConnection baglan = new SqlConnection("Data Source=localhost;Initial Catalog=siteler;Integrated Security=True");
        private void VerileriGoster()
        {
            baglan.Open();
            listView1.Items.Clear();
            
            SqlCommand komut = new SqlCommand("select * from sitebilgi", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metrekare"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["satkira"].ToString());

                listView1.Items.Add(ekle);
            }
         baglan.Close();
        }
        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into sitebilgi (id,site,oda,metrekare,fiyat,blok,no,adsoyad,telefon,notlar,satkira) " +
            "values('"+textBox8.Text+"','"+comboBox1.Text+"','"+comboBox4.Text+"','"+textBox1.Text+"','"+textBox2.Text+"','"+comboBox2.Text+"','"+textBox7.Text+"','"+textBox6.Text+"','"+textBox5.Text+"','"+textBox3.Text+"','"+comboBox3.Text+"')",baglan);
            komut.ExecuteNonQuery();
            VerileriGoster();
            baglan.Close();
        }
        int id = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from sitebilgi where id=("+id+")",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();

        }

        private void btnDuzelt_Click(object sender, EventArgs e)
{
            baglan.Open();                                                          //id,site,oda,metrekare,fiyat,blok,no,adsoyad,telefon,notlar,satkira
            SqlCommand komut = new SqlCommand("Update sitebilgi set id='" + textBox8.Text + "',site='" + comboBox1.Text + "',oda='" + comboBox4.Text + "',metrekare='" + textBox1.Text + "',fiyat='"+textBox2.Text+"',blok='"+comboBox2.Text+"',no='"+textBox7.Text+"',adsoyad='"+textBox6.Text+"',telefon='"+textBox5.Text+"',notlar='"+textBox3.Text+"',satkira='"+comboBox3.Text+"'",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox8.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[9].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[10].Text;
           
        }
    }
}
