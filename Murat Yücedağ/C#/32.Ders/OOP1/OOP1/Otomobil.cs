using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Otomobil
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int ModelYili { get; set; }
        public string Renk { get; set; }
        public string VitesTipi { get; set; }
    
        public string MarkaGetir()
        {
            return Marka;
        }
    }
}
