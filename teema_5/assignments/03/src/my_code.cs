using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
/*
Tee ohjelma, joka laskee mäkihyppääjän yhden kierroksen suorituspisteet. Ohjelma kysyy hypyn pituuden 
(liukuluku 0.5 metrin välein ja pituuden oltava > 0) sekä viiden arvostelutuomarin tyylipisteet (0-20 välillä 0.5 välein eli 
esim. 16.5 tai 17.0 tai 18.5). Vinkki. Jakojäännöksellä saa tutkittua onko puolen pisteen/metrin välein

Hyppääjän pisteet muodostuvat kaavasta.

pisteet = (hypyn pituus - kriittinen piste) * 1.8 + kolmen keskimmäisen tuomarin tyylipisteet + 60. 

Tyylipisteissä siis parhain ja huonoin pistemäärä tipahtaa pois.

Ohjelman hyppyrimäen kriittinen piste on 90 metrin kohdalla. Laita kriittinen piste vakioon KR_PISTE. 
Tulosta lopuksi hypyn pituus ja hypyn pisteet yhden desimaalin tarkkuudella seuraavalla tavalla.

PITUUS  : 115,5 m
PISTEET : 161,4

Käytä ohjelmassa funktioita (funktiot eivät saa palauttaa mitään ja kun käytät viittauksia, niin pitää
käyttää out-viittausta):

KysyHypynPituus
KysyTuomareidenPisteet
LaskeHypynPisteet
Tulosta

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
            float pituus;
            KysyHypynPituus(out pituus); // Kysytään käyttäjältä hypyn pituus ja tallennetaan se muuttujaan 'pituus'

            float[] pisteet;
            KysyTuomareidenPisteet(out pisteet); // Kysytään käyttäjältä tuomareiden pisteet ja tallennetaan ne taulukkoon 'pisteet'

            float kokonaispisteet = LaskeHypynPisteet(pituus, pisteet); // Lasketaan hypyn pisteet ja tallennetaan ne muuttujaan 'kokonaispisteet'

            Tulosta(pituus, kokonaispisteet); // Tulostetaan hypyn pituus ja pisteet
        }

        public static void KysyHypynPituus(out float pituus)
        {
            while (true)
            {
                Console.Write("Syötä hypyn pituus (0.5 metrin välein, pituus > 0): ");
                float syote = float.Parse(Console.ReadLine());
                if (syote % 0.5 == 0 && syote > 0)
                {
                    pituus = syote;
                    return;
                }
                Console.WriteLine("Virheellinen syöte! Syötä pituus 0.5 metrin välein ja pituuden tulee olla suurempi kuin 0.");
            }
        }

        public static void KysyTuomareidenPisteet(out float[] pisteet)
        {
            pisteet = new float[5];
            for (int i = 0; i < pisteet.Length; i++)
            {
                Console.Write("Syötä tuomarin " + (i + 1) + " pisteet (0-20, 0.5 välein): ");
                pisteet[i] = float.Parse(Console.ReadLine());

                if (pisteet[i] % 0.5 != 0 || pisteet[i] < 0 || pisteet[i] > 20)
                {
                    Console.WriteLine("Virheellinen syöte! Syötä pisteet 0.5 välein.");
                    i--;
                    continue;
                }
            }
        }

        public static float LaskeHypynPisteet(float pituus, float[] pisteet)
        {
            const float KR_PISTE = 90.0f; // Hyppyrimäen kriittinen piste

            // Lajitellaan tuomarien pisteet suuruusjärjestykseen
            Array.Sort(pisteet);

            // Lasketaan kolmen keskimmäisen tuomarin pisteiden summa
            float keskimmainenPisteet = pisteet[1] + pisteet[2] + pisteet[3];

            // Lasketaan hypyn pisteet kaavan avulla
            float kokonaispisteet = (pituus - KR_PISTE) * 1.8f + keskimmainenPisteet + 60.0f;

            return kokonaispisteet;
        }

        public static void Tulosta(float pituus, float pisteet)
        {
            Console.WriteLine("PITUUS  : " + pituus.ToString("F1") + " m");
            Console.WriteLine("PISTEET : " + pisteet.ToString("F1"));
        }
    }
}