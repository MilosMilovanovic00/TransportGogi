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
        public Frame Frame { get; set; }
        public Button Undo { get; set; }
        public Button Redo { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Data.FillData();

            MainFrame.Content = new Login(MainFrame, this);

            //User logedUser = Data.GetLogedUser("pera", "pera");
            //SearchRoute = new SearchRoute(this, logedUser);
            //TicketHistory = new TicketHistory(logedUser);         
            Frame = MainFrame;
            //ShowSearchRoute();
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
        public void ShowSearchRoute()
        {
            MainFrame.Content = SearchRoute;
            CurrentPage = "SearchRoute";
            DeleteUndoRedoButtons();
        }
        public void TryDisableUndoRedo()
        {
            if (!Data.NeedUndo())
                Undo.IsEnabled = false;
            else
                Undo.IsEnabled = true;
            if (!Data.NeedRedo())
                Redo.IsEnabled = false;
            else
                Redo.IsEnabled = true;
        }
        public void AddUndoRedoButtons()
        {
            Undo = new Button();
            Undo.BorderThickness = new Thickness(0);
            Undo.Width = 100;
            Undo.FontSize = 18;
            Undo.Content = "Undo";
            Undo.Background = new SolidColorBrush(Color.FromRgb(0, 176, 255));
            Undo.Foreground = Brushes.FloralWhite;
            Undo.Click += Button_Click_Undo;

            Redo = new Button();
            Redo.BorderThickness = new Thickness(0);
            Redo.Width = 100;
            Redo.FontSize = 18;
            Redo.Content = "Redo";
            Redo.Background = new SolidColorBrush(Color.FromRgb(0, 176, 255));
            Redo.Foreground = Brushes.FloralWhite;
            Redo.Click += Button_Click_Redo;

            undoRedo.Children.Add(Undo);
            undoRedo.Children.Add(Redo);
        }

        public void ShowBuyTicket(BuyTicket buyTicket)
        {
            CurrentPage = "BuyTickets";
            AddUndoRedoButtons();
            TryDisableUndoRedo();
            MainFrame.Content = buyTicket;
        }
        public void DeleteUndoRedoButtons()
        {
            undoRedo.Children.RemoveRange(0, undoRedo.Children.Count);
        }

        private void Button_Click_ShowSearchRoute(object sender, RoutedEventArgs e)
        {
            DeleteUndoRedoButtons();
            MainFrame.Content = SearchRoute;
        }
        private void Button_Click_ShowTicketHistory(object sender, RoutedEventArgs e)
        {         
            DeleteUndoRedoButtons();
            TicketHistory.RefreshPage();
            MainFrame.Content = TicketHistory;
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

        
    }
}
