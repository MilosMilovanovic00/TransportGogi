using Railway.model;
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
        public string CurrentPage { get; set; }
        public SearchRoute SearchRoute { get; set; } 
        public TicketHistory TicketHistory { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Data.FillData();
            User logedUser = Data.GetLogedUser("pera", "pera");
            SearchRoute = new SearchRoute(MainFrame, logedUser);
            TicketHistory = new TicketHistory(logedUser);
            MainFrame.Content = SearchRoute;
            CurrentPage = "SearchRoute";
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
            //Button btn = new Button();
            //btn.Style = FindResource("MaterialDesignRaisedSecondaryButton") as Style;
            //btn.Width = 100;
            //btn.Content = "Alooo";
            //stek.Children.Add(btn);
        }

        private void Button_Click_ShowSearchRoute(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = SearchRoute;
        }

        private void Button_Click_Undo(object sender, RoutedEventArgs e)
        {
            Data.Undo();
            SearchRoute.BuyTicket.QuickReservations = SearchRoute.GetQuickReservations();
            SearchRoute.BuyTicket.RefreshPage();          
        }
        private void Button_Click_Redo(object sender, RoutedEventArgs e)
        {
            Data.Redo();
            SearchRoute.BuyTicket.QuickReservations = SearchRoute.GetQuickReservations();
            SearchRoute.BuyTicket.RefreshPage();
        }

        private void Button_Click_ShowTicketHistory(object sender, RoutedEventArgs e)
        {
            TicketHistory.RefreshPage();
            MainFrame.Content = TicketHistory;
        }
    }
}
