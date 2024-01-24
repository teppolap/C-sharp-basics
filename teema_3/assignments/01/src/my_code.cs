using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä kokonaislukuja while-silmukassa, kunnes käyttäjä syöttää arvon -1. 
Sen jälkeen tulosta syötettyjen lukujen keskiarvo yhden desimaalin tarkkuudella
alla olevalla tavalla:

"Keskiarvo : 12.1"

Lukua -1 ei oteta keskiarvon laskentaan mukaan.

Jos käyttäjä ei syöttänyt yhtään lukua, niin keskiarvoa ei saa tulostaa
vaan silloin tulostetaan

"Et antanut yhtään lukua"
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int count = 0;

            Console.WriteLine("Syötä kokonaislukuja (-1 lopettaa syöttämisen): ");

            while (true)
            {
                int input;
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Virheellinen syöte. Syötä kokonaisluku.");
                    continue;
                }

                if (input == -1)
                    break;

                sum += input;
                count++;
            }

            if (count == 0)
            {
                Console.WriteLine("Et antanut yhtään lukua");
            }
            else
            {
                double average = (double)sum / count;
                Console.WriteLine("Keskiarvo: {0:F1}", average);
            }

        }
    }
}
