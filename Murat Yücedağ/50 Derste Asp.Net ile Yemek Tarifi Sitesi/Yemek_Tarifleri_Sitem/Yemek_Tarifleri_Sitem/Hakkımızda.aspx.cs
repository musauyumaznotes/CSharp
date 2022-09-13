using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hakkımızda : System.Web.UI.Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        var deger = from x in yemek.Hakkimizdas1
                    select new
                    {
                        x.Metin
                    };
        DataList2.DataSource = deger.ToList();
        DataList2.DataBind();
    }
}