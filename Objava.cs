using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljetni_Rad
{
    internal class Objava : Entitet
    {
        
        
        public string Opis { get; set; }
        public string IpAdresa { get; set; }
        public string Osoba { get; set; }

        public string Slika { get; set; }

        public override string ToString()
        {
            return  Osoba + "" + IpAdresa;
        }
    }
        
    }

