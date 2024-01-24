using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
Jos Main-funktioon ei tullut yhtään parameteriä (0 kpl), niin silloin 
"parametrit.txt tiedostoon kirjoitetaan teksti "Ohjelma ei saanut parametreja".

Jos Main-funktioon tuli parametreja niin kirjoita pelkästään
tulleet parametrit ”parametrit.txt” tiedostoon allekkain.

Lopuksi lue tiedostosta sinne kirjoitetut tiedot rivi kerrallaan ja tulosta näytölle.

Käytä funktioita:

Tallenna
LueJaTulosta


HUOM 1!
Kaikkien funktioiden otsikkorivien eteen on laitettava public. Esimerkiksi
public static void Main()

HUOM 2!
Path-funktio pitää jättää ohjelmaan ja kun kirjoitat tiedostoon tai luet sieltä, niin
StreamWriter ja StreamReader muuttujien esittelyt pitää olla näin:

StreamWriter sw = new StreamWriter(Path("parametrit.txt"));
StreamReader sr = new StreamReader(Path("parametrit.txt"));
*/
namespace Projekti
{
    class MyProgram
    {
        static string Path(string filename)
        {
            return System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "../../../src/", filename);
        }

        static void Tallenna(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(Path("parametrit.txt")))
            {
                if (args.Length == 0)
                {
                    sw.WriteLine("Ohjelma ei saanut parametreja");
                }
                else
                {
                    foreach (string param in args)
                    {
                        sw.WriteLine(param);
                    }
                }
            }
        }

        static void LueJaTulosta()
        {
            using (StreamReader sr = new StreamReader(Path("parametrit.txt")))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public static void Main(string[] args)
        {
            Tallenna(args);
            LueJaTulosta();
        }
    }
}