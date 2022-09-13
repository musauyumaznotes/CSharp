using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class YemekDetay : System.Web.UI.Page
{
    int yemekId;
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        Listele();

    }

    private void Listele()
    {
        yemekId = int.Parse(Request.QueryString["Id"]);

        var deger = (from x in yemek.Yemeklers
                     select new
                     {
                         Id = x.Id,
                         Ad = x.Tarifler.Ad
                     }).Where(z => z.Id == yemekId).ToList();
        var deger2 = (from y in yemek.Yorumlar
                      select new
                      {
                          YemekId = y.YemekId,
                          AdSoyad = y.Kullanicilar.Ad_Soyad,
                          Yorum = y.Icerik,
                          Tarih = y.Tarih
                      }
                      ).Where(z => z.YemekId == yemekId).ToList();
        DataList2.DataSource = deger;
        DataList2.DataBind();
        DataList3.DataSource = deger2;
        DataList3.DataBind();
    }

    Kullanicilar kullanici = new Kullanicilar();
    Yorumlar yorum = new Yorumlar();
    protected void Button1_Click(object sender, EventArgs e)
    {
        //if (UserExists(txtMail.Text))
        //{

        kullanici.Ad_Soyad = txtAdSoyad.Text;
        kullanici.Email = txtMail.Text;
        yemek.Kullanicilar.Add(kullanici);
        yemek.SaveChanges();
        yorum.KullaniciId = kullanici.Id;
        yorum.YemekId = yemekId;
        yorum.Icerik = txtYorum.Text;
        yemek.Yorumlar.Add(yorum);
        yemek.SaveChanges();
        Response.Write("Yorum Kaydedildi");
        Temizle();
        Listele();


        //else
        //{
        //    Response.Write("Kullanici Sistemde mevcuttur");
        //}



    }
    private bool UserExists(string email)
    {
        var deger = kullanici.Email;
        var hesap = yemek.Kullanicilar.Find(deger);
        if (hesap == null)
        {
            return false;

        }
        return true;
    }
    void Temizle()
    {
        txtAdSoyad.Text = "";
        txtMail.Text = "";
        txtYorum.Text = "";
    }
}