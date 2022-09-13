using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Categories : System.Web.UI.Page
{
    string id = "";
    string islem = "";
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    void Listele()
    {
        var kategoriler = (from x in yemek.Kategoriler
                           select new
                           {
                               KategoriId = x.Id,
                               KategoriAd = x.Ad,
                               KategoriResim = x.Resim

                           }).ToList();
        DataList1.DataSource = kategoriler;
        DataList1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            id = Request.QueryString["KategoriId"];
            islem = Request.QueryString["islem"];
        }
        panel2.Visible = false;
        panel4.Visible = false;
        Listele();

        if (islem == "sil")
        {
            int s = int.Parse(id);
            var kategori = yemek.Kategoriler.Find(s);
            yemek.Kategoriler.Remove(kategori);
            yemek.SaveChanges();
            Listele();
        }
    }

    protected void btnListele_Click(object sender, EventArgs e)
    {
        panel2.Visible = true;
    }

    protected void btnListeKapat_Click(object sender, EventArgs e)
    {
        panel2.Visible = false;
    }

    protected void btnEklemeOpen_Click(object sender, EventArgs e)
    {
        panel4.Visible = true;
    }

    protected void btnEklemeOff_Click(object sender, EventArgs e)
    {
        panel4.Visible = false;
    }
    protected void btnEkle_Click(object sender, EventArgs e)
    {
        Kategoriler kategori = new Kategoriler();
        kategori.Ad = txtAd.Text;
        kategori.Resim = fUResim.FileName;
        yemek.Kategoriler.Add(kategori);
        yemek.SaveChanges();
        txtAd.Text = "";
    }
}