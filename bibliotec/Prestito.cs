using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotec
{
    internal class Prestito
    {
        public string numeroprogressivo { get; set; }
        public DateTime dal{ get; set; }
        public DateTime al { get; set; }

        public utente utente { get; set; } 

        public documenti documento  { get; set; }


    }
}
