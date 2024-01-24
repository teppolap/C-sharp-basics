using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä koenumero 4-10 väliltä. Jos käyttäjä syötti arvosanan väärin,
niin tulosta "et antanut arvosanaa annetulta väliltä". Muussa tapauksessa tulosta:

"hyvä", jos arvosana oli 9 tai 10
"kelpo", jos 7-8
"tyydyttävä", jos 5-6
"heikko", jos 4

Toteuta ohjelma if-rakenteella
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä koenumero (4-10):");
            int arvosana = int.Parse(Console.ReadLine());

            if (arvosana >= 4 && arvosana <= 10)
            {
                if (arvosana >= 9)
                {
                    Console.WriteLine("hyvä");
                }
                else if (arvosana >= 7 && arvosana <= 8)
                {
                    Console.WriteLine("kelpo");
                }
                else if (arvosana >= 5 && arvosana <= 6)
                {
                    Console.WriteLine("tyydyttävä");
                }
                else
                {
                    Console.WriteLine("heikko");
                }
            }
            else
            {
                Console.WriteLine("et antanut arvosanaa annetulta väliltä");
            }

            Console.ReadLine();
        }
    }
}
