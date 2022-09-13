using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MesajDetay : System.Web.UI.Page
{
    int id;
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            id = int.Parse(Request.QueryString["MesajId"]);
            var mesaj = (from x in yemek.Mesajlar
                         select new
                         {
                             MesajId = x.Id,
                             Baslik = x.Baslik,
                             Gonderen = x.Gonderen,
                             Mail = x.Mail,
                             Icerik = x.Icerik

                         }).Where(z => z.MesajId == id).FirstOrDefault();
            txtBaslik.Text = mesaj.Baslik;
            txtGonderen.Text = mesaj.Gonderen;
            txtIcerik.Text = mesaj.Icerik;
            txtMail.Text = mesaj.Mail;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int id1 = int.Parse(Request.QueryString["MesajId"]);
        var silinecekMesaj=yemek.Mesajlar.Find(id1);
        yemek.Mesajlar.Remove(silinecekMesaj);
        yemek.SaveChanges();
        Temizle();
    }
    void Temizle()
    {
        txtBaslik.Text = "";
        txtGonderen.Text = "";
        txtIcerik.Text = "";
        txtMail.Text = "";
    }
}