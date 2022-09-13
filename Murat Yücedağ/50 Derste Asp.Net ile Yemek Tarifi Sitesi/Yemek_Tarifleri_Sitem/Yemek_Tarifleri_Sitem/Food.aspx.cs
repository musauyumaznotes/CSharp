using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Food : System.Web.UI.Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    void Listele()
    {
        var yemekler = (from x in yemek.Yemeklers
                        select new
                        {
                            YemekId = x.Id,
                            YemekAd = x.Tarifler.Ad,
                            TarifId=x.TarifId,
                            YemekDurum = x.Tarifler.Durum

                        }).Where(z => z.YemekDurum == true).ToList();
        DataList1.DataSource = yemekler;
        DataList1.DataBind();
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
    string id;
    string islem;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            id = Request.QueryString["YemekId"];
            islem = Request.QueryString["islem"];
            KategoriListele();
        }
        panel2.Visible = false;
        panel4.Visible = false;
        Listele();
       
        if (islem == "sil")
        {
            int s = int.Parse(id);
            var yemeks = yemek.Yemeklers.Find(s);
            yemeks.Tarifler.Durum = false;
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
    Tarifler tarif = new Tarifler();
    Yemekler food = new Yemekler();
    protected void Button1_Click(object sender, EventArgs e)
    {
        tarif.KullaniciId = 1;
        tarif.KategoriId = int.Parse(dListKategori.SelectedValue);
        tarif.Ad = txtAd.Text;
        tarif.Tarif = txtTarif.Text;
        tarif.Malzeme = txtMalzeme.Text;
        tarif.Durum = true;
        tarif.Resim = FileUpload1.FileName;
        yemek.Tarifler.Add(tarif);
        yemek.SaveChanges();

        food.TarifId = tarif.Id;
        yemek.Yemeklers.Add(food);
        yemek.SaveChanges();
        Temizle();
        Listele();
    }
    void Temizle()
    {
        txtAd.Text = "";
        txtMalzeme.Text = "";
        txtTarif.Text = "";
    }
}