using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        DbCvEntities cv = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["Id"]);
                var yetenek = cv.Yetenekler.Find(id);
                txtYetenek.Text = yetenek.Yetenek;
                txtDerece.Text = yetenek.Derece.ToString();
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var yetenek = cv.Yetenekler.Find(id);
            yetenek.Derece = Convert.ToByte(txtDerece.Text);
            yetenek.Yetenek = txtYetenek.Text;
            yetenek.KisiId = 1;
            cv.SaveChanges();
            Response.Redirect("Yetenekler.aspx");
        }
    }
}