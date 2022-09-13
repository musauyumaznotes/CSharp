using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Metin_Belgesi_İşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamWriter streamWriter;
        string belgeAdi, belgeYolu;

        private void button2_Click(object sender, EventArgs e)
        {
            belgeAdi = textBox1.Text;
            streamWriter = File.CreateText(belgeYolu +"\\" + belgeAdi +".txt");
            streamWriter.Close();
            MessageBox.Show("Belgeniz oluşturuldu");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();

                while (satir!=null)
                {
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.Filter = "Metin Dosyası(*.txt)|*.txt";
            ac.Multiselect = false;
            if (ac.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                textBox3.Text = ac.SafeFileName;
                try
                {
                    StreamReader oku = new StreamReader(ac.FileName);
                    richTextBox1.Text = oku.ReadToEnd();
                    oku.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Dosyayı okurken hata oluştu");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Kayıt Yeri Seçiniz";
                saveFileDialog1.Filter = "Metin Dosyası(*.txt)|*.txt";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.InitialDirectory = "C:\\";
                saveFileDialog1.ShowDialog();
                StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
                kaydet.WriteLine(richTextBox2.Text);
                kaydet.Close();
                MessageBox.Show("Kaynak Metin Belgesine Yazdırıldı");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Gerçekleşti işleme devam edilemiyor");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                belgeYolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox2.Text = belgeYolu.ToString();

            }
           
        }
    }
}
