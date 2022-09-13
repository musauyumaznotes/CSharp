using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OgrenciSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["Id"]);
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Id = id;
        OgrenciManager.OgrenciSil(ogrenci);
        Response.Redirect("OgrenciListele.aspx");
    }
}