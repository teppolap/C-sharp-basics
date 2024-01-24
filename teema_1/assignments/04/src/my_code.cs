using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele nimi, pituus ja paino muuttujat. Esittele lisäksi bmi muuttuja.
Kysy käyttäjältä nimi, pituus metreinä ja paino kilon tarkkuudella.
Laske painoindeksi bmi muuttujaan seuraavasti:

bmi = paino / pituus ^ 2

Tulosta lopuksi:

Olli Opiskelija, pituutesi on 1,81 m ja painosi 104 kg
Painoindeksisi on siten 31,75
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            string nimi;
            double pituus, paino, bmi;

            Console.Write("Syötä nimi: ");
            nimi = Console.ReadLine();

            Console.Write("Anna pituus metreina: ");
            pituus = double.Parse(Console.ReadLine());

            Console.Write("Anna paino kg: ");
            paino = double.Parse(Console.ReadLine());

            bmi = paino / (pituus * pituus);
            bmi = Math.Round(bmi, 2);

            Console.WriteLine("{0}, pituutesi on {1} m ja painosi {2} kg", nimi, pituus, paino);
            Console.WriteLine("Painoindeksisi on siten {0}", bmi);

        }
    }
}

