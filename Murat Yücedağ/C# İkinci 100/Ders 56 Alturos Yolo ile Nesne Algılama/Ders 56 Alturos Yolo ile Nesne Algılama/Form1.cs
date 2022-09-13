using Alturos.Yolo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_56_Alturos_Yolo_ile_Nesne_Algılama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog sec = new OpenFileDialog();
            if (sec.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(sec.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var configurationDetector = new ConfigurationDetector();
            var config = configurationDetector.Detect();
            using (var yoloWrapper = new YoloWrapper(config))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms,ImageFormat.Png);
                    var items = yoloWrapper.Detect(ms);
                    yoloItemBindingSource.DataSource = items;
                }
               
            }
        }
    }
}
