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

            prethodnaUdaljenost[pocetnaTocka] = 0;
            TockaGrafa trenutna = pocetnaTocka;
            TockaGrafa prethodna = pocetnaTocka;
            tezinaTocke[trenutna] = VratiUdaljenost(trenutna, zavrsnaTocka) + prethodnaUdaljenost[trenutna];

            while (trenutna != zavrsnaTocka)
            {
                zatvorena.Add(trenutna);

                foreach (TockaGrafa t in trenutna.ListaSusjeda)
                {
                    if (prethodna == t) continue;
                    if (tezinaTocke.ContainsKey(t) == true)
                    {
                        if (tezinaTocke[t] > (prethodnaUdaljenost[trenutna] + VratiUdaljenost(t, trenutna)+ 
                            VratiUdaljenost(t, zavrsnaTocka)))
                        {
                            prethodnaUdaljenost[t] = prethodnaUdaljenost[trenutna] + VratiUdaljenost(t, trenutna);
                            tezinaTocke[t] = prethodnaUdaljenost[t] + VratiUdaljenost(t, zavrsnaTocka);
                            otvorena.Add(t);
                        }
                    }
                    else
                    {
                        prethodnaUdaljenost[t] = prethodnaUdaljenost[trenutna] + VratiUdaljenost(t, trenutna);
                        tezinaTocke[t] = prethodnaUdaljenost[t] + VratiUdaljenost(t, zavrsnaTocka);
                        otvorena.Add(t);
                    }
                    
                }
                prethodna = trenutna;
                trenutna = VratiTockuNajmanjeTezine(otvorena, tezinaTocke);
                otvorena.Remove(trenutna);
            }
            zatvorena.Add(trenutna);

            return VratiKrajnjuRutu(zatvorena);
        }
        private static TockaGrafa VratiTockuNajmanjeTezine(List<TockaGrafa> lista, Dictionary<TockaGrafa, double> tezinaTocke)
        {
            TockaGrafa returnMe = null;
            for(int i = lista.Count-1; i>0; i--)
            {
                if(returnMe == null)
                {
                    returnMe = lista[i];
                }
                for(int j = 0; j<i; j++)
                {
                    if (tezinaTocke[lista[j]] < tezinaTocke[returnMe]) returnMe = lista[j];
                }
            }
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
