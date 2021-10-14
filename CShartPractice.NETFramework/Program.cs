using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
//using NETStandardClassLibrary;
using NETFrameworkClassLibrary;

namespace CShartPractice.NETFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicProgrammingExample.checkAppSettingValue();
            //BasicProgrammingExample.checkHostingEnvironment();
            //BaseDirectory dir = new BaseDirectory();
            //dir.checkBaseDirectory();
            //BasicProgrammingExample.generatePassword();
            //BasicProgrammingExample.checkOperationContext();
            //var a1 = BasicProgrammingExample.HashPasswordForStoringInConfigFile("Iftikhar");
            //var a2 = BasicProgrammingExample.HashPasswordForStoringInConfigFile(".Susan53");
            //var a3 = BasicProgrammingExample.HashPasswordForStoringInConfigFile("jelly22fi$h");
            //var a4 = BasicProgrammingExample.HashPasswordForStoringInConfigFile("$m3llycat");
            //var a5 = BasicProgrammingExample.HashPasswordForStoringInConfigFile("a11Black$");
            //var a6 = BasicProgrammingExample.HashPasswordForStoringInConfigFile("!ush3r");
            //var a7 = BasicProgrammingExample.HashPasswordForStoringInConfigFile("ebay.44");
            //var a8 = BasicProgrammingExample.HashPasswordForStoringInConfigFile("deltagamm@");
            //var a9 = BasicProgrammingExample.HashPasswordForStoringInConfigFile("!LoveMyPiano");
            //var a10 = BasicProgrammingExample.HashPasswordForStoringInConfigFile("Sterling");
            //BasicProgrammingExample.GetDirectory();
            //BasicProgrammingExample.CheckRichText();

            var Point1 = new Location() { Latitude = 51.2419782, Longitude = 13.9158686 };
            var Point2 = new Location() { Latitude = 51.4410378, Longitude = 6.8759351 };

            var Point3 = new Location() { Latitude = 42.546245, Longitude = 1.601554 };
            var Point4 = new Location() { Latitude = 23.424076, Longitude = 53.847818 };

            var Point5 = new Location() { Latitude = 33.93911, Longitude = 67.709953 };
            var Point6 = new Location() { Latitude = 17.060816, Longitude = -61.796428 };

            var Point7 = new Location() { Latitude = 51.2419782, Longitude = 13.9158686 };
            var Point8 = new Location() { Latitude = 51.4410378, Longitude = 6.8759351 };

            var Point9 = new Location() { Latitude = 18.220554, Longitude = -63.068615 };
            var Point10 = new Location() { Latitude = 41.153332, Longitude = 20.168331 };

            var Point11 = new Location() { Latitude = 40.069099, Longitude = 45.038189 };
            var Point12 = new Location() { Latitude = 12.226079, Longitude = -69.060087 };
            
            var Point13 = new Location() { Latitude = -11.202692, Longitude = 17.873887 };
            var Point14 = new Location() { Latitude = -75.250973, Longitude = -0.071389 };
            
            var Point15 = new Location() { Latitude = -38.416097, Longitude = -63.616672 };
            var Point16 = new Location() { Latitude = -14.270972, Longitude = -170.132217 };
            
            var Point17 = new Location() { Latitude = 47.516231, Longitude = 14.550072 };
            var Point18 = new Location() { Latitude = -25.274398, Longitude = 133.775136 };
            
            var Point19 = new Location() { Latitude = 12.52111, Longitude = -69.968338 };
            var Point20 = new Location() { Latitude = 40.143105, Longitude = 47.576927 };
            
            var Point21 = new Location() { Latitude = 43.915886, Longitude = 17.679076 };
            var Point22 = new Location() { Latitude = 13.193887, Longitude = -59.543198 };
            
            var Point23 = new Location() { Latitude = 23.684994, Longitude = 90.356331 };
            var Point24 = new Location() { Latitude = 50.503887, Longitude = 4.469936 };
            
            var Point25 = new Location() { Latitude = 12.238333, Longitude = -1.561593 };
            var Point26 = new Location() { Latitude = 42.733883, Longitude = 25.48583 };
            
            var Point27 = new Location() { Latitude = 25.930414, Longitude = 50.637772 };
            var Point28 = new Location() { Latitude = -3.373056, Longitude = 29.918886 };
            
            var Point29 = new Location() { Latitude = 9.30769, Longitude = 2.315834 };
            var Point30 = new Location() { Latitude = 32.321384, Longitude = -64.75737 };


            var Point31 = new Location() { Latitude = 4.535277, Longitude = 114.727669 };
            var Point32 = new Location() { Latitude = -16.290154, Longitude = -63.588653 };
            
            var Point33 = new Location() { Latitude = -14.235004, Longitude = -51.92528 };
            var Point34 = new Location() { Latitude = 25.03428, Longitude = -77.39628 };
            
            var Point35 = new Location() { Latitude = 27.514162, Longitude = 90.433601 };
            var Point36 = new Location() { Latitude = -54.423199, Longitude = 3.413194 };

            
            var resultList = new List<double>();

            resultList.Add(Coordinate.getAirlineDistanceTo(Point1, Point2));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point3, Point4));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point5, Point6));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point7, Point8));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point9, Point10));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point11, Point12));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point13, Point14));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point15, Point16));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point17, Point18));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point19, Point20));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point21, Point22));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point23, Point24));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point25, Point26));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point27, Point28));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point29, Point30));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point31, Point32));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point33, Point34));
            resultList.Add(Coordinate.getAirlineDistanceTo(Point35, Point36));

        }
    }
}
