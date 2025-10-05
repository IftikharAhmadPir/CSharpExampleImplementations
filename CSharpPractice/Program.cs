using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using NETStandardClassLibrary;
using CSharpPractice.IronPDF;
using System.ServiceModel;
using CSharpPractice.InterfaceImplementation;
using CSharpPractice.Interface;
using System.Xml.Serialization;
using System.Xml;
using System.Text;
using Newtonsoft.Json;
using System.Configuration;

namespace CSharpPractice
{
    public class Model
    {
        public Model()
        {
        }

        [JsonConstructor]
        public Model(List<Model> row)
        {
            var abc = row;
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        private static readonly string gernallink = "http://localhost:15672";
        static void Main(string[] args)
        {

            //TimeSpan timespan = new TimeSpan(0, 15, 0);
            //var secondtime = timespan.Seconds;
            //var millisecondtime = timespan.TotalMilliseconds;
            //var millisecondtimeint = (int)timespan.TotalMilliseconds;
            //var kchnahi = 1;

            

            //List<Model> model = new List<Model>()
            //{
            //    new Model()
            //    {
            //        ID = 1,
            //        Name = "Iftikhar Ahmad"
            //    },
            //    new Model()
            //    {
            //        ID = 2,
            //        Name = "Ahmad Jan"
            //    }
            //};

            //var serializedJSON = JsonConvert.SerializeObject(model);

            //var deseraializedJSON = JsonConvert.DeserializeObject<List<Model>>(serializedJSON);

            //foreach (var item in model)
            //{
            //    var abcd = item.Name.GetType();
            //    var abce = item.Name.GetType().FullName;
            //}

            //var ab = typeof(DateTime);
            //var ac = typeof(DateTime).FullName;

            //XmlSerializer xsSubmit = new XmlSerializer(typeof(List<Model>));
            
            //var xml = "";

            //using (var sww = new StringWriter())
            //{
            //    using (XmlWriter writer = XmlWriter.Create(sww))
            //    {
            //        xsSubmit.Serialize(writer, model);
            //        xml = sww.ToString(); // Your XML
            //    }
            //}

            //var JSON = JsonConvert.SerializeObject(model, Newtonsoft.Json.Formatting.None);
            //var byt= Encoding.UTF8.GetBytes(JSON);

            //var aa = "";
            //var path = new Uri(new Uri(gernallink), "api/users/");

            //var abc = OperationContext.Current;
                //Functions.mergePDFStream();
            //Functions.streamToPDF();
            //Functions.PDFToImage();
            //Functions.PNGToPDF();
            //Functions.JPGToPDF();
            ////Functions.TIFFToPDF();
            //Functions.MergePDF();
            //Functions.PDFToImage();

            //Functions.getByte();

            //var directory = new BaseDirectory();
            //directory.callRabbitScript();
            //RMQAddUser.findpath();
            //RMQAddUser.enableRabbitMQManagementTool();
            //RMQAddUser.AddUserModified("NewUser", "NewUser");
            //RMQAddUser.AddUser();
            //RMQAddUser.AddUserModified("NewUser", "NewUser");
            //LISRabbitMQConfiguration.AddRabbitMQUser("NewUser","NewUser");
            //RMQAddUser.enableRabbitMQManagementTool();
            //RMQAddUser.OldImplementation("NewUser", "NewUser");

            //var method1 = RMQAddUser.EnableRabbitMQManagementTool();
            //method1.Wait();
            //var method1Result = method1.Result;
            //if(method1Result)
            //{
            //    var method2 = RMQAddUser.AddRabbitMQUser("gobabygo", "comeback");
            //    method2.Wait();
            //    var method2Result = method2.Result;
            //}

            //BasicProgrammingExample.CheckEvenOdd();
            //BasicProgrammingExample.SwapTwoNumbers();
            //BasicProgrammingExample.DateTimeFormat();
            //BasicProgrammingExample.CultureInformation();
            //BasicProgrammingExample.Reverse();
            //BasicProgrammingExample.Feb();
            //BasicProgrammingExample.BinaryTriangle();
            //BasicProgrammingExample.CheckTimeSpan(new TimeSpan(1,1,1));
            //BasicProgrammingExample.DeserializeObject();
            //BasicProgrammingExample.SimpleHTTPGetRequest();
            //BasicProgrammingExample.BinaryFormatterAndBack();
            //BasicProgrammingExample.CountOnes();
            //BasicProgrammingExample.randNumber();
            //BasicProgrammingExample.checkWordFrequency();
            //BasicProgrammingExample.printDiamond();
            //BasicProgrammingExample.ReadImage();
            //LinqMethods.CountAndGroupExtensions();
            //LinqMethods.CheckFileSize();
            //LinqMethods.PrintParallelOdd();
            //LinqMethods.getAssemblies();
            //LinqMethods.GroupBy();

            /////Event Handling - Start//////
            //ProcessBusinessLogic bl = new ProcessBusinessLogic();
            //bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            //bl.StartProcess();
            ///////Event Handling - End//////
            /////
            ////////Event Handling - Start//////
            //EventHandlingImplementation E = new EventHandlingImplementation();
            //E.ProcessCompleted += E_EventCompleted;
            //E.StartProcessing();
            //E.ProcessCompleted -= E_EventCompleted;
            ///////Event Handling - End//////

            //var exep = new ExeProcess();
            //exep.ExecuteConsoleApp("IftikharAhmad");

            //Configuration.checkAppSettingValue();
            //var a1 = MembershipImp.Generate(5, 1);
            //var a2 = MembershipImp.Generate(6, 2);
            //var a3 = MembershipImp.Generate(7, 3);
            //var a4 = MembershipImp.Generate(8, 4);
            //var a5 = MembershipImp.Generate(9, 5);
            //var a6 = MembershipImp.Generate(10, 6);
            //var a7 = MembershipImp.Generate(11, 7);
            //var a8 = MembershipImp.Generate(12, 8);
            //var a9 = MembershipImp.Generate(13, 9);
            //var a10 = MembershipImp.Generate(27, 26);
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

            //var filedata = File.ReadAllText("C:\\Users\\iftik\\Documents\\tutorial1.rtf");
            //var reply = RichTextStripper.StripRichTextFormat(filedata);

            //string input = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1031{\fonttbl{\f0\fnil\fcharset0 Arial;}{\f1\fnil\fcharset238{\*\fname Arial;}Arial CE;}}  \viewkind4\uc1\pard\fs17 Diese Sicht enth\'e4lt alle Kundenauftr\'e4ge aus #*SLAUF (sprich alle Zustellteilstrecken), die normal, importiert, ILV oder Avise sind. Ebenfalls sichtbar sind Ums\'e4tze und Erl\'f6se aus #*SumKA, die KMGFT aus #*Auf, Namen und Adressen von Auftraggeber, Absender, Empf\'e4nger und ESped aus dem Kundenstamm (#*Kun).\f1   \par }";
            //var Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fswiss\fcharset0 Arial;}" +
            //    @"{\f1\fnil\fprq1\fcharset0 Courier New;}{\f2\fswiss\fprq2\fcharset0 Arial;}}" +
            //    @"{\colortbl ;\red0\green128\blue0;\red0\green0\blue0;}" +
            //    @"{\*\generator Msftedit 5.41.21.2508;}" +
            //    @"\viewkind4\uc1\pard\f0\fs20 The \i Greek \i0 word for 'psyche' is spelled \cf1\f1\u968?\u965?\u967?\u942?\cf2\f2 . The Greek letters are encoded in Unicode.\par" +
            //    @"}";

            //var Rtf = "12345";
            //var reply = RichTextStripper.StripRichTextFormat(Rtf);

            //BasicProgrammingExample.InfiniteLoop();
            //var Point1 = new Location()
            //{
            //    Latitude = 48.8240259,
            //    Longitude = 13.9158686
            //};

            //var Point2 = new Location()
            //{
            //    Latitude = 51.4410378,
            //    Longitude = 6.8759351
            //};

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

            //resultList.Add(GeoCoordinate.CalculateDistance(Point1, Point2));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point3, Point4));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point5, Point6));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point7, Point8));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point9, Point10));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point11, Point12));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point13, Point14));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point15, Point16));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point17, Point18));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point19, Point20));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point21, Point22));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point23, Point24));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point25, Point26));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point27, Point28));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point29, Point30));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point31, Point32));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point33, Point34));
            //resultList.Add(GeoCoordinate.CalculateDistance(Point35, Point36));



            //var Point1 = new Coordinates() { Latitude = 51.2419782, Longitude = 13.9158686 };
            //var Point2 = new Coordinates() { Latitude = 51.4410378, Longitude = 6.8759351 };

            //var Point3 = new Coordinates() { Latitude = 42.546245, Longitude = 1.601554 };
            //var Point4 = new Coordinates() { Latitude = 23.424076, Longitude = 53.847818 };

            //var Point5 = new Coordinates() { Latitude = 33.93911, Longitude = 67.709953 };
            //var Point6 = new Coordinates() { Latitude = 17.060816, Longitude = -61.796428 };

            //var Point7 = new Coordinates() { Latitude = 51.2419782, Longitude = 13.9158686 };
            //var Point8 = new Coordinates() { Latitude = 51.4410378, Longitude = 6.8759351 };

            //var Point9 = new Coordinates() { Latitude = 18.220554, Longitude = -63.068615 };
            //var Point10 = new Coordinates() { Latitude = 41.153332, Longitude = 20.168331 };

            //var Point11 = new Coordinates() { Latitude = 40.069099, Longitude = 45.038189 };
            //var Point12 = new Coordinates() { Latitude = 12.226079, Longitude = -69.060087 };

            //var Point13 = new Coordinates() { Latitude = -11.202692, Longitude = 17.873887 };
            //var Point14 = new Coordinates() { Latitude = -75.250973, Longitude = -0.071389 };

            //var Point15 = new Coordinates() { Latitude = -38.416097, Longitude = -63.616672 };
            //var Point16 = new Coordinates() { Latitude = -14.270972, Longitude = -170.132217 };

            //var Point17 = new Coordinates() { Latitude = 47.516231, Longitude = 14.550072 };
            //var Point18 = new Coordinates() { Latitude = -25.274398, Longitude = 133.775136 };

            //var Point19 = new Coordinates() { Latitude = 12.52111, Longitude = -69.968338 };
            //var Point20 = new Coordinates() { Latitude = 40.143105, Longitude = 47.576927 };

            //var Point21 = new Coordinates() { Latitude = 43.915886, Longitude = 17.679076 };
            //var Point22 = new Coordinates() { Latitude = 13.193887, Longitude = -59.543198 };

            //var Point23 = new Coordinates() { Latitude = 23.684994, Longitude = 90.356331 };
            //var Point24 = new Coordinates() { Latitude = 50.503887, Longitude = 4.469936 };

            //var Point25 = new Coordinates() { Latitude = 12.238333, Longitude = -1.561593 };
            //var Point26 = new Coordinates() { Latitude = 42.733883, Longitude = 25.48583 };

            //var Point27 = new Coordinates() { Latitude = 25.930414, Longitude = 50.637772 };
            //var Point28 = new Coordinates() { Latitude = -3.373056, Longitude = 29.918886 };

            //var Point29 = new Coordinates() { Latitude = 9.30769, Longitude = 2.315834 };
            //var Point30 = new Coordinates() { Latitude = 32.321384, Longitude = -64.75737 };


            //var Point31 = new Coordinates() { Latitude = 4.535277, Longitude = 114.727669 };
            //var Point32 = new Coordinates() { Latitude = -16.290154, Longitude = -63.588653 };

            //var Point33 = new Coordinates() { Latitude = -14.235004, Longitude = -51.92528 };
            //var Point34 = new Coordinates() { Latitude = 25.03428, Longitude = -77.39628 };

            //var Point35 = new Coordinates() { Latitude = 27.514162, Longitude = 90.433601 };
            //var Point36 = new Coordinates() { Latitude = -54.423199, Longitude = 3.413194 };

            //var resultList = new List<double>();

            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point1, Point2));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point3, Point4));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point5, Point6));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point7, Point8));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point9, Point10));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point11, Point12));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point13, Point14));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point15, Point16));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point17, Point18));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point19, Point20));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point21, Point22));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point23, Point24));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point25, Point26));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point27, Point28));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point29, Point30));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point31, Point32));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point33, Point34));
            //resultList.Add(CoordinatesDistanceExtensions.DistanceTo(Point35, Point36));

            //var result = GeoCoordinate.CalculateDistance(Point1, Point2);

            //SystemIOMethods.formatPath();

            //MethodsToTest.toString();

            //int a = 8;

            //if(a>=7)
            //{
            //    //DoSomething
            //    var aa = "";
            //}
            //else if(a > 0)
            //{
            //    //DoSomething
            //}

            //var directory = new BaseDirectory();
            //directory.callRabbitScript();


            Console.ReadLine();
        }

      

        public static void E_EventCompleted(object sender, bool IsSuccessfull)
        {
            var abc = sender;
        }

        // event handler
        public static void bl_ProcessCompleted(object sender, bool IsSuccessful)
        {
            Console.WriteLine("Process " + (IsSuccessful ? "Completed Successfully" : "failed"));
        }
    }
}
