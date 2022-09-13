using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;
namespace DataAccessLayer
{
    public class OgrenciDal
    {
        public static int OgrenciEkle(Ogrenci ogrenci)
        {
            SqlCommand komut = new SqlCommand("insert into Ogrenciler values(@Numara,@Ad,@Soyad,@Foto,@Sifre,@Bakiye)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }

            komut.Parameters.AddWithValue("@Ad", ogrenci.Ad);
            komut.Parameters.AddWithValue("@Soyad", ogrenci.Soyad);
            komut.Parameters.AddWithValue("@Numara", ogrenci.Numara);
            komut.Parameters.AddWithValue("@Foto", ogrenci.Fotograf);
            komut.Parameters.AddWithValue("@Sifre", ogrenci.Sifre);
            komut.Parameters.AddWithValue("@Bakiye", ogrenci.Bakiye);
            return komut.ExecuteNonQuery();

        }
        public static List<Ogrenci> Listele()
        {

            List<Ogrenci> liste = new List<Ogrenci>();
            SqlCommand komut = new SqlCommand("select * from Ogrenciler", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Id = int.Parse(oku["Id"].ToString());
                ogrenci.Ad = oku["Ad"].ToString();
                ogrenci.Soyad = oku["Soyad"].ToString();
                ogrenci.Numara = int.Parse(oku["Numara"].ToString());
                ogrenci.Sifre = oku["Sifre"].ToString();
                ogrenci.Bakiye = double.Parse(oku["Bakiye"].ToString());
                ogrenci.Fotograf = oku["Fotograf"].ToString();
                liste.Add(ogrenci);
            }
            oku.Close();
            return liste;
        }
        public static bool OgrenciSil(Ogrenci ogrenci)
        {
            SqlCommand komut = new SqlCommand("Delete from Ogrenciler Where Id=@id", Baglanti.bgl);
            komut.Parameters.AddWithValue("@id", ogrenci.Id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery() > 0;

        }
        public static bool OgrenciGuncelle(Ogrenci ogrenci)
        {
            SqlCommand komut = new SqlCommand("Update Ogrenciler set Ad=@ad,Soyad=@soyad,Numara=@numara,Bakiye=@bakiye,Sifre=@sifre,Fotograf=@fotograf Where Id=@id", Baglanti.bgl);
            komut.Parameters.AddWithValue("@id", ogrenci.Id);
            komut.Parameters.AddWithValue("@ad", ogrenci.Ad);
            komut.Parameters.AddWithValue("@soyad", ogrenci.Soyad);
            komut.Parameters.AddWithValue("@numara", ogrenci.Numara);
            komut.Parameters.AddWithValue("@bakiye", ogrenci.Bakiye);
            komut.Parameters.AddWithValue("@sifre", ogrenci.Sifre);
            komut.Parameters.AddWithValue("@fotograf", ogrenci.Fotograf);


            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<Ogrenci> OgrenciBul(int id)
        {
            List<Ogrenci> liste = new List<Ogrenci>();
            SqlCommand komut = new SqlCommand("select * from Ogrenciler Where Id=@id", Baglanti.bgl);
            komut.Parameters.AddWithValue("@id",id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Id = int.Parse(oku["Id"].ToString());
                ogrenci.Ad = oku["Ad"].ToString();
                ogrenci.Soyad = oku["Soyad"].ToString();
                ogrenci.Numara = int.Parse(oku["Numara"].ToString());
                ogrenci.Sifre = oku["Sifre"].ToString();
                ogrenci.Bakiye = double.Parse(oku["Bakiye"].ToString());
                ogrenci.Fotograf = oku["Fotograf"].ToString();
                liste.Add(ogrenci);
            }
            oku.Close();
            return liste;
        }
    }
}
