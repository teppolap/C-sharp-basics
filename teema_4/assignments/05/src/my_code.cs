using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele sellainen 2-ulottoinen taulukko, johon voit tallentaa maanantain ja perjantain välisenä aikana 
neljä mittaustulosta jokaiselta päivältä (mittaustulos on sademäärä milleinä). Lue käyttäjältä nämä 
mittaustulokset taulukkoon ja tulosta lopuksi jokaisen päivän mittaustulosten 
keskiarvo seuraavan esimerkin mukaisesti :

Maanantai   : 12.0 mm
Tiistai     : 0.0 mm
Keskiviikko : 1.9 mm
Torstai     : 22.8 mm
Perjantai   : 0.9 mm
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double[,] mittaustulokset = new double[5, 4]; 

          
            string[] paivat = { "Maanantai", "Tiistai", "Keskiviikko", "Torstai", "Perjantai" };

           
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Syötä mittaustulokset {paivat[i]}:");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Mittaustulos {j + 1}: ");
                    double mittaustulos = double.Parse(Console.ReadLine());
                    mittaustulokset[i, j] = mittaustulos;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Mittaustulosten keskiarvot:");

            
            for (int i = 0; i < 5; i++)
            {
                double summa = 0;
                for (int j = 0; j < 4; j++)
                {
                    summa += mittaustulokset[i, j];
                }
                double keskiarvo = summa / 4;
                Console.WriteLine($"Maanantai   : {keskiarvo:F1}");
                Console.WriteLine($"Tiistai     : {keskiarvo:F1}");
                Console.WriteLine($"Keskiviikko : {keskiarvo:F1}");
                Console.WriteLine($"Torstai     : {keskiarvo:F1}");
                Console.WriteLine($"Perjantai   : {keskiarvo:F1}");
                Console.ReadLine();
            }
        }
    }
}

