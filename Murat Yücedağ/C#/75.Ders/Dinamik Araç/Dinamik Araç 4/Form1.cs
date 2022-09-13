using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Araç_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int butonSayisi = 10;
            int baslaX = 1;
            int baslaY = 1;
            int boyutBol = Convert.ToInt32(Math.Ceiling(Math.Sqrt(butonSayisi)));

            for (int i = 1; i <= butonSayisi; i++)
            {
                Button btn = new Button();
                btn.Name = i.ToString();
                btn.AutoSize = false;
                btn.Size = new Size(this.Width/boyutBol,this.Height/(boyutBol*2));
                btn.Text = "Button "+ i.ToString();
                btn.Font = new Font(btn.Font.FontFamily.Name, 20);
                btn.Location = new Point(baslaX,baslaY);
                this.Controls.Add(btn);
                baslaX +=btn.Width +10;

                if (baslaX+this.Width / boyutBol >this.Width)
                {
                    baslaX = 1;
                    baslaY += this.Height / (boyutBol * 2) + 5;
                }
                btn.Click += new EventHandler(dinamikMethod);
            }
        }
        protected void dinamikMethod(Object sender ,EventArgs e)
        {
            Button dinamik = (sender as Button);
            MessageBox.Show(dinamik.Text +" .İsimli buton");
        }
    }
}
