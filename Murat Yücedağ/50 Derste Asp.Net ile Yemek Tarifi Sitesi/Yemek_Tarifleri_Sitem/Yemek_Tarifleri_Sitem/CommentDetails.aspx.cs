using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommentDetails : System.Web.UI.Page
{
    int id;
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            id = int.Parse(Request.QueryString["YorumId"]);
            var yorum = (from x in yemek.Yorumlar
                         select new
                         {
                             YorumId = x.Id,
                             AdSoyad = x.Kullanicilar.Ad_Soyad,
                             Mail = x.Kullanicilar.Email,
                             Icerik = x.Icerik,
                             Yemek = x.Yemekler.Tarifler.Ad
                         }).Where(z => z.YorumId == id).FirstOrDefault();


            txtAdSoyad.Text = yorum.AdSoyad;
            txtMail.Text = yorum.Mail;
            txtIcerik.Text = yorum.Icerik;
            txtYemek.Text = yorum.Yemek;
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int id1 = int.Parse(Request.QueryString["YorumId"]);
        var comment = yemek.Yorumlar.Find(id1);
        //comment.KullaniciId = 1;
        comment.OnayDurum = true;
        comment.Icerik = txtIcerik.Text;
        yemek.SaveChanges();
        Temizle();

    }
    void Temizle()
    {
        txtAdSoyad.Text = "";
        txtIcerik.Text = "";
        txtMail.Text = "";
        txtYemek.Text = "";
    }
}