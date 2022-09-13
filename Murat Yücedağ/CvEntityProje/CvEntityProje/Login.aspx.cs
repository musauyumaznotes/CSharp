using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class Login : System.Web.UI.Page
    {
        DbCvEntities cv = new DbCvEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            var sorgu = from x in cv.Adminler where x.KullaniciAdi == txtKullaniciAdi.Text && x.Sifre == txtSifre.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("Mesajlar.aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı veya Şifre");
            }
        }
    }
}