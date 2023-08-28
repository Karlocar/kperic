using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljetni_Rad
{
    internal class ObradaObjava
    {
        public List<Objava> Objave { get;  }
        public ObradaObjava() 
        { 
            Objave = new List<Objava>();
        }

        public void PrikaziIzbornik() 
        {
            Console.WriteLine("Izbornik za rad s objavama");
            Console.WriteLine("1. Pregled postojećih objava");
            Console.WriteLine("2. Unos nove objave");
            Console.WriteLine("3. Promjena postojeće objave");
            Console.WriteLine("4. Brisanje objave");
            Console.WriteLine("5. Povratak na glavni izbornik");
            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika objava: ",
               "Odabir mora biti 1-5", 1,5))
            {
                case 2:
                    UcitajObjavu();
                    PrikaziIzbornik();
                    break;
                    case 1:
                    PregledObjava();
                    PrikaziIzbornik();
                    break;
                        case 5:
                    Console.WriteLine("Gotov rad s objavama");
                    break;
            } 
        }

        private void PregledObjava()
        {
            foreach (Objava objava in Objave)
            {
                Console.WriteLine(objava);
            }
        }

        private void UcitajObjavu()
        {
            var p = new Objava();
            p.IpAdresa = Pomocno.UcitajString("Unesi ipadresu objave", "IpAdresa obavezna");
            p.Opis = Pomocno.UcitajString("Unesi opis objave", "Opis obavezan");
            p.Osoba= Pomocno.UcitajString("Unesi objavu osobe", "Osoba obavezna");
            p.Slika = Pomocno.UcitajString("Unesi sliku objave", "Slika obavezna");

            Objave.Add(p);

        }
    }

}
