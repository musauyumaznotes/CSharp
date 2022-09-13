using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KategoriDetay : System.Web.UI.Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    int kategoriId;
    protected void Page_Load(object sender, EventArgs e)
    {
        kategoriId = int.Parse(Request.QueryString["Id"]);
        var deger = (from x in yemek.Yemeklers
                     select new
                     {
                         KategoriId = x.Tarifler.KategoriId,
                         Ad = x.Tarifler.Ad,
                         Malzeme = x.Tarifler.Malzeme,
                         Puan = x.Puan,
                         Tarif = x.Tarifler.Tarif,
                         Tarih = x.Tarifler.Tarih,


                     }).Where(z => z.KategoriId==kategoriId).ToList();
        DataList2.DataSource =deger;
        DataList2.DataBind();
    }
}