using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KategoriAdminDetay : System.Web.UI.Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            id = int.Parse(Request.QueryString["KategoriId"]);

            var deger = (from x in yemek.Kategoriler
                         select new
                         {
                             KategoriId = x.Id,
                             KategoriAd = x.Ad,
                             KategoriResim = x.Resim
                         }).Where(z => z.KategoriId == id).FirstOrDefault();
            TextBox1.Text = deger.KategoriAd;

        }

    }

    protected void btnGuncelle_Click(object sender, EventArgs e)
    {
        FileUpload1.SaveAs(Server.MapPath("/resimler/"+FileUpload1.FileName));
        int id1 = int.Parse(Request.QueryString["KategoriId"]);
        var kategori = yemek.Kategoriler.Find(id1);
         kategori.Ad = TextBox1.Text;
        kategori.Resim = "~/resimler/"+FileUpload1.FileName;
        yemek.SaveChanges();
        TextBox1.Text = "";

    }
}