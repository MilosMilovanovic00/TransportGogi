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
using System.Windows.Shapes;

namespace TrainStation
{
    /// <summary>
    /// Interaction logic for AddTrainRoute.xaml
    /// </summary>
    public partial class AddTrainRoute : Window
    {
        int lastStationLabelRow;
        List<Dictionary<String, object>> infoBetweenStations;
        List<String> addedStations;
        public AddTrainRoute()
        {
            InitializeComponent();

            infoBetweenStations = new List<Dictionary<string, object>>();
            addedStations = new List<String>();

            lastStationLabelRow = -1;

            StationComboBox.Items.Add("Zrenjanin");
            StationComboBox.Items.Add("Novi Sad");
            StationComboBox.Items.Add("Beograd");

        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            AddedStationsInfoGrid.Height = AddedStationsInfoGrid.Height + 30 + 90;

            addedStations.Add(StationComboBox.SelectedItem.ToString());

            addRowPixels(AddedStationsInfoGrid, 90);

            if (lastStationLabelRow > -1)
            {
                addBetweenStationInfoGrid();
            } 
            
            addRowPixels(AddedStationsInfoGrid, 30);
            addStationLabel();

            lastStationLabelRow += 2;
        }

        private void addBetweenStationInfoGrid()
        {
            Grid grid = new Grid();
            addColumnStars(grid, 4);
            addColumnStars(grid, 3);
            addColumnStars(grid, 4);
            addColumnStars(grid, 6);
            addRowStars(grid, 1);
            addRowStars(grid, 2);
            addRowStars(grid, 2);
            addRowStars(grid, 1);

            Label durationLabel = new Label();
            durationLabel.Content = "Trip duration:";
            Grid.SetRow(durationLabel, 1);
            Grid.SetColumn(durationLabel, 1);
            grid.Children.Add(durationLabel);

            TextBox durationTextBox = new TextBox();
            Grid.SetRow(durationTextBox, 1);
            Grid.SetColumn(durationTextBox, 2);
            grid.Children.Add(durationTextBox);

            Label priceLabel = new Label();
            priceLabel.Content = "Price:";
            Grid.SetRow(priceLabel, 2);
            Grid.SetColumn(priceLabel, 1);
            grid.Children.Add(priceLabel);

            TextBox priceTextBox = new TextBox();
            Grid.SetRow(priceTextBox, 2);
            Grid.SetColumn(priceTextBox, 2);
            grid.Children.Add(priceTextBox);

            Grid.SetRow(grid, lastStationLabelRow + 1);
            AddedStationsInfoGrid.Children.Add(grid);

            Dictionary<String, object> info = new Dictionary<string, object>();
            info.Add("startStation", addedStations[addedStations.Count - 2]);
            info.Add("endStation", addedStations[addedStations.Count - 1]);
            info.Add("durationTextBox", durationTextBox);
            info.Add("priceTextBox", priceTextBox);


            infoBetweenStations.Add(info);
        }

        private void addStationLabel()
        {
            Label label = new Label();
            string stationName = StationComboBox.SelectedItem.ToString();
            label.Content = stationName;
            Grid.SetRow(label, lastStationLabelRow + 2);
            AddedStationsInfoGrid.Children.Add(label);

        }

        private void addRowPixels(Grid grid, double height)
        {
            var rd = new RowDefinition();
            rd.Height = new GridLength(height);
            grid.RowDefinitions.Add(rd);
        }

        private void addRowStars(Grid grid, double stars)
        {
            var rd = new RowDefinition();
            rd.Height = new GridLength(stars, GridUnitType.Star);
            grid.RowDefinitions.Add(rd);
        }

        private void addColumnStars(Grid grid, double stars)
        {
            var cd = new ColumnDefinition();
            cd.Width = new GridLength(stars, GridUnitType.Star);
            grid.ColumnDefinitions.Add(cd);
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var info in infoBetweenStations)
            {
                TextBox durationTextBox = (TextBox)info["durationTextBox"];
                var duration = durationTextBox.Text;

                TextBox priceTextBox = (TextBox)info["priceTextBox"];
                var price = priceTextBox.Text;

                Console.WriteLine($"From {info["startStation"]} to {info["endStation"]} you will travel {duration} minutes, and you will spend {price}$");
            }
        }
    }
}
