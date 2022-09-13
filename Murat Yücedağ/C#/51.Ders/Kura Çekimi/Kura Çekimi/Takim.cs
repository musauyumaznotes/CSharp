using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kura_Çekimi
{
    class Takim
    {
        private string isim;
        private string ulke;

        public Takim(string isim,string ulke)
        {
            this.isim = isim;
            this.ulke = ulke;
        }

        public string Isim
        {
            get { return isim;}
            set { isim=value;}
        }
        public string Ulke
        {
            get { return ulke;}
            set { ulke=value;}

        }
        public override string ToString()
        {
            return isim + " - " + ulke;
        }
    }
}
