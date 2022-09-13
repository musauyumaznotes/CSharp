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
namespace Pansiyon_Kayıt
{
    public partial class FrmKayitForm : Form
    {
        public FrmKayitForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=pansiyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from müsteriler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["GirisTarih"].ToString());
                ekle.SubItems.Add(oku["CikisTarih"].ToString());
                ekle.SubItems.Add(oku["Hesap"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into müsteriler (id,Ad,Soyad,OdaNo,Telefon,GirisTarih,CikisTarih,Hesap) values(@id,@ad,@soyad,@odano,@telefon,@giristarih,@cikistarih,@hesap)", baglanti);
            Parametre(komut);
            komut.ExecuteNonQuery();
            komut.CommandText = "insert into doluodalar(dolu) values ('"+comboBox1.Text+"')";
            komut.ExecuteNonQuery();
            komut.CommandText = "delete from bosodalar where bos='" + comboBox1.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
            Temizle();
        }

        private void Parametre(SqlCommand komut)
        {
            komut.Parameters.AddWithValue("@id", textBox1.Text.ToString());
            komut.Parameters.AddWithValue("@ad", textBox2.Text.ToString());
            komut.Parameters.AddWithValue("@soyad", textBox3.Text.ToString());
            komut.Parameters.AddWithValue("@odano", comboBox1.Text.ToString());
            komut.Parameters.AddWithValue("@telefon", textBox5.Text.ToString());
            komut.Parameters.AddWithValue("@giristarih", dateTimePicker1.Text.ToString());
            komut.Parameters.AddWithValue("@cikistarih", dateTimePicker2.Text.ToString());
            komut.Parameters.AddWithValue("@hesap", textBox8.Text.ToString());
        }

        private void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            textBox5.Clear();
            textBox8.Clear();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Aktarma();
        }

        private void Aktarma()
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[5].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[7].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From müsteriler where id= ('"+id+"')",baglanti);
            komut.ExecuteNonQuery();
            komut.CommandText = "insert into bosodalar(bos) values ('" + comboBox1.Text + "')";
            komut.ExecuteNonQuery();
            komut.CommandText = "delete from doluodalar where dolu='" + comboBox1.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
            Temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update müsteriler set id=@id, Ad=@ad ,Soyad=@soyad ,OdaNo=@odano ,Telefon=@telefon ,GirisTarih=@giristarih ,CikisTarih=@cikistarih ,Hesap=@hesap where id=@id",baglanti);
            Parametre(komut);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
            Temizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from müsteriler where Ad like '%"+textBox6.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["GirisTarih"].ToString());
                ekle.SubItems.Add(oku["CikisTarih"].ToString());
                ekle.SubItems.Add(oku["Hesap"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = label10.Text.Substring(1) + label10.Text.Substring(0,1);
        }

        private void FrmKayitForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select bos from bosodalar",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                comboBox1.Items.Add(oku["bos"].ToString());
            }
            baglanti.Close();
        }
    }
}
