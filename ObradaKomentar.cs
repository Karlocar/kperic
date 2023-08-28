using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljetni_Rad
{
    internal class ObradaKomentar
    {
        public List<Komentar> Komentari { get; }

        public ObradaKomentar()
        {
            Komentari = new List<Komentar>();
            TestniPodaci();

        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s komentarima");
            Console.WriteLine("1. Pregled postojećih komentara");
            Console.WriteLine("2. Unos novog komentara");
            Console.WriteLine("3. Promjena postojećeg komentara");
            Console.WriteLine("4. Brisanje komentara");
            Console.WriteLine("5. Povratak na glavni izbornik");
            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika komentar: ",
                "Odabir mora biti 1 -5.", 1, 5))
            {
                case 1:
                    PrikaziKomentare();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogKomentara();
                    PrikaziIzbornik();
                    break;

                case 5:
                    Console.WriteLine("Gotov rad s komentarima");
                    break;

            }

        }

        private void UnosNovogKomentara()
        {
            var s = new Komentar();
            s.Sifra = Pomocno.ucitajCijeliBroj("Unesite šifra komentara: ", 
                "Unos mora biti cijeli pozitivni broj");
            s.Osoba = Pomocno.UcitajString("Unesite osobu koja komentira: ",
                "Unos obavezan");
            s.Objava = Pomocno.ucitajString("Unesite objavu komentara: ",
                "Unos Obavezan");
                
                 
                Komentari.Add(s);

        }

        private void PrikaziKomentare()
        {
            foreach (Komentar komentar in Komentari)
            {
                Console.WriteLine(komentar.Osoba);
            }
        }

        private void TestniPodaci() 
        {
            Komentari.Add(new Komentar { Osoba = "markomaric" });
        }
        
        
    }
}

