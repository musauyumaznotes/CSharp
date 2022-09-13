using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tarifler : System.Web.UI.Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities(); 
    protected void Page_Load(object sender, EventArgs e)
    {
        panel2.Visible = false;
        var pasifTarifler = (from x in yemek.Tarifler
                             select new 
                             {
                                 TarifId=x.Id,
                                 TarifAd=x.Ad,
                                 Durum=x.Durum

                             }).Where(z=>z.Durum==false).ToList();
        DataList1.DataSource = pasifTarifler;
        DataList1.DataBind();
    }

    protected void btnListele_Click(object sender, EventArgs e)
    {
        panel2.Visible = true;
    }

    protected void btnListeKapat_Click(object sender, EventArgs e)
    {
        panel2.Visible = false;
    }
}