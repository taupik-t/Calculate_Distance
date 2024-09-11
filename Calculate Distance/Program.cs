using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Distance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double custLat = -6.137;
            double custLon = 106.838;
            double vendLat = -1.144;
            double vendLon = 116.867;

            double distance = HaversineDistanceFormula.CalculateDistance(custLat, custLon, vendLat, vendLon);
            Console.WriteLine($"Distance: {distance} km");

            //Customer location(custLat = -6.137, custLon = 106.838) – area around Jakarta, Indonesia.
            //Vendor location(vendLat = -1.144, vendLon = 116.867) – area around Borneo, Indonesia.

            //Result should be between 1000km
        }
    }
}
