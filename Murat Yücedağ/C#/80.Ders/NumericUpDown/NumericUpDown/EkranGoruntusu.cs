using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown
{
    public partial class EkranGoruntusu : Form
    {
        public EkranGoruntusu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap foto = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics gr = Graphics.FromImage(foto);
            gr.CopyFromScreen(0, 0, 0, 0, new Size(foto.Width, foto.Height));
            pictureBox1.Image = foto;
        }
    }
}
