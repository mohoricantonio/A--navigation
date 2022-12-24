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
        int i = 0;
        TockaGrafa A;
        TockaGrafa B;
        TockaGrafa C;
        TockaGrafa D;
        TockaGrafa E;
        TockaGrafa F;
        TockaGrafa G;
        TockaGrafa H;
        TockaGrafa I;
        TockaGrafa J;
        public AStarNavigationForm()
        {
            InitializeComponent();
        }

        private void AStarNavigationForm_Load(object sender, EventArgs e)
        {
            A = new TockaGrafa("A", 46.33377, 16.26975);
            B = new TockaGrafa("B", 46.31006, 16.28829);
            C = new TockaGrafa("C", 46.28634, 16.25327);
            D = new TockaGrafa("D", 46.31433, 16.32674);
            E = new TockaGrafa("E", 46.29393, 16.30546);
            F = new TockaGrafa("F", 46.30793, 16.3573);
            G = new TockaGrafa("G", 46.29109, 16.35215);
            H = new TockaGrafa("H", 46.28278, 16.32949);
            I = new TockaGrafa("I", 46.26166, 16.31232);
            J = new TockaGrafa("J", 46.26522, 16.36279);

            map.MapProvider = GMapProviders.GoogleMap;

            map.MinZoom = 5;
            map.MaxZoom = 20;
            map.Zoom = 13;
            map.Position = new PointLatLng(46.29986, 16.32683);
            map.ShowCenter = false;
        }

        private void SetUpMap()
        {
            map.Position = new PointLatLng(46.29986, 16.32683);
            if (i==1)FillListOfPoints();
            else if (i == 2)
            {
                GMarkerGoogle marker;
                Bitmap bmpMarker;
                int x = 0;
                string slika = "abcdefghij";

                foreach (PointLatLng p in points)
                {
                    bmpMarker = (Bitmap)Image.FromFile("../../markers/" + slika[x] + ".png");
                    GMapOverlay markersOverlay = new GMapOverlay("markers");
                    marker = new GMarkerGoogle(p, bmpMarker);
                    markersOverlay.Markers.Add(marker);
                    map.Overlays.Add(markersOverlay);
                    x++;
                }
                
            }
        }

        private void DrawRoutes()
        {
            List<PointLatLng> linija = new List<PointLatLng>();
            GMapOverlay routeOverlay = new GMapOverlay("routes");
            linija.Add(new PointLatLng(A.lat, A.lon));
            linija.Add(new PointLatLng(B.lat, B.lon));
            
            GMapRoute r = new GMapRoute(linija, "Linija");
            r.Stroke.Width = 3;
            r.Stroke.Color = Color.OrangeRed;
            routeOverlay.Routes.Add(r);
            
            linija.RemoveAt(1);
            linija.Add(new PointLatLng(C.lat, C.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.Add(new PointLatLng(D.lat, D.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.RemoveAt(0);
            linija.Add(new PointLatLng(B.lat, B.lon));
            linija.Add(new PointLatLng(C.lat, C.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.Add(new PointLatLng(D.lat, D.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.Add(new PointLatLng(E.lat, E.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.RemoveAt(0);
            linija.Add(new PointLatLng(C.lat, C.lon));
            linija.Add(new PointLatLng(G.lat, G.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.Add(new PointLatLng(I.lat, I.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.RemoveAt(0);
            linija.Add(new PointLatLng(D.lat, D.lon));
            linija.Add(new PointLatLng(F.lat, F.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.Add(new PointLatLng(G.lat, G.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.Add(new PointLatLng(H.lat, H.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.RemoveAt(0);
            linija.Add(new PointLatLng(E.lat, E.lon));
            linija.Add(new PointLatLng(H.lat, H.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.Add(new PointLatLng(I.lat, I.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.RemoveAt(0);
            linija.Add(new PointLatLng(F.lat, F.lon));
            linija.Add(new PointLatLng(G.lat, G.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.RemoveAt(0);
            linija.Add(new PointLatLng(G.lat, G.lon));
            linija.Add(new PointLatLng(J.lat, J.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.RemoveAt(0);
            linija.Add(new PointLatLng(H.lat, H.lon));
            linija.Add(new PointLatLng(J.lat, J.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            linija.RemoveAt(1);
            linija.RemoveAt(0);
            linija.Add(new PointLatLng(I.lat, I.lon));
            linija.Add(new PointLatLng(J.lat, J.lon));
            r = new GMapRoute(linija, "Linija");
            routeOverlay.Routes.Add(r);

            map.Overlays.Add(routeOverlay);
        }

        private void FillListOfPoints()
        {
            points = new List<PointLatLng>();
            points.Add(new PointLatLng(A.lat, A.lon));
            points.Add(new PointLatLng(B.lat, B.lon));
            points.Add(new PointLatLng(C.lat, C.lon));
            points.Add(new PointLatLng(D.lat, D.lon));
            points.Add(new PointLatLng(E.lat, E.lon));
            points.Add(new PointLatLng(F.lat, F.lon));
            points.Add(new PointLatLng(G.lat, G.lon));
            points.Add(new PointLatLng(H.lat, H.lon));
            points.Add(new PointLatLng(I.lat, I.lon));
            points.Add(new PointLatLng(J.lat, J.lon));
            DodajSusjede();
        }

        private void DodajSusjede()
        {
            A.ListaSusjeda.Add(B);
            A.ListaSusjeda.Add(C);
            A.ListaSusjeda.Add(D);

            B.ListaSusjeda.Add(A);
            B.ListaSusjeda.Add(D);
            B.ListaSusjeda.Add(C);
            B.ListaSusjeda.Add(E);

            C.ListaSusjeda.Add(A);
            C.ListaSusjeda.Add(B);
            C.ListaSusjeda.Add(G);
            C.ListaSusjeda.Add(I);

            D.ListaSusjeda.Add(A);
            D.ListaSusjeda.Add(B);
            D.ListaSusjeda.Add(F);
            D.ListaSusjeda.Add(G);
            D.ListaSusjeda.Add(H);

            E.ListaSusjeda.Add(B);
            E.ListaSusjeda.Add(I);
            E.ListaSusjeda.Add(H);

            F.ListaSusjeda.Add(D);
            F.ListaSusjeda.Add(G);

            G.ListaSusjeda.Add(D);
            G.ListaSusjeda.Add(F);
            G.ListaSusjeda.Add(C);
            G.ListaSusjeda.Add(J);

            H.ListaSusjeda.Add(E);
            H.ListaSusjeda.Add(D);
            H.ListaSusjeda.Add(J);

            I.ListaSusjeda.Add(C);
            I.ListaSusjeda.Add(E);
            I.ListaSusjeda.Add(J);

            J.ListaSusjeda.Add(I);
            J.ListaSusjeda.Add(H);
            J.ListaSusjeda.Add(G);
        }

        private void btnOdrediRutu_Click(object sender, EventArgs e)
        {
            if(cmbPocetnaTocka.SelectedItem == null || cmbZavrsnaTocka.SelectedItem == null)
                MessageBox.Show("Niste odabrali obje točke!");
            else if (cmbPocetnaTocka.SelectedItem == cmbZavrsnaTocka.SelectedItem)
                MessageBox.Show("Početna i završna točka ne mogu biti iste!");
            else
            {
                TockaGrafa pocetnaTocka = VratiTocku(cmbPocetnaTocka);
                TockaGrafa zavrsnaTocka = VratiTocku(cmbZavrsnaTocka);
                txtNajkracaRuta.Text = AStarCalculator.VratiRutu(pocetnaTocka, zavrsnaTocka);
            }
        }

        private void btnDohvatiTocke_Click(object sender, EventArgs e)
        {
            i++;
            if (i == 3)
            {
                btnDohvatiTocke.Enabled = false;
                btnOdrediRutu.Enabled = true;
                cmbPocetnaTocka.Enabled = true;
                cmbZavrsnaTocka.Enabled = true;
                DrawRoutes();
            }
            SetUpMap();
        }
        private TockaGrafa VratiTocku(ComboBox cmb)
        {
            switch (cmb.SelectedItem)
            {
                case "A":
                    return A;
                    break;
                case "B":
                    return B;
                    break;
                case "C":
                    return C;
                    break;
                case "D":
                    return D;
                    break;
                case "E":
                    return E;
                    break;
                case "F":
                    return F;
                    break;
                case "G":
                    return G;
                    break;
                case "H":
                    return H;
                    break;
                case "I":
                    return I;
                    break;
                case "J":
                    return J;
                    break;
                default:
                    return null;
            }
        }
    }
}
