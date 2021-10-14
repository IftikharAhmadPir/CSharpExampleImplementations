using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    public static class GeoCoordinate
    {
        public static double CalculateDistance(Location point1, Location point2)
        {
            //point1.Latitude = Math.Round(point1.Latitude, 0) / 100000;
            //point1.Longitude = Math.Round(point1.Longitude, 0) / 100000;

            //point2.Latitude = Math.Round(point2.Latitude, 0) / 100000;
            //point2.Longitude = Math.Round(point2.Longitude, 0) / 100000;


            var d1 = point1.Latitude * (Math.PI / 180.0);
            var num1 = point1.Longitude * (Math.PI / 180.0);
            var d2 = point2.Latitude * (Math.PI / 180.0);
            var num2 = point2.Longitude * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);
            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }
    }
    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
