using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Luo 7 alkioinen float-taulukko ja lue siihen käyttäjältä arvoja. Kun käyttäjä syöttää arvoa 
taulukkoon, niin ohjelma ei saa kaatua vaan väärä arvo on kysyttävä uudestaan. 
Lajittele taulukko ja tulosta taulukon minimi- ja maksimiarvot yhden desimaalin
tarkkuudella seuraavasti:

MIN : 12.3
MAX : 34.9


Käytä funktioita:

LuoTaulukko         : funktio palauttaa luodun taulukon
KysyArvotTaulukkoon : funktio saa parametrina taulukon
LajitteleTaulukko   : funktio saa parametrina taulukon
TulostaTiedot       : funktio saa parametrina taulukon

HUOM 1!
Kaikkien funktioiden otsikkorivien eteen on laitettava public. Esimerkiksi
public static void MyMain()

HUOM 2!
Kun ohjelma on valmis, nimeä Main funktio MyMain-funktioksi ennen testaamista ja palautusta
*/
namespace Projekti
{
    class MyProgram
    {
        public static void MyMain()
        {
            float[] taulukko = LuoTaulukko(); // Luodaan taulukko ja tallennetaan se muuttujaan

            KysyArvotTaulukkoon(taulukko); // Pyydetään käyttäjältä arvoja ja tallennetaan ne taulukkoon

            LajitteleTaulukko(taulukko); // Lajitellaan taulukko

            TulostaTiedot(taulukko); // Tulostetaan taulukon minimi- ja maksimiarvot
        }

        public static float[] LuoTaulukko()
        {
            float[] taulukko = new float[7]; // Luodaan uusi 7 alkion float-taulukko
            return taulukko; // Palautetaan taulukko
        }

        public static void KysyArvotTaulukkoon(float[] taulukko)
        {
            for (int i = 0; i < taulukko.Length; i++)
            {
                bool validiSyote = false;
                while (!validiSyote)
                {
                    Console.Write("Syötä arvo taulukon indeksiin " + i + ": ");
                    string syote = Console.ReadLine();
                    validiSyote = float.TryParse(syote, out taulukko[i]);
                    if (!validiSyote)
                    {
                        Console.WriteLine("Virheellinen syöte. Syötä uusi arvo.");
                    }
                }
            }
        }

        public static void LajitteleTaulukko(float[] taulukko)
        {
            Array.Sort(taulukko); // Lajitellaan taulukko nousevaan järjestykseen
        }

        public static void TulostaTiedot(float[] taulukko)
        {
            float minimi = taulukko[0];
            float maksimi = taulukko[taulukko.Length - 1];

            Console.WriteLine("MIN : " + minimi.ToString("F1"));
            Console.WriteLine("MAX : " + maksimi.ToString("F1"));
        }
    }
}