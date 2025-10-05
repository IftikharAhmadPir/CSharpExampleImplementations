using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
//using NETStandardClassLibrary;
//using NETFrameworkClassLibrary;
using System.Web.Hosting;
using System.Windows.Media;
using NETStandardClassLibrary;
using NETStandardClassLibrary.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CShartPractice.NETFramework
{
    public class CMCIndexMetadataBase
    {
        public string ViewName { get; set; }
        public string ViewUniqueKey { get; set; }
        public string MainTable { get; set; }
        public string[] JoinedTables { get; set; }
        public Dictionary<string, Dictionary<string, string>> JoinDescription { get; set; }
    }


    public class Program : Form
    {
        //private static bool OuterMethod()
        //{
        //    var List = new string[] { "1", "2", "3", "4", "5" };
        //    foreach (var ListItem in List)
        //    {
        //        var abc = ListItem;
        //        Somemethod(abc);
        //        continue;
        //        var hsd = "";
        //    }

        //    return false;
        //}
        //private static bool Somemethod(string somevalue)
        //    {

        //    return true;
        //    }
        static void Main(string[] args)
        {

            // Your date string
            string inputDate = "1996-01-01 00:00:00.000";

            // Convert the string to DateTime
            DateTime date = DateTime.ParseExact(inputDate, "yyyy-MM-dd HH:mm:ss.fff", null);

            // Format the DateTime according to Elasticsearch date format
            string formattedDate = date.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

            // Print the formatted date
            Console.WriteLine("Formatted Date: " + formattedDate);
            //OuterMethod();

            //var CMCCustomer = new CMCIndexMetadataBase()
            //{
            //    ViewName = "XXAV_CMCCustomer",
            //    ViewUniqueKey = "KundenNr",
            //    MainTable = "XXAKun",
            //    JoinedTables = new string[] { "XXAKun2", "Orte" },
            //    JoinDescription = new Dictionary<string, Dictionary<string, string>>()
            //        {
            //          { "XXAKun2", new Dictionary<string, string> { {"KundenNr","KundenNr"}} } ,
            //          { "Orte", new Dictionary<string, string> {{ "LfdNr","OrteLfdNr"},{ "LKZ","OrteLKZ"}}},
            //        },
            //};
            //var sqlstatement = __GenerateSQLStatement(CMCCustomer, "XXAKun2", "KundenNr", "0");

            #region CommentedCOde

            //var abc = "This is a Hash: \\#*";
            //Console.WriteLine(abc);

            // Generating all possible combinations of a 4-digit PIN code
            //string[] combinations = new string[10000];
            //for (int i = 0; i < 10000; i++)
            //{
            //    string pin = i.ToString("D4"); // Pads the PIN with leading zeros if necessary
            //    combinations[i] = pin;
            //}

            //// Print the generated combinations
            //foreach (string pin in combinations)
            //{
            //    Console.WriteLine(pin);
            //}

            //BasicProgrammingExample.checkFilePath("TestMethod", "TestClass");

            //var abc = new SolidColorBrush(Color.FromRgb(227, 6, 20)).Color;



            //var abc = new SerializedModel()
            //{
            //    Id = 1,
            //    Name = "Iftikhar",
            //    Type = typeof(string)
            //};
            //BaseDirectory.justserialize(abc);
            //var abc = HostingEnvironment.ApplicationPhysicalPath;

            //var abc = typeof(BasicProgrammingExample).GetMethod("checkHostingEnvironment");
            //var tes = abc.GetCustomAttributes(false);

            //string address = "https://localhost:44368/api/Employee/GetEmployeeById?Id=1";

            //Uri urinew = new Uri(address);

            //GetSelfHost(urinew);

            //var LongURL = "https://localhost:44368/api/Employee/GetEmployeeById";
            //var parsed = System.Web.HttpUtility.ParseQueryString(LongURL);
            //parsed.Add("Name", "Iftikhar");

            //var scheme = "https";
            //var host = "localhost";
            //var port = 44328;
            //int TestID = 123;

            //var abc = __UriBuilder(scheme, host, port, "SendMSMQTestingMessage", "TestID=" + TestID);
            //UriBuilder baseURI = new UriBuilder(scheme, host, port, "SendMSMQTestingMessage");
            //baseURI.Query = "TestParam = Iftikhar";

            #region UselessCode
            //var strings1 = PDF4NET.__ToTiff();
            //var strings2 = PDF4NET.__ToTiffByIronPDF();

            //var result1 = PDF4NET.PDFStreamToTxtO2Lib();
            //var result2 = PDF4NET.PDFStreamToTxtIronPDF();

            //var result = strings1.Equals(strings2);
            //PDF4NET.checkPrintServer();
            //PDF4NET.DoPrint();
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

            //var Point1 = new Location() { Latitude = 51.2419782, Longitude = 13.9158686 };
            //var Point2 = new Location() { Latitude = 51.4410378, Longitude = 6.8759351 };

            //var Point3 = new Location() { Latitude = 42.546245, Longitude = 1.601554 };
            //var Point4 = new Location() { Latitude = 23.424076, Longitude = 53.847818 };

            //var Point5 = new Location() { Latitude = 33.93911, Longitude = 67.709953 };
            //var Point6 = new Location() { Latitude = 17.060816, Longitude = -61.796428 };

            //var Point7 = new Location() { Latitude = 51.2419782, Longitude = 13.9158686 };
            //var Point8 = new Location() { Latitude = 51.4410378, Longitude = 6.8759351 };

            //var Point9 = new Location() { Latitude = 18.220554, Longitude = -63.068615 };
            //var Point10 = new Location() { Latitude = 41.153332, Longitude = 20.168331 };

            //var Point11 = new Location() { Latitude = 40.069099, Longitude = 45.038189 };
            //var Point12 = new Location() { Latitude = 12.226079, Longitude = -69.060087 };

            //var Point13 = new Location() { Latitude = -11.202692, Longitude = 17.873887 };
            //var Point14 = new Location() { Latitude = -75.250973, Longitude = -0.071389 };

            //var Point15 = new Location() { Latitude = -38.416097, Longitude = -63.616672 };
            //var Point16 = new Location() { Latitude = -14.270972, Longitude = -170.132217 };

            //var Point17 = new Location() { Latitude = 47.516231, Longitude = 14.550072 };
            //var Point18 = new Location() { Latitude = -25.274398, Longitude = 133.775136 };

            //var Point19 = new Location() { Latitude = 12.52111, Longitude = -69.968338 };
            //var Point20 = new Location() { Latitude = 40.143105, Longitude = 47.576927 };

            //var Point21 = new Location() { Latitude = 43.915886, Longitude = 17.679076 };
            //var Point22 = new Location() { Latitude = 13.193887, Longitude = -59.543198 };

            //var Point23 = new Location() { Latitude = 23.684994, Longitude = 90.356331 };
            //var Point24 = new Location() { Latitude = 50.503887, Longitude = 4.469936 };

            //var Point25 = new Location() { Latitude = 12.238333, Longitude = -1.561593 };
            //var Point26 = new Location() { Latitude = 42.733883, Longitude = 25.48583 };

            //var Point27 = new Location() { Latitude = 25.930414, Longitude = 50.637772 };
            //var Point28 = new Location() { Latitude = -3.373056, Longitude = 29.918886 };

            //var Point29 = new Location() { Latitude = 9.30769, Longitude = 2.315834 };
            //var Point30 = new Location() { Latitude = 32.321384, Longitude = -64.75737 };


            //var Point31 = new Location() { Latitude = 4.535277, Longitude = 114.727669 };
            //var Point32 = new Location() { Latitude = -16.290154, Longitude = -63.588653 };

            //var Point33 = new Location() { Latitude = -14.235004, Longitude = -51.92528 };
            //var Point34 = new Location() { Latitude = 25.03428, Longitude = -77.39628 };

            //var Point35 = new Location() { Latitude = 27.514162, Longitude = 90.433601 };
            //var Point36 = new Location() { Latitude = -54.423199, Longitude = 3.413194 };


            //var resultList = new List<double>();

            //resultList.Add(Coordinate.getAirlineDistanceTo(Point1, Point2));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point3, Point4));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point5, Point6));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point7, Point8));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point9, Point10));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point11, Point12));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point13, Point14));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point15, Point16));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point17, Point18));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point19, Point20));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point21, Point22));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point23, Point24));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point25, Point26));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point27, Point28));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point29, Point30));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point31, Point32));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point33, Point34));
            //resultList.Add(Coordinate.getAirlineDistanceTo(Point35, Point36));
            //MethodsToTest.toString();
            #endregion
            #endregion
            //passsomething("",null);
            Console.ReadLine();

        }

        private int totalPoints = 0;
        private int insideCircle = 0;

        //public Program()
        //{
        //    this.Size = new Size(400, 400);
        //    this.Paint += new PaintEventHandler(DrawVisualization);
        //    Timer timer = new Timer();
        //    timer.Interval = 100;
        //    timer.Tick += new EventHandler(UpdateVisualization);
        //    timer.Start();
        //}

        //private void DrawVisualization(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Pen pen = new Pen(Color.Black);
        //    Brush brush = new SolidBrush(Color.Blue);

        //    // Draw a square
        //    g.DrawRectangle(pen, 50, 50, 300, 300);

        //    // Draw a quarter circle
        //    g.DrawArc(pen, 50, 50, 300, 300, 0, 90);

        //    // Draw random points and count how many are inside the quarter circle
        //    Random rand = new Random();
        //    for (int i = 0; i < totalPoints; i++)
        //    {
        //        double x = rand.NextDouble() * 300 + 50;
        //        double y = rand.NextDouble() * 300 + 50;
        //        if (Math.Pow(x - 200 - 50, 2) + Math.Pow(y - 200 - 50, 2) <= Math.Pow(150, 2))
        //        {
        //            insideCircle++;
        //            brush = new SolidBrush(Color.Red);
        //        }
        //        else
        //        {
        //            brush = new SolidBrush(Color.Blue);
        //        }
        //        g.FillRectangle(brush, (float)x, (float)y, 2, 2);
        //    }

        //    // Calculate the approximation of pi
        //    double piApproximation = 4.0 * insideCircle / totalPoints;

        //    // Display the approximation on the form
        //    g.DrawString("Approximation of π: " + piApproximation, Font, brush, 10, 10);
        //}

        private void UpdateVisualization(object sender, EventArgs e)
        {
            totalPoints += 1000; // Add more points for each update
            this.Invalidate();
        }


        private static StringBuilder __GenerateSQLStatement(CMCIndexMetadataBase MetaData, string Table, string PKColumn, string PKValue)
        {
            StringBuilder SqlStatement = new StringBuilder();
            SqlStatement.AppendLine("SELECT " + MetaData.ViewUniqueKey + " FROM " + MetaData.MainTable + "");
            SqlStatement.AppendLine("WHERE " + MetaData.JoinDescription.ElementAt(0).Value.ElementAt(0).Value + " IN");
            SqlStatement.AppendLine("( SELECT " + MetaData.JoinDescription.ElementAt(0).Value.ElementAt(0).Value + " FROM " + MetaData.MainTable + " WHERE " + MetaData.JoinDescription.ElementAt(0).Value.ElementAt(0).Value + " IN");
            SqlStatement.AppendLine("( SELECT " + MetaData.JoinDescription.ElementAt(0).Value.ElementAt(0).Key + " From " + Table + " WHERE " + PKColumn + " = " + PKValue + "");
            return SqlStatement;
        }
        internal static void passsomething(string valie, TimeSpan? timespan)
        {
            var checkval = timespan;
        }

        internal static string __UriBuilder(string Scheme, string Host, int Port, string Path, params string[] QueryStrings)
        {
            UriBuilder baseUri = new UriBuilder(Scheme, Host, Port, "api/LISNotificationController/" + Path);

            foreach (var QuersString in QueryStrings)
            {
                if (baseUri.Query != null && baseUri.Query.Length > 1)
                    baseUri.Query = baseUri.Query.Substring(1) + "&" + QuersString;
                else baseUri.Query = QuersString;
            }
            return baseUri.ToString();
        }


        public static void GetSelfHost(Uri ServerUri)
        {
            var Scheme = ServerUri.Scheme;
            var ServerName = ServerUri.Host;
            var ServerAddress = __GetLocalIP(ServerName);
            var ServerIP = ServerAddress.ToString();
            var ServerPort = ServerUri.Port;
        }

        private static IPAddress __GetLocalIP(string HostName)
        {
            var Addresses = Dns.GetHostAddresses(HostName);
            return Addresses.FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);
        }
    }


}
