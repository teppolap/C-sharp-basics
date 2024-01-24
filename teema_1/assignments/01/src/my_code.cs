using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele ja anna alkuarvot muuttujille, joihin pitäisi tallentaa seuraavat tiedot:

piin likiarvo
lähiosoite
henkilötunnus
nimesi ensimmäinen kirjain
lämpötila yhden desimaalin tarkkuudella

Tulosta arvot muuttujista allekkain käyttäen sekä Console.WriteLine(), että Console.Write()-komentoja.
Ohjelman pitää tulostaa seuraavat tiedot:

3.14159
Munkkikuja 3
121299A1234
S
-12.4
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double pi = 3.14159;
            string address = "Munkkikuja 3";
            string hTunnus = "121299A1234";
            char firstInitial = 'S';
            double temperature = -12.4;

            Console.WriteLine(pi);
            Console.WriteLine(address);
            Console.WriteLine(hTunnus);
            Console.WriteLine(firstInitial);
            Console.WriteLine(temperature);

            Console.Write(pi + "\n");
            Console.Write(address + "\n");
            Console.Write(hTunnus + "\n");
            Console.Write(firstInitial + "\n");
            Console.Write(temperature + "\n");
        }
    }
}
