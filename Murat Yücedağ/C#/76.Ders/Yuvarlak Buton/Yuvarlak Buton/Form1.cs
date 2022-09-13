using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Yuvarlak_Buton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YuvarlakButon ybButon = new YuvarlakButon();
            ybButon.Size = new Size(180, 180);
            ybButon.Location = new Point(50,50);
            ybButon.BackColor = Color.Black;
            ybButon.FlatAppearance.BorderSize = 0;
            ybButon.FlatStyle = FlatStyle.Flat;
            ybButon.FlatAppearance.BorderColor = Color.Red;
            ybButon.Text = "Button1";
            ybButon.ForeColor = Color.DeepSkyBlue;
            this.Controls.Add(ybButon);
        }
    }
    public class YuvarlakButon : Button
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(new Rectangle(Point.Empty,this.Size));
            this.Region = new Region(gp);
        }
    }
}
