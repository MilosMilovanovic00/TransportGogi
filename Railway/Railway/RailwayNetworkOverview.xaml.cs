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
using Microsoft.Maps.MapControl.WPF;
using Railway.Model;

namespace Railway
{
    /// <summary>
    /// Interaction logic for RailwayNetworkOverview.xaml
    /// </summary>
    public partial class RailwayNetworkOverview : Page
    {

        public Trainline Trainline { get; set; }



        public RailwayNetworkOverview(Frame mainFrame,Trainline trainline)
        {
            this.DataContext = this;
            Trainline = trainline;
            Map map = new Map();
            map.ZoomLevel = 9;
            map.Center = new Location(44.785197, 20.668373);
            MapPolyline polyline = new MapPolyline();
            polyline.Stroke = new SolidColorBrush(Colors.Blue);
            polyline.StrokeThickness = 5;
            polyline.Opacity = 0.7;
            LocationCollection locations = new LocationCollection();
            Station currentStation = Trainline.FirstStation;
            while (currentStation.PathToNextStation != null)
            {
                currentStation = currentStation.PathToNextStation.NextStation;
                locations.Add(currentStation.Location);
                Pushpin pin = new Pushpin();
                pin.Location = currentStation.Location;
                map.Children.Add(pin);
            }
            map.Children.Add(polyline);
            railwayNetworkOverviewGrid.Children.Add(map);
            InitializeComponent();
        }
    }
}
