using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Model
{
    class Railroad
    {
        public List<Trainline> TrainLines { get; set; }
        public Railroad()
        {
            TrainLines = new List<Trainline>();
        }

        public Railroad(List<Trainline> trainLines)
        {
            TrainLines = trainLines;
        }
    }
}
