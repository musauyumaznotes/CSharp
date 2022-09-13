using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GununYemegi : System.Web.UI.Page
{
    YemekTarifiEntities yemek = new YemekTarifiEntities();
    Random random = new Random();
    protected void Page_Load(object sender, EventArgs e)
    {
        var deger = (from x in yemek.Yemeklers
                        select new
                        {
                            Id = x.Id,
                            Ad = x.Tarifler.Ad,
                            Malzeme = x.Tarifler.Malzeme,
                            Tarif = x.Tarifler.Tarif,
                            Resim = x.Tarifler.Resim,
                            Puan = x.Puan,
                            GununYemegi=x.GununYemegi,
                            Tarih = x.Tarifler.Tarih
                        }).Where(z => z.GununYemegi==true ).ToList();//
        DataList2.DataSource = deger;
        DataList2.DataBind();
        //List<int> liste = new List<int>();
        //foreach (var x in yemek.Yemekler)
        //{
        //    liste.Add(x.Id);
        //}
        //var rastgele = random.Next(0, liste.Count);
        //var sayi = liste[rastgele];
        //var degerler = (from x in yemek.Yemekler
        //                select new
        //                {
        //                    Id = x.Id,
        //                    Ad = x.Tarifler.Ad,
        //                    Malzeme = x.Tarifler.Malzeme,
        //                    Tarif = x.Tarifler.Tarif,
        //                    Resim = x.Tarifler.Resim,
        //                    Puan = x.Puan,
        //                    Tarih = x.Tarifler.Tarih
        //                }).Where(z => z.Id == sayi);//
        //DataList2.DataSource = degerler.ToList();
        //DataList2.DataBind();

    }
}