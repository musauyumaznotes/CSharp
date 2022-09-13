using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karakter_Doğrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345" && textBox3.Text==label1.Text)
            {
                MessageBox.Show("Giriş Başarılı");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dizi1 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Y", "Z", "W", "X" };
            int sembol1 = rastgele.Next(0, dizi1.Length);
            string karakter1 = dizi1[sembol1];


            string[] dizi2 = { "1", "2", "3", "5", "4", "6", "7", "8", "9", "0" };
            int sembol2 = rastgele.Next(0, dizi2.Length);
            string karakter2 = dizi2[sembol2];


            string[] dizi3 = { "!", "#", "+", "-", "*", "&", "|", ">", "<", "?" };
            int sembol3 = rastgele.Next(0, dizi3.Length);
            string karakter3 = dizi3[sembol3];


            string[] dizi4 = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z", "q", "w", "x" };
            int sembol4 = rastgele.Next(0, dizi4.Length);
            string karakter4 = dizi4[sembol4];


            string[] dizi5 = { "a", "A", "B", "1", "2", "0", "*", "#", "+", "-", "H", "M", "m", "d", "u", "!" };
            int sembol5 = rastgele.Next(0, dizi5.Length);
            string karakter5 = dizi5[sembol5];
            label1.Text = karakter1 + karakter2 + karakter3 + karakter4 + karakter5;
        }
    }
}
