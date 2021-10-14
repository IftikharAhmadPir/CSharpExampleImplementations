using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace CShartPractice.NETFramework
{
    public static class Coordinate
    {
        public static double getAirlineDistanceTo(this Location CoordFrom, Location CoordTo)
        {
            //CoordFrom.Latitude = Math.Round(CoordFrom.Latitude, 0) / 100000;
            //CoordFrom.Longitude = Math.Round(CoordFrom.Longitude, 0) / 100000;

            //CoordTo.Latitude = Math.Round(CoordTo.Latitude, 0) / 100000;
            //CoordTo.Longitude = Math.Round(CoordTo.Longitude, 0) / 100000;
            return CoordFrom.ToGeoCoordinate().GetDistanceTo(CoordTo.ToGeoCoordinate());
        }

        public static GeoCoordinate ToGeoCoordinate(this Location Coordinate)
        {
            return new GeoCoordinate(Coordinate.Latitude, Coordinate.Longitude);
        }
    }
    
    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
