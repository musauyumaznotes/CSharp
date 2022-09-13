using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MesajRead : System.Web.UI.Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        panel2.Visible = false;
        MesajListele();

    }
    void MesajListele()
    {
        var mesajlar = (from x in yemek.Mesajlar
                        select new
                        {
                            MesajId = x.Id,
                            Gonderen = x.Gonderen
                        }).ToList();
        DataList1.DataSource = mesajlar;
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