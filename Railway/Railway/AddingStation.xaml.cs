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

namespace Railway
{
    /// <summary>
    /// Interaction logic for AddingStation.xaml
    /// </summary>
    public partial class AddingStation : Page
    {

        public AddingStation(Frame mainFrame)
        {
            InitializeComponent();
        }

        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) {
                DragDrop.DoDragDrop(LocationPoint, LocationPoint, DragDropEffects.Move);
            }
        }

        private void Map_Loaded(object sender, RoutedEventArgs e)
        {

            //oznaci sve lokacije koje vec postoje
            //mapa.ZoomLevel = 9;
            //mapa.Center = new Microsoft.Maps.MapControl.WPF.Location(44.785197, 20.668373);
        }

    }
}
