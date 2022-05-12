using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfExampleTimur343.Pages
{
    /// <summary>
    /// Interaction logic for MapPage.xaml
    /// </summary>
    public partial class MapPage : Page
    {
        public MapPage()
        {
            InitializeComponent();
            try
            {
                System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("ditu.google.cn");
            }
            catch
            {
                mapControl.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show("No internet connection avaible, going to CacheOnly mode.", "GMap.NET Demo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            mapControl.MapProvider = GMapProviders.GoogleMap; //гугл карта
            mapControl.MinZoom = 2;  //Минимальный зум
            mapControl.MaxZoom = 17; //Максимальный зум
            mapControl.Zoom = 13;     //Текущий зум
            mapControl.ShowCenter = false; //Не показывать центральный крест
            mapControl.DragButton = MouseButton.Left; //Щелкните левой кнопкой мыши, чтобы перетащить карту
            mapControl.Position = new PointLatLng(54.091697, 52.540152); //Центральное расположение карты. 

            mapControl.MouseLeftButtonDown += new MouseButtonEventHandler(mapControl_MouseLeftButtonDown);



            List<PointLatLng> pointlatlang = new List<PointLatLng>();
            pointlatlang.Add(new PointLatLng(54.091697, 52.540152));
            pointlatlang.Add(new PointLatLng(54.092320, 52.540822));
            pointlatlang.Add(new PointLatLng(54.091977069290365, 52.54180637059018));
            pointlatlang.Add(new PointLatLng(54.09150042409676, 52.54092392385772));

            //54.525936, 52.822807
            //Declare polygon in gmap
            GMapPolygon polygon = new GMapPolygon(pointlatlang);


            

            Path path = new Path();
            path.Fill = new SolidColorBrush(Colors.Red) { Opacity = 0.5 };
            path.StrokeThickness = 1.5;
            path.Stroke = Brushes.DarkBlue;
            path.Effect = null;

            polygon.Shape = path;
            
            //To add polygon in gmap
            mapControl.Markers.Add(polygon);

            List<PointLatLng> pointlatlangB = new List<PointLatLng>();
            pointlatlangB.Add(new PointLatLng(54.525974, 52.822354));
            pointlatlangB.Add(new PointLatLng(54.525789, 52.822547));
            pointlatlangB.Add(new PointLatLng(54.525851, 52.823019));
            pointlatlangB.Add(new PointLatLng(54.526056, 52.822963));

            GMapPolygon polygonB = new GMapPolygon(pointlatlangB);

            Path pathB = new Path();
            pathB.Fill = new SolidColorBrush(Colors.Blue) { Opacity = 0.5 };
            pathB.StrokeThickness = 1.5;
            pathB.Stroke = Brushes.DarkBlue;
            pathB.Effect = null;

            polygonB.Shape = pathB;

            mapControl.Markers.Add(polygonB);
        }

        void mapControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
               Point clickPoint = e.GetPosition(mapControl);
               PointLatLng point = mapControl.FromLocalToLatLng((int)clickPoint.X, (int)clickPoint.Y);
               GMapMarker marker = new GMapMarker(point);
               mapControl.Markers.Add(marker);
            if(Mouse.RightButton == MouseButtonState.Pressed)
                marker.Shape = new Ellipse
                {
                    Width = 10,
                    Height = 10,
                    Stroke = Brushes.Red,
                    StrokeThickness = 3
                };
            if (Mouse.MiddleButton == MouseButtonState.Pressed)
                mapControl.Markers.Clear();
        }

        private void mapView_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MapSevernoeClick(object sender, RoutedEventArgs e)
        {
            mapControl.Position = new PointLatLng(54.091697, 52.540152); //Центральное расположение карты.
        }

        private void MapBugulmaClick(object sender, RoutedEventArgs e)
        {
            mapControl.Position = new PointLatLng(54.525936, 52.822807); //Центральное расположение карты.
        }
    }
}
