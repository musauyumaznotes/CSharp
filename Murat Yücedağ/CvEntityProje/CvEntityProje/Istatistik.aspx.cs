using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Istatistik : System.Web.UI.Page
    {
        DbCvEntities cv = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = cv.Yetenekler.Count().ToString();
            Label2.Text = cv.Mesajlar.Count().ToString();
            Label3.Text = cv.Yetenekler.Average(x => x.Derece).ToString();
            Label4.Text = cv.Yetenekler.Max(x=>x.Derece).ToString();
             
        }
    }
}