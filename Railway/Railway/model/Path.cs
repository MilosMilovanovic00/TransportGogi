using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Model
{
    class Path
    {
        public Station PreviousStation { get; set; }
        public Station NextStation { get; set; }
        public int Duration { get; set; } //in minutes
        public int Price { get; set; }

        public Path()  {}

        public Path(Station previousStation, Station nextStation, int duration, int price)
        {
            PreviousStation = previousStation;
            NextStation = nextStation;
            Duration = duration;
            Price = price;
        }

        public override string ToString()
        {
            return "Previous station: " + PreviousStation.ToString() + "/nNext station: " + NextStation.ToString() + "/nDuration: " + Duration + "/nPrice: " + Price;
        }
    }
}
