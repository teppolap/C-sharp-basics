using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Lue käyttäjältä pitkähkö teksti string muuttujaan. Muuta kaikki kirjaimet isoiksi kirjaimiksi 
ja tulosta muutettu teksti. Korvaa kaikki isot A kirjaimet huutomerkillä ja tulosta teksti. 
Poista kaikki välilyönnit ja tulosta teksti. Tulosta lopuksi kaikki merkit lopusta alkuun 
yhdellä välilyönnillä eroteltuna 
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä pitkähkö teksti:");
            string teksti = Console.ReadLine();

            string isotKirjaimet = teksti.ToUpper();
            Console.WriteLine(isotKirjaimet);

            string korjattuTeksti = isotKirjaimet.Replace("A", "!");
            Console.WriteLine(korjattuTeksti);

            string ilmanValilyonneja = korjattuTeksti.Replace(" ", "");
            Console.WriteLine(ilmanValilyonneja);

            char[] merkit = ilmanValilyonneja.ToCharArray();
            Array.Reverse(merkit);
            string kaannettyTeksti = string.Join(" ", merkit);
            Console.WriteLine(kaannettyTeksti);
            Console.ReadLine();
        }
    }
}
