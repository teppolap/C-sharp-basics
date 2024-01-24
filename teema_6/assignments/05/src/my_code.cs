using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Tee ohjelma, jolla voit laskea kuinka paljon saat työmarkkinatukea kuukaudessa 
jäädessäsi työttömäksi, kun et ole ollut niin pitkään töissä että saisit 
ansiosidonnaista työttömyyspäivärahaa. Työmarkkinatuen ehdot ja määrät ovat 
yksinkertaistettu malli oikeista työmarkkinatuen ehdoista ja ovat seuraavat: 
 
· Työmarkkinatuen määrä on 32,68 euroa/päivä ja sitä maksetaan viideltä päivältä viikossa.
· Lapset korottavat työmarkkinatukea seuraavasti: yksi lapsi 5,27 euroa/pv, kaksi lasta 7,74 euroa/ pv ja kolmesta tai useammasta yhteensä 9,98 e/pv
· Työllistymistä edistävä palvelu korottaa tukea 4,78 e/pv
· Jos tulot ylittävät 300 euroa, niin jokainen sen määrän ylittävä palkkana maksettu euro vähentää tukea 50 senttiä
· Jos asut vanhempiesi taloudessa tukea vähennetään 50% 

Ohjelmalla voi toistaa työmarkkinatuen laskemista niin monta kertaa kuin haluaa. 
Tuki lasketaan kuukaudelle, jossa on 4 viikkoa.

Alla on esimerkki ohjelman toiminnasta:  

Kuinka monta lasta sinulla on: 5
Kuinka monena päivänä olet osallistunut työllistymistä edistävään palveluun: 2
Kuinka paljon olet saanut palkkaa: 320
Asutko vanhempiesi luona (k/e): k
Saat työmarkkinatukea 426.38 euroa kuukaudessa
 
Haluatko laske työmarkkinatuen uusilla tiedoilla (k/e): e

HUOM! Kun käyttäjältä kysytään k/e, niin toteuta sen kysyminen siten, että käyttäjän
pitää painaa enteriä vastauksen jälkeen.
*/
namespace Projekti
{
    class MyProgram
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Kuinka monta lasta sinulla on:");
                int children = int.Parse(Console.ReadLine());

                Console.WriteLine("Kuinka monena päivänä olet osallistunut työllistymistä edistävään palveluun:");
                int serviceDays = int.Parse(Console.ReadLine());

                Console.WriteLine("Kuinka paljon olet saanut palkkaa:");
                double income = double.Parse(Console.ReadLine());

                Console.WriteLine("Asutko vanhempiesi luona (k/e):");
                string livingWithParents = Console.ReadLine();

                double dailySupport = 32.68;
                double childSupport = 0.0;

                if (children == 1)
                    childSupport = 5.27;
                else if (children == 2)
                    childSupport = 7.74;
                else if (children >= 3)
                    childSupport = 9.98;

                double serviceSupport = serviceDays * 4.78;
                double monthlySupport = (dailySupport * 5 * 4) + childSupport + serviceSupport;

                if (income > 300)
                    monthlySupport -= (income - 300) * 0.5;

                if (livingWithParents == "k")
                    monthlySupport *= 0.5;

                Console.WriteLine($"Saat työmarkkinatukea {monthlySupport:F2} euroa kuukaudessa");

                Console.WriteLine("Haluatko laskea työmarkkinatuen uusilla tiedoilla (k/e):");
                string calculateAgain = Console.ReadLine();

                if (calculateAgain != "k")
                    break;
            }
        }
    }
}