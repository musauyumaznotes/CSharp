using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Kullanici : System.Web.UI.MasterPage
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        var degerler = from x in yemek.Kategoriler
                       select new
                       {
                           x.Id,
                           x.Ad,
                           x.Resim
                       };
        DataList1.DataSource = degerler.ToList();
        DataList1.DataBind();
    }
}
