using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Comment : System.Web.UI.Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        panel2.Visible = false;
        panel4.Visible = false;
        var onaylananYorumlar = (from x in yemek.Yorumlar
                                 select new
                                 {
                                     YorumId = x.Id,
                                     AdSoyad = x.Kullanicilar.Ad_Soyad,
                                     Durum = x.OnayDurum
                                 }).Where(z => z.Durum == true).ToList();
        DataList1.DataSource = onaylananYorumlar;
        DataList1.DataBind();


        var onaylanmayanYorumlar = (from x in yemek.Yorumlar
                                    select new
                                    {
                                        YorumId = x.Id,
                                        AdSoyad = x.Kullanicilar.Ad_Soyad,
                                        Durum = x.OnayDurum
                                    }).Where(z => z.Durum == false).ToList();
        DataList2.DataSource = onaylanmayanYorumlar;
        DataList2.DataBind();


    }

    protected void btnListele_Click(object sender, EventArgs e)
    {
        panel2.Visible = true;
    }

    protected void btnListeKapat_Click(object sender, EventArgs e)
    {
        panel2.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        panel4.Visible = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        panel4.Visible = false;
    }
}