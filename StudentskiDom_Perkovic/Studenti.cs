using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiDom_Perkovic
{
    public class Studenti
    {
        public string OIB { get; set; }
        public string ImeStudenta { get; set; }
        public string PrezimeStudenta { get; set; }
        public string Adresa { get; set; }
        public string KontaktBroj { get; set; }

        //Vanjski ključevi
        public string OIBStudenta { get; set; }
        public string IdSobe { get; set; }
    }
}
