using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        DbCvEntities cv = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"]);
            var yetenek = cv.Yetenekler.Find(id);
            cv.Yetenekler.Remove(yetenek);
            cv.SaveChanges();
            Response.Redirect("Yetenekler.aspx");
        }
    }
}