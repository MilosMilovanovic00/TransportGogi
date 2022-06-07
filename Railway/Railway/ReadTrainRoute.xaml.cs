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
        private Railway.MainWindow window { get; set; }
        public ReadTrainRoute(Railway.MainWindow mainWindow)
        {
            this.window = mainWindow;
            this.window.CurrentPage = "ReadTrainRoute";
            InitializeComponent();
            window.AddUndoRedoButtons(readTrainRoutePanel);
            InitializeComponent();

            AddContent();

        }

        public void AddContent()
        {
            int trainlineIndex = 1;

            foreach (Trainline trainline in Data.GetTrainLines())
            {
                OneTrainRoute oneTrainRoute = new OneTrainRoute(trainline, window);

                addRowPixels(ReadTrainRouteGrid, oneTrainRoute.getHeight());
                Grid.SetRow(oneTrainRoute, trainlineIndex);

                ReadTrainRouteGrid.Children.Add(oneTrainRoute);
                trainlineIndex++;
            }
        }
        public void RefreshPage()
        {
            window.TryDisableUndoRedo();
            ReadTrainRouteGrid.Children.RemoveRange(0, ReadTrainRouteGrid.Children.Count);
            AddContent();
        }
        private void addRowPixels(Grid grid, double height)
        {
            var rd = new RowDefinition();
            rd.Height = new GridLength(height);
            grid.RowDefinitions.Add(rd);
        }


        private void AddNewTrainRoute_Click(object sender, RoutedEventArgs e)
        {
            window.MainFrame.Content = new AddTrainRoute(window);
        }
    }
}

