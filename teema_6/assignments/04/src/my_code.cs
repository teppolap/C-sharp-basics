using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
Tee ohjelma, joka kysyy käyttäjältä henkilötunnuksen ja
tarkistaa annetun henkilötunnuksen oikeellisuuden (eli onko
hetun tarkistusmerkki oikein). Jos hetu oli oikein, niin tulosta

"hetu oli annettu oikein"

ja jos hetu oli väärin, niin tulosta

"hetu oli annettu väärin, oikea tarkiste olisi pitänyt olla X"

(missä siis X:n kohdalle tulostetaan se merkki,
mikä tarkisteen olisi pitänyt olla)

Henkilötunnushan on ppkkvv-nnnT, missä

pp  = syntymäpäivä
kk  = syntymäkuukausi
vv  = syntymävuosi
nnn = kyseisenä päivänä syntyneiden järjestysnumero
T   = tarkistusmerkki

Tarkistusmerkki T saadaan kun hetu muokataan seuraavaan muotoon

ppkkvvnnn

ja jaetaan 31:llä ja tutkitaan jakojäännöstä.
Jakojäännöksen perusteella alla olevasta voidaan tutkia tarkistusmerkki. Esimerkiksi
jos jakojäännös (jj) oli 11, niin tarkistusmerkin (T) pitäisi hetussa olla B

jj 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30
T  0 1 2 3 4 5 6 7 8 9  A  B  C  D  E  F  H  J  K  L  M N  P  R  S   T  U  V  W  X Y

*/
namespace Projekti
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            //Your code here
        }
    }
}