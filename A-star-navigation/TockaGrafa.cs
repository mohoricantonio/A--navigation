using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_star_navigation
{
    public class TockaGrafa
    {
        public string naziv;
        public double lon;
        public double lat;
        public List<TockaGrafa> ListaSusjeda;
        public TockaGrafa(string naziv, double lat, double lon)
        {
            this.naziv = naziv;
            this.lon = lon;
            this.lat = lat;
            ListaSusjeda = new List<TockaGrafa>();
        }
        
    }
}
