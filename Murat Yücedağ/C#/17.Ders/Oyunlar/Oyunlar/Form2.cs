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

namespace Oyunlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=localhost;Initial Catalog=bilgiyarismasi;Integrated Security=True");
        int zorlukSeviyesi = 1;
        int soru = 0;

        int sayac = 0;
        int zaman = 20;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 20;


            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.WhiteSmoke;
            button3.BackColor = Color.WhiteSmoke;
            button4.BackColor = Color.WhiteSmoke;
            btnBasla.BackColor = Color.WhiteSmoke;

            btnBasla.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;



            btnBasla.Text = "Sonraki Soru";
            soru++;
            lblSoru.Text = soru.ToString();
            if (soru < 2)
            {
                zorlukSeviyesi = 1;
            }
            else if (soru >=2 && soru < 4)
            {
                zorlukSeviyesi = 2;
            }
            else if (soru>=4 && soru < 6)
            {
                zorlukSeviyesi = 3;
            }
            else if (soru >= 6&& soru < 8)
            {
                zorlukSeviyesi = 4;
            }
            else
            {
                btnBasla.Enabled = false;
                MessageBox.Show("Yarışma Tamamlandı ");
                Application.Exit();
                return;
            }
            
            
            
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from sorular where zorlukseviyesi=("+zorlukSeviyesi+") order by NEWID() offset 0 rows Fetch next 1 rows only", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                button1.Text = (oku["a"].ToString());
                button2.Text = (oku["b"].ToString());
                button3.Text = (oku["c"].ToString());
                button4.Text = (oku["d"].ToString());
                textBox1.Text = (oku["soru"].ToString());
                lblDogru.Text = (oku["dogru"].ToString());

            }
            baglan.Close();
        }
        int puan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled= false;
            button3.Enabled= false;
            button4.Enabled= false;
            if (button1.Text ==lblDogru.Text)
            {
                btnBasla.BackColor = Color.GreenYellow;
                button1.BackColor = Color.Green;
                puan += 10;
                lblPuan.Text = puan.ToString();
                btnBasla.Enabled = true;
                
            }else
            {
                button1.BackColor = Color.Red;
                btnBasla.Enabled = false;
                MessageBox.Show("Yarışmayı Kaybettiniz");
                Application.Exit();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button2.Text == lblDogru.Text)
            {
                btnBasla.BackColor = Color.GreenYellow;
                button2.BackColor = Color.Green;
                puan += 10;
                lblPuan.Text = puan.ToString();
                btnBasla.Enabled = true;

            }
            else
            {
                btnBasla.BackColor = Color.GreenYellow;
                button2.BackColor = Color.Red;
                btnBasla.Enabled = false;
                MessageBox.Show("Yarışmayı Kaybettiniz");
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button3.Text == lblDogru.Text)
            {
                btnBasla.BackColor = Color.GreenYellow;
                button3.BackColor = Color.Green;
                puan += 10;
                lblPuan.Text = puan.ToString();
                btnBasla.Enabled = true;

            }
            else
            {
                button3.BackColor = Color.Red;
                btnBasla.Enabled = false;
                MessageBox.Show("Yarışmayı Kaybettiniz");
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button4.Text == lblDogru.Text)
            {
                btnBasla.BackColor = Color.GreenYellow;
                button4.BackColor = Color.Green;
                puan += 10;
                lblPuan.Text = puan.ToString();
                btnBasla.Enabled = true;

            }
            else
            {
                button4.BackColor = Color.Red;
                btnBasla.Enabled = false;
                MessageBox.Show("Yarışmayı Kaybettiniz");
                Application.Exit();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblSure.Text = zaman.ToString();

            if (zaman==0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnBasla.Enabled = false;
                MessageBox.Show("Süre Doldu");
                Application.Exit();
            }
        }
    }
}
