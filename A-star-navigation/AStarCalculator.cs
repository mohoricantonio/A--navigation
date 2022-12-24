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
            Dictionary<TockaGrafa, double> tezinaTocke = new Dictionary<TockaGrafa, double>();
            Dictionary<TockaGrafa, double> prethodnaUdaljenost = new Dictionary<TockaGrafa, double>();

            List<TockaGrafa> otvorena = new List<TockaGrafa>();
            List<TockaGrafa> zatvorena = new List<TockaGrafa>();

            TockaGrafa trenutna = pocetnaTocka;
            TockaGrafa prethodna = pocetnaTocka;

            /*while (trenutna != zavrsnaTocka)
            {
                --TO DO-- 
            }*/
            // dodaj zadnju točku u listu zatvorena!

            //return VratiKrajnjuRutu(zatvorena);
            return "TODO";
        }
        private static TockaGrafa VratiTockuNajmanjeTezine(List<TockaGrafa> lista, Dictionary<TockaGrafa, double> tezinaTocke)
        {
            TockaGrafa returnMe = null;
            // --TO DO--
            return returnMe;
        }
        private static string VratiKrajnjuRutu(List<TockaGrafa> lista)
        {
            string returnMe = "";
            TockaGrafa trenutna = lista.Last();
            List<TockaGrafa> zavrsnaLista = new List<TockaGrafa>();

            zavrsnaLista.Add(lista.Last());
            while (trenutna != lista.First())
            {
                foreach(TockaGrafa t in lista)
                {
                    if (trenutna.ListaSusjeda.Contains(t)) {
                        zavrsnaLista.Add(t);
                        trenutna = t;
                        break;
                    }
                }
            }
            for (int i = zavrsnaLista.Count-1; i>= 0; i--)
            {
                returnMe += zavrsnaLista[i].naziv + "->";
            }
            return returnMe.Substring(0, returnMe.Length -2);
        }
    }
}
