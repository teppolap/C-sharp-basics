using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele 3 alkioinen double taulukko ja lue siihen käyttäjältä arvot. 
Tulosta lopuksi syötettyjen lukujen summa ja keskiarvo seuraavasti:

SUMMA :     12.23
KESKIARVO : 4.07
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double[] Taulukko = new double[3];

            Console.WriteLine("Syötä kolme lukua: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Luku {i + 1}: ");
                Taulukko[i] = double.Parse(Console.ReadLine());
            }

            double summa = 0;

            for (int i = 0; i < 3; i++)
            {
                summa += Taulukko[i];
            }

            double keskiarvo = summa / Taulukko.Length;

            Console.WriteLine($"SUMMA :     {summa:F2}");
            Console.WriteLine($"KESKIARVO : {keskiarvo:F2}");
            Console.ReadLine();
        }
    }
}
