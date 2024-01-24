using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


/*
Lue käyttäjältä kaksi kokonaislukua sekä operaatio joka lukujen välillä
suoritetaan (voi olla +, -, * tai / eli kyseessä siis nelilaskin).

Käytä operaation tallentamiseen string-tyyppistä muuttujaa.

Tutki switch-case rakenteessa minkä operaation käyttäjä syötti ja
tulosta sen perusteella lukujen laskutoimitus vastauksineen. Osamäärä
tulostetaan kahden desimaalin tarkkuudella

Esimerkiksi
jos käyttäjä syöttää luvut "12" ja "13" ja operaatioksi "+" niin tulostetaan

12 + 13 = 25

Jos operaatio oli annettu väärin, niin tulosta virheilmoitus
"annoit operaation väärin"

Nollalla jakoa ei saa ohjelmassa tapahtua, vaan silloin tulostetaan
"Nollalla jako, ei voida suorittaa"
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

            Console.WriteLine("Syötä operaatio (+, -, *, /):");
            string operaatio = Console.ReadLine();

            double tulos = 0;

            switch (operaatio)
            {
                case "+":
                    tulos = luku1 + luku2;
                    Console.WriteLine("{0} + {1} = {2}", luku1, luku2, tulos);
                    break;
                case "-":
                    tulos = luku1 - luku2;
                    Console.WriteLine("{0} - {1} = {2}", luku1, luku2, tulos);
                    break;
                case "*":
                    tulos = luku1 * luku2;
                    Console.WriteLine("{0} * {1} = {2}", luku1, luku2, tulos);
                    break;
                case "/":
                    if (luku2 != 0)
                    {
                        tulos = (double)luku1 / luku2;
                        Console.WriteLine("{0} / {1} = {2:F2}", luku1, luku2, tulos);
                    }
                    else
                    {
                        Console.WriteLine("Nollalla jako, ei voida suorittaa");
                    }
                    break;
                default:
                    Console.WriteLine("annoit operaation väärin");
                    break;
            }

            Console.ReadLine();
        }
    }
}

