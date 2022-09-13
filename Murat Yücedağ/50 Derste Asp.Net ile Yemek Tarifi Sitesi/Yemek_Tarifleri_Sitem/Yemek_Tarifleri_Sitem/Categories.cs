using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories: Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        Panel4.Visible = false;
        Listele();
    }
    void Listele()
    {
        var kategoriler = (from x in yemek.Kategoriler
                           select new
                           {
                               KategoriId=x.Id,
                               Ad = x.Ad
                           }).ToList();
        DataList1.DataSource = kategoriler;
        DataList1.DataBind();
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel2.Visible = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel4.Visible = true;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel4.Visible = false;
    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        Kategoriler kategori = new Kategoriler();
        kategori.Ad = TextBox1.Text;
        kategori.Resim = FileUpload2.FileName;
        yemek.Kategoriler.Add(kategori);
        yemek.SaveChanges();
        Temizle();
        Listele();
    }
    void Temizle()
    {
        TextBox1.Text = "";
    }
}