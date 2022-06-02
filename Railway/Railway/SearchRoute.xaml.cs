﻿using System;
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
using Railway.Model;
namespace Railway
{
    /// <summary>
    /// Interaction logic for SearchRoute.xaml
    /// </summary>
    public partial class SearchRoute : Page
    {
        string numberOfTickets = "1";
        public Frame MainFrame { get; set; }
        public SearchRoute(Frame mainFrame)
        {
            InitializeComponent();
            MainFrame = mainFrame;
            Data.FillData();
            List<string> stationNames = Data.GetStationNames();
            {
                foreach (string stationName in stationNames)
                {
                    from.Items.Add(stationName);
                    to.Items.Add(stationName);
                }
            };
        }

        private void plusTicket_Click(object sender, RoutedEventArgs e)
        {
            numberOfTickets = ticketsNum.Text;
            var numberOfTicketsInt = Int64.Parse(numberOfTickets);
            numberOfTicketsInt++;
            numberOfTickets = numberOfTicketsInt.ToString();
            ticketsNum.Text = numberOfTickets;
        }

        private void minusTicket_Click(object sender, RoutedEventArgs e)
        {
            numberOfTickets = ticketsNum.Text;
            var numberOfTicketsInt = Int64.Parse(numberOfTickets);
            if (numberOfTicketsInt > 1)
            {
                numberOfTicketsInt--;
                numberOfTickets = numberOfTicketsInt.ToString();
                ticketsNum.Text = numberOfTickets;
            }
        }

        private void searchRoute_Click(object sender, RoutedEventArgs e)
        {
            string startStation = from.Text;
            string endStation = to.Text;
            DateTime date;
            if (startStation == "")
            {
                MessageBox.Show("Please enter staring station.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else if (endStation == "")
            {
                MessageBox.Show("Please enter ending station.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                date = DateTime.Parse(travelDate.Text);
            }
            catch
            {
                MessageBox.Show("Please eneter travelling date.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            List<QuickReservation> quickReservations = Data.GetQuickReservations(startStation, endStation, date, Int32.Parse(numberOfTickets));           
            if (quickReservations == null)
            {
                MessageBox.Show("There is no direct route for searched trains. Please enter different stations.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            quickReservations.ForEach(x => Console.WriteLine(x));
            if (quickReservations.Count() == 0)
            {
                MessageBox.Show("There are no available trains on the required route for the date. Please try again with different parameters.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            MainFrame.Content = new BuyTicket(MainFrame, quickReservations);
        }
    }
}

