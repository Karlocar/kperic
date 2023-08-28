using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljetni_Rad
{
    internal class Osoba:Entitet
    {
        public String Ime { get; set; }
        public String   Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
    }
}
