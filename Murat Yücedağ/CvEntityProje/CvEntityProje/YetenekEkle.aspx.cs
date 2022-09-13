using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YetenekEkle : System.Web.UI.Page
    {
        DbCvEntities cv = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Yetenekler yetenek = new Yetenekler();
            yetenek.Yetenek = txtYetenek.Text;
            yetenek.Derece = Convert.ToByte(txtDerece.Text);
            yetenek.KisiId = 1;
            cv.Yetenekler.Add(yetenek);
            cv.SaveChanges();
            Temizle();
            Response.Redirect("Yetenekler.aspx");

        }
        void Temizle()
        {
            txtDerece.Text = "";
            txtYetenek.Text = "";
        }
    }
}