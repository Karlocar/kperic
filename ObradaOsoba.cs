using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljetni_Rad
{
    internal class ObradaOsoba
    {
        public List<Osoba> Osobe { get; }
        public ObradaOsoba()
        {
            Osobe = new List<Osoba>();
        }
        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s osobama");
            Console.WriteLine("1. Pregled postojećih osoba");
            Console.WriteLine("2. Unos nove osobe");
            Console.WriteLine("3. Promjena postojeće osobe");
            Console.WriteLine("4. Brisanje osobe");
            Console.WriteLine("5. Povratak na glavni izbornik");
            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika osoba: ",
                "Odabir mora biti 1 -5.", 1, 5))
            {
                case 2:
                    UcitajOsobu();
                    PrikaziIzbornik();
                    break;
                case 1:
                    PregledOsoba();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Gotov rad s osobama");
                    break;
            }
        }

        private void PregledOsoba()
        {
            foreach (Osoba osoba in Osobe)
            {
                Console.WriteLine(osoba);
            }
        }

        private void UcitajOsobu()
        {
            var e = new Osoba();

            e.Ime = Pomocno.UcitajString("Unesi ime osobe", "Ime obavezno");
            e.Prezime = Pomocno.UcitajString("Unesi prezime osobe", "Prezime obavezno");
            e.KorisnickoIme = Pomocno.UcitajString("Unesi Korisničko ime osobe", "Korisničko ime obavezno");
            e.Lozinka = Pomocno.UcitajString("Unesi Lozinku osobe", "Lozinka obavezna");
            Osobe.Add(e);
        }

    }
}
