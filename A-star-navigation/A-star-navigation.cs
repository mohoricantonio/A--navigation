using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace A_star_navigation
{
    public partial class AStarNavigationForm : Form
    {
        private List<PointLatLng> points;
        PointLatLng A = new PointLatLng();
        int i = 0;
        public AStarNavigationForm()
        {
            InitializeComponent();
        }

        private void AStarNavigationForm_Load(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.UMPMap;

            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 11;
            map.Position = new PointLatLng(46.307211, 16.338444);
            map.ShowCenter = false;
        }
        private void SetUpMap()
        {
            map.Position = new PointLatLng(46.307211, 16.338444);
            if (i==1)FillListOfPoints();
            else if (i == 2)
            {
                GMarkerGoogle marker;
            
                foreach (PointLatLng p in points)
                {
                    GMapOverlay markersOverlay = new GMapOverlay("markers");
                    marker = new GMarkerGoogle(p, GMarkerGoogleType.red_small);
                    markersOverlay.Markers.Add(marker);
                    map.Overlays.Add(markersOverlay);
                }
            }
           
        }

        private void FillListOfPoints()
        {
            points = new List<PointLatLng>();
            points.Add(new PointLatLng(46.211002, 16.040397));
            points.Add(new PointLatLng(46.242552, 16.174212));
            points.Add(new PointLatLng(46.292745, 16.305626));
            points.Add(new PointLatLng(46.308085, 16.287624));
            points.Add(new PointLatLng(46.328182, 16.283279));
            points.Add(new PointLatLng(46.267640, 16.331050));
            points.Add(new PointLatLng(46.265334, 16.363070));
            points.Add(new PointLatLng(46.307746, 16.358401));
            points.Add(new PointLatLng(46.255633, 16.263528));
            points.Add(new PointLatLng(46.262932, 16.317419));
        }

        private void btnOdrediRutu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDohvatiTocke_Click(object sender, EventArgs e)
        {
            i++;
            if (i == 3)
            {
                btnDohvatiTocke.Enabled = false;
                btnOdrediRutu.Enabled = true;
                txtPocetnaTocka.Enabled = true;
                txtZavrsnaTocka.Enabled = true;
            }
            SetUpMap();
        }
    }
}
