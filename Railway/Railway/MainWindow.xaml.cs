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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new SearchRoute(MainFrame);
            //MainFrame.Content = new AddTrainRoute();
            /*List<Model.QuickReservation> list = new List<Model.QuickReservation>();
            List<string> allStations = new List<string>();
            allStations.Add("Zrenjanin");
            allStations.Add("Novi Sad");
            DateTime departure = new DateTime(2022, 6, 6, 8, 0, 0);
            DateTime arrival = new DateTime(2022, 6, 6, 8, 52, 0);
            Model.Timetable timetable = new Model.Timetable(new Model.Train("Soko", 22), null, new DateTime(), new DateTime(), null);
            Model.QuickReservation res = new Model.QuickReservation("Zrenjanin", "Novi Sad", allStations, null, timetable, departure, arrival, 100, 52);
            list.Add(res);
            MainFrame.Content = new BuyTicket(MainFrame, list);*/
        }
    }
}
