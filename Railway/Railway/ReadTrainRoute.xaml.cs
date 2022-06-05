using Railway.Model;
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
    /// Interaction logic for AddTrainRoute.xaml
    /// </summary>
    public partial class ReadTrainRoute : Page
    {
        private Frame managerContentFrame;
        public ReadTrainRoute(Frame managerContentFrame)
        {
            InitializeComponent();
            this.managerContentFrame = managerContentFrame;


            int trainlineIndex = 1;

            foreach (Trainline trainline in Data.GetTrainLines())
            {              
                OneTrainRoute oneTrainRoute = new OneTrainRoute(trainline, managerContentFrame);
             
                addRowPixels(ReadTrainRouteGrid, oneTrainRoute.getHeight());
                Grid.SetRow(oneTrainRoute, trainlineIndex);

                ReadTrainRouteGrid.Children.Add(oneTrainRoute);
                trainlineIndex++;
            }

        }


        private void addRowPixels(Grid grid, double height)
        {
            var rd = new RowDefinition();
            rd.Height = new GridLength(height);
            grid.RowDefinitions.Add(rd);
        }


        private void AddNewTrainRoute_Click(object sender, RoutedEventArgs e)
        {
            managerContentFrame.Content = new AddTrainRoute(managerContentFrame);
        }
    }
}

