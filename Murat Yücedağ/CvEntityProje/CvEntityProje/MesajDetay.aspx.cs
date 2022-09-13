using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        DbCvEntities cv = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            var mesaj = cv.Mesajlar.Find(id);
            txtAdSoyad.Text = mesaj.AdSoyad;
            txtMail.Text = mesaj.Mail;
            txtKonu.Text = mesaj.Konu;
            txtMesaj.Text = mesaj.Mesaj;
        }

        protected void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            var mesaj = cv.Mesajlar.Find(id);
            cv.Mesajlar.Remove(mesaj);
            cv.SaveChanges();
            Response.Redirect("Mesajlar.aspx");
        }

        protected void btnVazgec_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mesajlar.aspx");
        }
    }
}