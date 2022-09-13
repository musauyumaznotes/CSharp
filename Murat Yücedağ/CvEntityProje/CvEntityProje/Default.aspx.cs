using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace CvEntityProje
{
    public partial class Default : System.Web.UI.Page
    {
        DbCvEntities cv = new DbCvEntities();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = cv.Bilgiler.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = cv.GenelBilgiler.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = cv.GenelBilgiler.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = cv.Yetenekler.Where(x=>x.KisiId==1).ToList();
            Repeater4.DataBind();
        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            Mesajlar mesaj = new Mesajlar();
            mesaj.AdSoyad = txtAdSoyad.Text;
            mesaj.Mail = txtEmail.Text;
            mesaj.Konu = txtKonu.Text;
            mesaj.Mesaj = txtMesaj.Text;
            mesaj.Tarih = DateTime.Now;
            cv.Mesajlar.Add(mesaj);
            cv.SaveChanges();
            Temizle();
        }
        void Temizle()
        {
            txtAdSoyad.Text = "";
            txtEmail.Text = "";
            txtKonu.Text = "";
            txtMesaj.Text = "";
        }
    }
}