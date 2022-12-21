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

namespace A_star_navigation
{
    public partial class AStarNavigationForm : Form
    {
        private List<PointLatLng> points;
        public AStarNavigationForm()
        {
            InitializeComponent();
        }

        private void AStarNavigationForm_Load(object sender, EventArgs e)
        {
            SetUpMap();
        }
        private void SetUpMap()
        {
            map.MapProvider = GMapProviders.UMPMap;

            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;
            map.Position = new GMap.NET.PointLatLng(46.307211, 16.338444);
            FillListOfPoints();

            GMarkerGoogle marker;
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            foreach (PointLatLng p in points)
            {
                
                marker = new GMarkerGoogle(p, GMarkerGoogleType.red_small);
                markersOverlay.Markers.Add(marker);
            }
            map.Overlays.Add(markersOverlay);
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
    }
}
