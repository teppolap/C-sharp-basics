using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Lotossa arvotaan seitsemän (7) varsinaista numeroa ja yksi (1) lisänumero. Numerot ovat väliltä 1-40. 
Esittele kahdeksan (8) alkioinen lotto-taulukko ja arvo siihen lottonumerot (7 ensimmäistä on siis 
varsinaisia lottonumeroita ja viimeinen on lisänumero). Muista, että samaa numeroa ei saa tulla 
lottoriviin eli mieti miten voisit tarkistaa onko arvottu numero jo lottorivissä entuudestaan ja 
silloin sen tilalle pitää arpoa uusi numero.

Tulosta ensi arvottu rivi ja sitten lajiteltu lottorivi seuraavasti:

ARVOTTU   : 31 4 1 19 25 16 12 13  
LAJITELTU : 1 4 12 16 19 25 31 + 13

HUOM!! seitsemän varsinaista numeroa on lajiteltu suuruusjärjestykseen! 
Mutta lisänumeroa ei tietenkään saa ottaa lajitteluun mukaan! Löytysköhän Array.Sort:sta 
sellainen ominaisuus, jolla tämän saisi ratkaistua?
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int[] lottoRivi = new int[8];

            Random random = new Random();

            for (int i = 0; i < 7; i++)
            {
                int arvottuNumero = random.Next(1, 41);

               
                while (lottoRivi.Contains(arvottuNumero))
                {
                    arvottuNumero = random.Next(1, 41);
                }

                lottoRivi[i] = arvottuNumero;
            }

            lottoRivi[7] = random.Next(1, 41);

            int[] lajiteltuRivi = lottoRivi.Take(7).OrderBy(x => x).ToArray();

            Console.WriteLine("ARVOTTU   : " + string.Join(" ", lottoRivi));
            Console.WriteLine("LAJITELTU : " + string.Join(" ", lajiteltuRivi) + " + " + lottoRivi[7]);
            Console.ReadLine();

        }
    }
}

