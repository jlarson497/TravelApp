using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Travel_App
{
    class Segment
    {
        public int SegmentNumber {get; set;}
        public string Departure {get; set;}
        public string Destination {get; set;}
        public decimal Distance {get; set;}
        public DateTime Time {get; set;}
        public decimal Price {get; set;}

        public Segment();

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}", SegmentNumber, Departure, Destination, Distance, Time, Price);
        }

    }
}
