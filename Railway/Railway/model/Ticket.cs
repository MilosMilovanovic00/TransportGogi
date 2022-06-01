﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Model
{
    class Ticket
    {
        public Station StartStation { get; set; }
        public Station EndStation { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfPassengers { get; set; }

        public Ticket()
        {
            Date = new DateTime();
        }
        public Ticket(Station startStation, Station endStation, DateTime date, int numberOfPassengers)
        {
            StartStation = startStation;
            EndStation = endStation;
            Date = date;
            NumberOfPassengers = numberOfPassengers;
        }

        public override string ToString()
        {
            return "Start station: " + StartStation.ToString() + "/nEnd station: " + EndStation.ToString() + "/nDate: " + Date + "/nNumberOfPassengers: " + NumberOfPassengers;
        }
    }
}