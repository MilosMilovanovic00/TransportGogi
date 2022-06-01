using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Model
{ 
    class QuickReservation
    {
        public Trainline Trainline {get; set;}
        public Timetable Timetable { get; set; }
        public DateTime DateTime { get; set; }
        public int Price { get; set; }

        public int Duration { get; set; }

        public QuickReservation()
        {
            DateTime = new DateTime();
        }

        public QuickReservation(Trainline trainline, Timetable timetable, DateTime dateTime, int price, int duration)
        {
            Trainline = trainline;
            Timetable = timetable;
            DateTime = dateTime;
            Price = price;
            Duration = duration;
        }

        public override string ToString()
        {
            return "QUICK RESERVATION: \n" + "Trainline: " + Trainline.ToString() + "\nTimetable: " + Timetable.ToString() + "\nDuration: " + Duration + "\nPrice: " + Price + "\nDatetime: " + DateTime; 
        }
    }
}
