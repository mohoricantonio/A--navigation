using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_star_navigation
{
    public static class AStarCalculator
    {
        public static double VratiUdaljenost(TockaGrafa tocka1, TockaGrafa tocka2)
        {
            var prvaTocka = new GeoCoordinate(tocka1.lat, tocka1.lon);
            var drugaTocka = new GeoCoordinate(tocka2.lat, tocka2.lon);

            return prvaTocka.GetDistanceTo(drugaTocka);
        }

        public static string VratiRutu(TockaGrafa pocetnaTocka, TockaGrafa zavrsnaTocka)
        {
            string returnMe = pocetnaTocka.naziv + "->";
            TockaGrafa sljedecaTocka = pocetnaTocka;
            TockaGrafa prethodnaTocka = null;
            TockaGrafa pom = null;
            Dictionary<TockaGrafa, double> tezineTocaka = new Dictionary<TockaGrafa, double>();

            tezineTocaka[sljedecaTocka] = 1000000;
            pom = sljedecaTocka;

            while (sljedecaTocka != zavrsnaTocka)
            {
                foreach(TockaGrafa t in sljedecaTocka.ListaSusjeda)
                {
                    if(t==prethodnaTocka) continue;
                    tezineTocaka[t] = VratiUdaljenost(sljedecaTocka, t) + (VratiUdaljenost(t, zavrsnaTocka));

                    /*System.Windows.Forms.MessageBox.Show("Gledam točku " + t.naziv + ", a došao sam od "+
                        sljedecaTocka.naziv + " i njihove težine su: " + tezineTocaka[t] + " - " +
                        tezineTocaka[sljedecaTocka]);*/

                    if (tezineTocaka[t] < tezineTocaka[pom]) pom = t;

                    //System.Windows.Forms.MessageBox.Show("Pom je trenutno: " + pom.naziv);
                }
                prethodnaTocka = sljedecaTocka;
                sljedecaTocka = pom;
                returnMe += sljedecaTocka.naziv + "->";
            }
            return returnMe.Substring(0, returnMe.Length-2);
        }
    }
}
