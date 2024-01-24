using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Kysy käyttäjältä mistä luvusta tulostetaan ja mihin asti ja millaisella askelluksella. 

HUOM! Mistä on oltava pienempi kuin mihin ja askelluksen oltava suurempi kuin 0.
Muuten kysyttävä tiedot uudestaan.

Tulosta lukusarjat sekä while-, do-while- että for-silmukoilla. 

Esimerkki:
Jos mistä on 5, mihin on 11 ja askellus on 2, niin ohjelma tulostaa kaikilla
kolmella silmukalla saman, alla olevan lukusarjan (lukujen välissä kaksi välilyöntiä).
Tulosta myös millä silmukalla luvut on tulostettu. 

WHILE:
5  7  9  11

DO-WHILE:
5  7  9  11

FOR:
5  7  9  11
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int mista, mihin, askellus;

            do
            {
                Console.WriteLine("Syötä mistä luvusta tulostetaan:");
                mista = int.Parse(Console.ReadLine());

                Console.WriteLine("Syötä mihin asti tulostetaan:");
                mihin = int.Parse(Console.ReadLine());

                Console.WriteLine("Syötä askellus:");
                askellus = int.Parse(Console.ReadLine());

                if (mista >= mihin || askellus <= 0)
                {
                    Console.WriteLine("Virheelliset syötteet. Yritä uudelleen.");
                }

            } while (mista >= mihin || askellus <= 0);

            Console.WriteLine("\nWHILE:");
            int luku = mista;
            while (luku <= mihin)
            {
                Console.Write("{0}  ", luku);
                luku += askellus;
            }

            Console.WriteLine("\n\nDO-WHILE:");
            luku = mista;
            do
            {
                Console.Write("{0}  ", luku);
                luku += askellus;
            } while (luku <= mihin);

            Console.WriteLine("\n\nFOR:");
            for (luku = mista; luku <= mihin; luku += askellus)
            {
                Console.Write("{0}  ", luku);
            }

            Console.ReadLine();
        }
    }
}

