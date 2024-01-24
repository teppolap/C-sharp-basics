using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
Arvo 40 kpl liukulukuja väliltä 1.4 – 5.8 ja kirjoita ne "datat.txt" tiedostoon allekkain. 
Älä käytä taulukkoa tässä vaiheessa.

Sen jälkeen luo 40 alkioinen double-taulukko ja lue 
arvot tiedostosta taulukkoon. Tämän jälkeen tulosta taulukon lukujen 
summa, keskiarvo, minimiarvo ja maksimiarvo seuraavalla tavalla

SUMMA : 143.2
KA    : 3.6
MIN   : 1.4
MAX   : 5.7

Käytä funktioita:

ArvoJaTallennaTiedostoon
LueTiedostosta
TulostaTiedot


HUOM 1!
Kaikkien funktioiden otsikkorivien eteen on laitettava public. Esimerkiksi
public static void Main()

HUOM 2!
Kun ohjelma on valmis, nimeä Main funktio MyMain-funktioksi ennen testaamista ja palautusta

HUOM 3!
Path-funktio pitää jättää ohjelmaan ja kun kirjoitat tiedostoon tai luet sieltä, niin
StreamWriter ja StreamReader muuttujien esittelyt pitää olla näin:

StreamWriter sw = new StreamWriter(Path("datat.txt"));
StreamReader sr = new StreamReader(Path("datat.txt"));
*/
namespace Projekti
{
    class MyProgram
    {
        static string Path(string filename)
        {
            return System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "../../../src/", filename);
        }

        public static void MyMain()
        {
            ArvoJaTallennaTiedostoon();

            // Lue tiedostosta liukuluvut ja tallenna ne taulukkoon
            double[] taulukko = LueTiedostosta();

            // Tulosta taulukon tiedot (summa, keskiarvo, minimi, maksimi)
            TulostaTiedot(taulukko);
        }

        // Generoi satunnaiset liukuluvut väliltä 1.4 - 5.8 ja tallenna ne tiedostoon
        public static void ArvoJaTallennaTiedostoon()
        {
            StreamWriter sw = new StreamWriter(Path("datat.txt"));
            Random random = new Random();

            for (int i = 0; i < 40; i++)
            {
                double luku = 1.4 + (random.NextDouble() * (5.8 - 1.4));
                sw.WriteLine(luku);
            }

            sw.Close();
        }

        // Lue tiedostosta liukuluvut ja tallenna ne taulukkoon
        public static double[] LueTiedostosta()
        {
            StreamReader sr = new StreamReader(Path("datat.txt"));
            double[] taulukko = new double[40];

            for (int i = 0; i < 40; i++)
            {
                string rivi = sr.ReadLine();
                taulukko[i] = double.Parse(rivi);
            }

            sr.Close();
            return taulukko;
        }

        // Tulosta taulukon tiedot (summa, keskiarvo, minimi, maksimi)
        public static void TulostaTiedot(double[] taulukko)
        {
            double summa = 0;
            double minimi = taulukko[0];
            double maksimi = taulukko[0];

            // Laske summa, minimi ja maksimi taulukon arvoista
            for (int i = 0; i < 40; i++)
            {
                summa += taulukko[i];

                if (taulukko[i] < minimi)
                {
                    minimi = taulukko[i];
                }

                if (taulukko[i] > maksimi)
                {
                    maksimi = taulukko[i];
                }
            }

            double keskiarvo = summa / 40;

            // Tulosta taulukon tiedot konsoliin
            Console.WriteLine("SUMMA : " + summa.ToString("F1"));
            Console.WriteLine("KA    : " + keskiarvo.ToString("F1"));
            Console.WriteLine("MIN   : " + minimi.ToString("F1"));
            Console.WriteLine("MAX   : " + maksimi.ToString("F1"));
        }
    }
}