using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    public class Emlak
    {
        private string semt;
        private int odaSayisi;
        private int katNo;
        private int alan;

        public string Semt { get => semt; set => semt = value.ToUpper(); }
        public int OdaSayisi { get => odaSayisi; set => odaSayisi = Math.Abs(value); }
        public int KatNo { get => katNo; set => katNo = Math.Abs(value); }
        public int Alan { get => alan; set => alan = Math.Abs(value); }
    }
}
