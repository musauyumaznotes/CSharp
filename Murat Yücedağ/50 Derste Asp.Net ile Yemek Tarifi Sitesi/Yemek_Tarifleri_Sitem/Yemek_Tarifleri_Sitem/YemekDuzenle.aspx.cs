using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class YemekDuzenle : System.Web.UI.Page
{
    int id;
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            id = int.Parse(Request.QueryString["TarifId"]);
            KategoriListele();

            var food = (from x in yemek.Tarifler
                        select new
                        {
                            TarifId = x.Id,
                            TarifAd = x.Ad,
                            Tarif = x.Tarif,
                            Malzeme = x.Malzeme,
                            Kategori = x.KategoriId,
                            Resim = x.Resim
                        }).Where(z => z.TarifId == id).FirstOrDefault();
            txtYemekAd.Text = food.TarifAd;
            txtMalzeme.Text = food.Malzeme;
            txtTarif.Text = food.Tarif;
            dListKategori.SelectedValue = food.Kategori.ToString();
            //fUploadResim. = food.Resim;
        }

    }
    void KategoriListele()
    {
        var kategoriler = (from x in yemek.Kategoriler
                           select new
                           {
                               KategoriId = x.Id,
                               KategoriAd = x.Ad
                           }).ToList();
        dListKategori.DataTextField = "KategoriAd";
        dListKategori.DataValueField = "KategoriId";
        dListKategori.DataSource = kategoriler;
        dListKategori.DataBind();
    }
    protected void btnGuncelle_Click(object sender, EventArgs e)
    {
        fUploadResim.SaveAs(Server.MapPath("/resimler/"+fUploadResim.FileName));
        int id1 = int.Parse(Request.QueryString["TarifId"]);
        var tarif = yemek.Tarifler.Find(id1);
        tarif.Ad = txtYemekAd.Text;
        tarif.Malzeme = txtMalzeme.Text;
        tarif.Tarif = txtTarif.Text;
        tarif.KategoriId = int.Parse(dListKategori.SelectedValue);
        tarif.Resim = "~/resimler/"+fUploadResim.FileName;
        yemek.SaveChanges();
        Temizle();
    }

    private void Temizle()
    {
        txtYemekAd.Text = "";
        txtTarif.Text = "";
        txtMalzeme.Text = "";
    }

    protected void btnGununYemegi_Click(object sender, EventArgs e)
    {
        int id2 = int.Parse(Request.QueryString["TarifId"]);
        var yemekler = yemek.Yemeklers.Where(x => x.GununYemegi == true);
        foreach (var x in yemekler)
        {
            x.GununYemegi = false;
        }
        yemek.SaveChanges();
        var gununYemegi = yemek.Yemeklers.Where(c => c.TarifId == id2).FirstOrDefault();
        gununYemegi.GununYemegi = true;
        yemek.SaveChanges();
        Response.Write(gununYemegi.Tarifler.Ad + " Günün Yemeği Seçildi");
    }

    protected void btnOnayla_Click(object sender, EventArgs e)
    {
        int id3 = int.Parse(Request.QueryString["TarifId"]);
        var onaylanacakYemek = yemek.Tarifler.Where(c => c.Id == id3).FirstOrDefault();
        onaylanacakYemek.Durum = true;
        yemek.SaveChanges();
        Temizle();

    }
}