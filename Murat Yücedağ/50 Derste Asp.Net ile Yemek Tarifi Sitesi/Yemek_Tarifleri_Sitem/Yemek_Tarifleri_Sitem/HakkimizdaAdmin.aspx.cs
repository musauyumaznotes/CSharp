using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HakkimizdaAdmin : System.Web.UI.Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            panel2.Visible = false;
            var hakkimizda = (from x in yemek.Hakkimizdas1
                              select new
                              {
                                  Id = x.Id,
                                  Metin = x.Metin
                              }).Where(z => z.Id == 1).FirstOrDefault();
            TextBox1.Text = hakkimizda.Metin;
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Hakkimizdas hakkimizda = new Hakkimizdas();
        hakkimizda.Metin = TextBox1.Text;
        hakkimizda.Id = 1;
        yemek.Hakkimizdas1.Add(hakkimizda);
        yemek.SaveChanges();
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