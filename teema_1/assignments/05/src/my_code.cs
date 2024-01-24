using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele muuttuja pii, jolle annat alkuarvoksi piin likiarvon 6 desimaalin tarkkuudella.
Lue käyttäjältä ympyrän halkaisija ja tulosta ympyrän piiri ja pinta-ala kolmen desimaalin
tarkkuudella seuraavasti (halkaisijaksi annettu 2,5) :

PIIRI     : 7,854
PINTA-ALA : 4,909 
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double pii = 3.141592653589793238;

            Console.WriteLine("Syötä ympyrän halkaisija:");
            double halkaisija = double.Parse(Console.ReadLine());

            double piiri = pii * halkaisija;
            double pintaAla = (pii / 4) * Math.Pow(halkaisija, 2);

            Console.WriteLine("PIIRI     : {0:F3}", piiri);
            Console.WriteLine("PINTA-ALA : {0:F3}", pintaAla);

            Console.ReadLine();

        }
    }
}

