using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["Id"]);

        var ogrenci = OgrenciManager.OgrenciBul(id);
        txtId.Enabled = false;
        if (Page.IsPostBack==false)
        {
            txtId.Text = id.ToString();
            txtAd.Text = ogrenci[0].Ad;
            txtSoyad.Text = ogrenci[0].Soyad;
            txtNumara.Text = ogrenci[0].Numara.ToString();
            txtSifre.Text = ogrenci[0].Sifre;
            txtFoto.Text = ogrenci[0].Fotograf;
            
        }
       


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["Id"]);
        var ogrenci = OgrenciManager.OgrenciBul(id);
        ogrenci[0].Ad = txtAd.Text;
        ogrenci[0].Soyad = txtSoyad.Text;
        ogrenci[0].Numara = int.Parse(txtNumara.Text);
        ogrenci[0].Sifre = txtSifre.Text;
        ogrenci[0].Fotograf = txtFoto.Text;
        OgrenciManager.OgrenciGuncelle(ogrenci[0]);
        Response.Redirect("OgrenciListele.aspx");

    }
}