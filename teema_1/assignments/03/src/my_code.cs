using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele kaksi kokonaislukumuuttujaa ja lue niihin käyttäjältä arvot.
Tulosta näiden muuttujien summa, erotus ja tulo alla olevalla tavalla
(HUOM! Laskutoimituksen tulostus alkaa kaikissa samasta kohdasta!)

Summa :  10 + 5 = 15
Erotus : 10 - 5 = 5
Tulo :   10 * 5 = 50
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä ensimmäinen kokonaisluku:");
            int luku1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä toinen kokonaisluku:");
            int luku2 = int.Parse(Console.ReadLine());

            int summa = luku1 + luku2;
            int erotus = luku1 - luku2;
            int tulo = luku1 * luku2;

            Console.WriteLine("Summa :  {0} + {1} = {2}", luku1, luku2, summa);
            Console.WriteLine("Erotus : {0} - {1} = {2}", luku1, luku2, erotus);
            Console.WriteLine("Tulo :   {0} * {1} = {2}", luku1, luku2, tulo);

            Console.ReadLine();
        }
    }
}
