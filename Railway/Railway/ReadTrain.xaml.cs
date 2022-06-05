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
    /// Interaction logic for ReadTrain.xaml
    /// </summary>
    public partial class ReadTrain : Page
    {
        private Frame managerContentFrame;
        public ReadTrain(Frame managerContentFrame)
        {
            InitializeComponent();
            this.managerContentFrame = managerContentFrame;



            int trainIndex = 1;

            foreach (Train train in Data.trains)
            {
                OneTrain oneTrain = new OneTrain(train, managerContentFrame);

                addRowPixels(ReadTrainGrid, oneTrain.getHeight());
                
                Grid.SetRow(oneTrain, trainIndex);

                ReadTrainGrid.Children.Add(oneTrain);
                trainIndex++;
            }

            
        }

        private void addRowPixels(Grid grid, double height)
        {
            var rd = new RowDefinition();
            rd.Height = new GridLength(height);
            grid.RowDefinitions.Add(rd);
        }

        private void AddNewTrain_Click(object sender, RoutedEventArgs e)
        {
            managerContentFrame.Content = new AddTrain(managerContentFrame);
        }
    }
}
