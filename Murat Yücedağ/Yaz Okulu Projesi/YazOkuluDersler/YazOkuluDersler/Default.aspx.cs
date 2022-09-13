using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Ad = txtAd.Text;
        ogrenci.Soyad = txtSoyad.Text;
        ogrenci.Numara = int.Parse(txtNumara.Text);
        ogrenci.Sifre = txtSifre.Text;
        ogrenci.Fotograf = txtFoto.Text;
       
        OgrenciManager.OgrenciEkle(ogrenci);
        Temizle();
        

    }
    void Temizle()
    {
        txtAd.Text = "";
        txtSoyad.Text = "";
        txtNumara.Text = "";
        txtSifre.Text = "";
        txtFoto.Text = "";
    }
}