using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class EgitimGuncelle : System.Web.UI.Page
    {
        DbCvEntities cv = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = 1;
                var egitim = cv.GenelBilgiler.Find(id);
                txtEgitim.Text = egitim.Egitim;
            }

        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = 1;
            var egitim = cv.GenelBilgiler.Find(id);
            egitim.IsDeneyimleri = txtEgitim.Text;
            cv.SaveChanges();
            Response.Redirect("Mesajlar.aspx");
        }
    }
}