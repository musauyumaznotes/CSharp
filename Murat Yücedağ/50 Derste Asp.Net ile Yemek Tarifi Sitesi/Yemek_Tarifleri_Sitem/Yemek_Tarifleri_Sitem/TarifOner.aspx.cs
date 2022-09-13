using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TarifOner : System.Web.UI.Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    Kullanicilar kullanici = new Kullanicilar();
    protected void Page_Load(object sender, EventArgs e)
    {
        KategoriListele();
    }
    void KategoriListele()
    {
        var kategoriler = (from x in yemek.Kategoriler
                           select new
                           {
                               KategoriId = x.Id,
                               KategoriAd = x.Ad
                           }).ToList();
        DropDownList1.DataTextField = "KategoriAd";
        DropDownList1.DataValueField = "KategoriId";
        DropDownList1.DataSource = kategoriler;
        DropDownList1.DataBind();
    }
    protected void btnTarifOner_Click(object sender, EventArgs e)
    {
        Tarifler tarif = new Tarifler();
        fileUploadResim.SaveAs(Server.MapPath("/resimler/"+fileUploadResim.FileName));
        if (UserExists(txtEmail.Text))
        {
            kullanici.Ad_Soyad = txtAdSoyad.Text;
            kullanici.Email = txtEmail.Text;
            yemek.Kullanicilar.Add(kullanici);
            yemek.SaveChanges();
            tarif.Ad = txtYemekAd.Text;
            tarif.KategoriId = int.Parse(DropDownList1.SelectedValue);
            tarif.KullaniciId = kullanici.Id;
            tarif.Malzeme = txtMalzeme.Text;
            tarif.Tarif = txtTarif.Text;
            tarif.Resim ="~/resimler/" +fileUploadResim.FileName;
            tarif.Tarih = DateTime.Parse(DateTime.Now.ToLongDateString());
            tarif.Durum = false;
            yemek.Tarifler.Add(tarif);
            yemek.SaveChanges();
            Temizle();
            Response.Write("Tarifiniz Alınmıştır");
        }
        else
        {
         
            //}


        }
       
    }
    private bool UserExists(string email)
    {
        var deger = kullanici.Email;
        var hesap = yemek.Kullanicilar.Find(deger);
        if (hesap == null)
        {
            return false;

        }
        return true;
    }
    void Temizle()
    {
        txtAdSoyad.Text = "";
        txtEmail.Text = "";
        txtMalzeme.Text = "";
        txtTarif.Text = "";
        txtYemekAd.Text = "";
    }
}