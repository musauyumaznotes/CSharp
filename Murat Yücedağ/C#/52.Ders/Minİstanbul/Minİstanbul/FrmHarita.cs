using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minİstanbul
{
    public partial class FrmHarita : Form
    {
        public FrmHarita()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Image img = pictureBox1.Image;
            int zoomWidth = pictureBox1.Width;
            int zoomHeight = pictureBox1.Height;

            if (img.Width<=(e.X + zoomWidth))
            {
                zoomWidth = img.Width - e.X;
            }
            if (img.Height <=(e.Y +zoomHeight))
            {
                zoomHeight = img.Height - e.Y;
            }
            Rectangle rec = new Rectangle(e.X,e.Y,zoomWidth,zoomHeight);
            pictureBox2.Image = cropimage(img, rec);

        }
        private Image cropimage(Image img,Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,bmpImage.PixelFormat);
            return (Image)(bmpCrop);

        }
    }
}
