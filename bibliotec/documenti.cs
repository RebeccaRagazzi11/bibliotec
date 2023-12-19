using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bibliotec
{
    internal class documenti
    {
        public string codice { get; set; }
        public string titolo { get; set; }
        public int anno { get; set; }
        public string settore { get; set; }
        public string stato { get; set; } 
        
        public string scaffale { get; set; }    
        public List<autore> autori { get; set; }      


    }
}
