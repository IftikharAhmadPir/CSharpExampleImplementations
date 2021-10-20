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


            var FromLat = point1.Latitude * (Math.PI / 180.0);
            var FromLog = point1.Longitude * (Math.PI / 180.0);
            var ToLat = point2.Latitude * (Math.PI / 180.0);
            var ToLog = point2.Longitude * (Math.PI / 180.0) - FromLog;
            var Converted = Math.Pow(Math.Sin((ToLat - FromLat) / 2.0), 2.0) + Math.Cos(FromLat) * Math.Cos(ToLat) * Math.Pow(Math.Sin(ToLog / 2.0), 2.0);
            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(Converted), Math.Sqrt(1.0 - Converted)));
        }
    }
    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
