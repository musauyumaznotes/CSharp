using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GununYemegiAdmin : System.Web.UI.Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        panel2.Visible = false;
        var yemekler = (from x in yemek.Yemeklers
                        select new 
                        {
                            YemekId=x.Id,
                            TarifId=x.TarifId,
                            YemekAd=x.Tarifler.Ad,
                            Durum=x.Tarifler.Durum,
                        }).Where(y=>y.Durum==true).ToList();
        DataList1.DataSource = yemekler;
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