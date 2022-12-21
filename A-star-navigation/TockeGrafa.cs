using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_star_navigation
{
    public class TockeGrafa
    {
        public double lon;
        public double lat;
        public List<TockeGrafa> ListaSusjeda;
        public TockeGrafa(double lon, double lat)
        {
            this.lon = lon;
            this.lat = lat;
            ListaSusjeda = new List<TockeGrafa>();
        }
        
    }
}
