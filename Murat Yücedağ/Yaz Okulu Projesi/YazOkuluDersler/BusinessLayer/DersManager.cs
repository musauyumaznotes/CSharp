using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class DersManager
    {
        public static List<Ders> DersListele()
        {
            return DersDal.DersListele();
        }
        public static int TalepEkle(Basvuru basvuru)
        {
            return DersDal.TalepEkle(basvuru);
        }
    }
}
