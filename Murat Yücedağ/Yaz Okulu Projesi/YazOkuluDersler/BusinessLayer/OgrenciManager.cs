using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OgrenciManager
    {
        public static int OgrenciEkle(Ogrenci ogrenci)
        {
            if (ogrenci.Ad != null && ogrenci.Numara != 0 && ogrenci.Soyad != null && ogrenci.Sifre != null && ogrenci.Fotograf != null)
            {
                return OgrenciDal.OgrenciEkle(ogrenci);
            }
            return -1;
        }
        public static List<Ogrenci> Listele()
        {
            return OgrenciDal.Listele();
        }
        public static bool OgrenciSil(Ogrenci ogrenci)
        {
            if (ogrenci != null)
            {
                return OgrenciDal.OgrenciSil(ogrenci);
            }
            return false;
        }
        public static bool OgrenciGuncelle(Ogrenci ogrenci)
        {
            if (ogrenci.Ad != null && ogrenci.Numara != 0 && ogrenci.Soyad != null && ogrenci.Sifre != null && ogrenci.Fotograf != null)
            {
                return OgrenciDal.OgrenciGuncelle(ogrenci);
            }
            return false;
        }
        public static List<Ogrenci> OgrenciBul(int id)
        {
            return OgrenciDal.OgrenciBul(id);
        }
    }
}
