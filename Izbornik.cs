using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ljetni_Rad
{
    internal class Izbornik
    {
        private ObradaKomentar ObradaKomentar;
        private ObradaObjava ObradaObjava;
        private ObradaOsoba ObradaOsoba;
        public Izbornik() 
        {
            ObradaKomentar = new ObradaKomentar();
            ObradaObjava = new ObradaObjava();
            ObradaOsoba = new ObradaOsoba();
            PozdravnaPoruka();
            PrikaziIzbornik();
        } 
        private void PozdravnaPoruka()
        
       {
            Console.WriteLine("*****************************************");
            Console.WriteLine("****** Instagram Console APP v 1.0 ******");
            Console.WriteLine("*****************************************");
            

        }
        public void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Komentar");
            
            Console.WriteLine("2. Objava");
            Console.WriteLine("3. Osoba");
            Console.WriteLine("4. Izlaz iz programa ");
            
            switch (Pomocno.ucitajBrojRaspon("Odaberite stavku izbornika: ",
                "Odabir mora biti 1 - 4.",1,4))
            {
                case 1:
                    ObradaKomentar.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                                
                    case 2:
                    ObradaObjava.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                    case 3:
                    ObradaOsoba.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                    case 4:
                    Console.WriteLine("Hvala na korištenju, doviđenja");
                    break;
            }
        }




    }
}
