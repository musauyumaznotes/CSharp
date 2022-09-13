using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_27_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void islemler(int x, int y);
        
        void Toplam(int s1,int s2)
        {
            listBox1.Items.Add((s1+s2));
        }
        void carpim(int s1, int s2)
        {
            listBox1.Items.Add((s1 * s2));
        }
        void fark(int s1, int s2)
        {
            listBox1.Items.Add((s1 - s2));
        }
        void Bölüm(int s1, int s2)
        {
            listBox1.Items.Add((s1 / s2));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            islemler islem = new islemler(Toplam);
            islem += fark;
            islem += carpim;
            islem += Bölüm;

            islem(10,5);

            //listBox1.Items.Add(Toplam(10,5));
            //listBox1.Items.Add(fark(10, 5));
            //listBox1.Items.Add(Bölüm(10, 5));
            //listBox1.Items.Add(carpim(10, 5));
        }
    }
}
