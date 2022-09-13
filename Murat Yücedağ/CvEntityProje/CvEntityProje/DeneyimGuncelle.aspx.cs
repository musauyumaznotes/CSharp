using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class DeneyimGuncelle : System.Web.UI.Page
    {
        DbCvEntities cv = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = 1;
                var deneyim = cv.GenelBilgiler.Find(id);
                txtDeneyim.Text = deneyim.IsDeneyimleri;
            }
           
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = 1;
            var deneyim = cv.GenelBilgiler.Find(id);
            deneyim.IsDeneyimleri = txtDeneyim.Text;
            cv.SaveChanges();
            Response.Redirect("Mesajlar.aspx");
        }
    }
}