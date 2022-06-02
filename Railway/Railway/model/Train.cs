using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Model
{
    public class Train
    {
        public string Name { get; set; }
        public int NumberOfSeats { get; set; }

        public Train()
        { }

        public Train(string name, int numOfSeats)
        {
            Name = name;
            NumberOfSeats = numOfSeats;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nNumber of seats: " + NumberOfSeats;
        }
    }
}
