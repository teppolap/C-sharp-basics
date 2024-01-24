using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Lue käyttäjältä merkkejä, kunnes käyttäjä painaa enteriä. Isot kirjaimet tulostuvat pienenä 
ja pienet kirjaimet tulostuvat isona. Muut merkit eivät tulostu.

Riittää, että toimii kirjaimilla väliltä a-z ja A-Z.
*/

namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Syötä merkkejä. Paina Enter lopettaaksesi.");
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                char character = keyInfo.KeyChar;

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    break;
                }

                if (char.IsUpper(character))
                {
                    character = char.ToLower(character);
                    Console.Write(character);
                }
                else if (char.IsLower(character))
                {
                    character = char.ToUpper(character);
                    Console.Write(character);
                }
            }
        }
    }
}