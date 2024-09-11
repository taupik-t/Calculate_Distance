using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Distance
{
    public class HaversineDistanceFormula
    {
        public const double EarthRadiusKm = 6371;

        public static double CalculateDistance(double custLat, double custLon, double vendLat, double vendLon)
        {
            // Convert degrees to radians
            double dLat = DegreesToRadians(vendLat - custLat);
            double dLon = DegreesToRadians(vendLon - custLon);

            custLat = DegreesToRadians(custLat);
            vendLat = DegreesToRadians(vendLat);

            // Haversine formula
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(custLat) * Math.Cos(vendLat) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            // Distance in kilometers
            return EarthRadiusKm * c;
        }

        private static double DegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180);
        }
    }
}
