using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6_Enum_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum sehirler
        {
            x,Adana,Adıyaman,Afyon,Ağrı,Amasya,Ankara,Antalya,Artvin,Aydın
        }
        enum aylar
        {
            x,Ocak,Şubat,Mart,Nisan,Mayıs,Haziran,Temmuz,Ağustos,Eylül,Ekim,Kasım,Aralık
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt16(textBox1.Text);
            sehirler s;
            s = (sehirler)plaka;
            label2.Text=s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte Ay = Convert.ToByte(textBox2.Text);
            aylar ay;
            ay= (aylar)Ay;
            label3.Text=ay.ToString();
        }
    }
}
