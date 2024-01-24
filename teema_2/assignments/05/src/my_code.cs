using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä ympyrän säde liukulukuna.

Kysy käyttäjältä myös, haluaako hän tehdä kumpaa seuraavista
(eli käyttäjä syöttää joko numeron 1 tai 2) :

    1 = laske ympyrän piiri
    2 = laske ympyrän pinta-ala

Tämän vastauksen perusteella laske dTulos-muuttujaan joko piiri
tai pinta-ala ja tulosta se. 

Toteuta tämä sekä if-rakenteella että ehdollisella operaattorilla.
Tulostus pitää siis tehdä kaksi kertaa alla olevalla tavalla:

Tulos : 12.22
Tulos : 12.22
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä ympyrän säde:");
            double sade = double.Parse(Console.ReadLine());

            Console.WriteLine("Valitse laskettava tulos:");
            Console.WriteLine("1 = Laske ympyrän piiri");
            Console.WriteLine("2 = Laske ympyrän pinta-ala");
            int valinta = int.Parse(Console.ReadLine());

            double tulos = 0;

            if (valinta == 1)
            {
                tulos = 2 * Math.PI * sade;
                Console.WriteLine("Tulos : {0:F2}", tulos);
            }
            else if (valinta == 2)
            {
                tulos = Math.PI * Math.Pow(sade, 2);
                Console.WriteLine("Tulos : {0:F2}", tulos);
            }
            else
            {
                Console.WriteLine("Virheellinen valinta.");
            }

            Console.ReadLine();

        }
    }
}

