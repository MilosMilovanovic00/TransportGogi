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
    /// Interaction logic for BuyTicket.xaml
    /// </summary>
    public partial class BuyTicket : Page
    {
        public Frame MainFrame { get; set; }
        public List<QuickReservation> QuickReservations { get; set; }
        public BuyTicket(Frame mainFrame, List<QuickReservation> quickReservations)
        {
            InitializeComponent();
            MainFrame = mainFrame;
            QuickReservations = quickReservations;
            DisplayQuickReservations();
        }

        private void DisplayQuickReservations()
        {
            int row = 1;
            foreach (QuickReservation reservation in QuickReservations)
            {
                DisplayBuyTicket.Height += 200;
                var margine = new RowDefinition();
                margine.Height = new GridLength(10, GridUnitType.Pixel);
                DisplayBuyTicket.RowDefinitions.Add(margine);
                var ticketRow = new RowDefinition();
                ticketRow.Height = new GridLength(190, GridUnitType.Pixel);
                DisplayBuyTicket.RowDefinitions.Add(ticketRow);
                Grid grid = new Grid();
                Border border = new Border();
                border.BorderBrush = new SolidColorBrush(Color.FromRgb(20, 19, 19));
                border.Opacity = 0.8;
                border.CornerRadius = new CornerRadius(8, 8, 8, 8);
                border.BorderThickness = new Thickness(95);
              
                grid.Children.Add(border);
                Grid.SetRow(grid, row);
                Grid.SetColumn(grid, 1);
                DisplayBuyTicket.Children.Add(grid);
                row += 2;
            }
        }
    }
}
