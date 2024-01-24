using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Esittele 10 alkioinen int taulukko ja arvo siihen lukuja väliltä 0-10. 
Vain parilliset luvut sallitaan.Jos arvottiin pariton luku niin sen 
tilalle on arvottava uusi luku.

Tulosta luvut ensin taulukon alusta loppuun tabulaattorilla eroteltuna
ja seuraavalla rivillä lopusta alkuun tabulaattorilla eroteltuna
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            const int koko = 10;
            int[] taulukko = new int[koko];

            Random random = new Random();

            for (int i = 0; i < koko; i++)
            {
                int luku;
                do
                {
                    luku = random.Next(11); 
                } while (luku % 2 != 0); 

                taulukko[i] = luku;
            }

            for (int i = 0; i < koko; i++)
            {
                Console.Write(taulukko[i]);
                if (i < koko - 1)
                {
                    Console.Write("\t"); 
                }
            }
            Console.WriteLine();

            for (int i = koko - 1; i >= 0; i--)
            {
                Console.Write(taulukko[i]);
                if (i > 0)
                {
                    Console.Write("\t"); 
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

