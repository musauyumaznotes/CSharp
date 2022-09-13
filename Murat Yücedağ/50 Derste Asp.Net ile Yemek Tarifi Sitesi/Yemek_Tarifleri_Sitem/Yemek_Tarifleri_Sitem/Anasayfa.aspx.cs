using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Anasayfa : System.Web.UI.Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        var degerler = (from x in yemek.Yemeklers
                        select new
                        {
                            Id=x.Id,
                            Ad = x.Tarifler.Ad,
                            Malzeme = x.Tarifler.Malzeme,
                            Tarif = x.Tarifler.Tarif,
                            Tarih = x.Tarifler.Tarih,
                            Puan = x.Puan,
                            Durum=x.Tarifler.Durum

                        }).Where(z=>z.Durum==true).ToList();
        DataList2.DataSource = degerler;
        DataList2.DataBind();
    }
}