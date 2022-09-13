using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Iletisim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    Mesajlar mesaj = new Mesajlar();
    void Temizle()
    {
        txtKonu.Text = "";
        txtAdSoyad.Text = "";
        txtMesaj.Text = "";
        txtMail.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        mesaj.Baslik = txtKonu.Text;
        mesaj.Gonderen = txtAdSoyad.Text;
        mesaj.Mail = txtMail.Text;
        mesaj.Icerik = txtMesaj.Text;
        yemek.Mesajlar.Add(mesaj);
        yemek.SaveChanges();
        Temizle();
        Response.Write("Mesaj Kaydedildi");


    }
}