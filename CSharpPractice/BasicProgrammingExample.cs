using System;
using System.Globalization;
using Newtonsoft.Json;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using CSharpPractice.Interface;
using CSharpPractice.Implementation;
using System.Linq;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Text;

namespace CSharpPractice
{
    public static class BasicProgrammingExample
    {
        #region [Public Methods]
        public static void CheckEvenOdd( )
        {
            Console.WriteLine("Please Enter The Number");
            int i = Convert.ToInt32(Console.ReadLine());

            if ((i % 2).Equals(0))
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }

        public static void SwapTwoNumbers()
        {
            int num1 = 1, num2 = 2, temp;
            Console.WriteLine("Original:");
            Console.WriteLine("Num1: {0} , Num2: {1}", num1, num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Swapped:");
            Console.WriteLine("Num1: {0} , Num2: {1}", num1, num2);

        }

        public static void DateTimeFormat()
        {
            DateTime date = new DateTime(2021, 06, 19, 14, 20, 20);
            Console.WriteLine("Original Date Time: {0}", date);
            Console.WriteLine("Formatted Date Time: {0}", date.ToString("yyyy-MM-dd"));
            Console.WriteLine("Formatted Date Time: {0}", date.ToString("dd-MMM-yy"));
            Console.WriteLine("Formatted Date Time: {0}", date.ToString("M/d/yyyy"));
            Console.WriteLine("Formatted Date Time: {0}", date.ToString("M/d/yy"));
            Console.WriteLine("Formatted Date Time: {0}", date.ToString("MM/dd/yyyy"));
            Console.WriteLine("Formatted Date Time: {0}", date.ToString("MM/dd/yy"));
            Console.WriteLine("Formatted Date Time: {0}", date.ToString("yy/MM/dd"));
        }

        public static void CultureInformation()
        {
            // Creates and initializes the CultureInfo which uses the international sort.
            CultureInfo myCIintl = new CultureInfo("en-EN", false);

            // Creates and initializes the CultureInfo which uses the traditional sort.
            CultureInfo myCItrad = new CultureInfo("de-DE", false);

            // Displays the properties of each culture.
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "PROPERTY", "ENGLISH", "GERMAN");
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "CompareInfo", myCIintl.CompareInfo, myCItrad.CompareInfo);
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "DisplayName", myCIintl.DisplayName, myCItrad.DisplayName);
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "EnglishName", myCIintl.EnglishName, myCItrad.EnglishName);
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "IsNeutralCulture", myCIintl.IsNeutralCulture, myCItrad.IsNeutralCulture);
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "IsReadOnly", myCIintl.IsReadOnly, myCItrad.IsReadOnly);
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "LCID", myCIintl.LCID, myCItrad.LCID);
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Name", myCIintl.Name, myCItrad.Name);
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "NativeName", myCIintl.NativeName, myCItrad.NativeName);
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "Parent", myCIintl.Parent, myCItrad.Parent);
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "TextInfo", myCIintl.TextInfo, myCItrad.TextInfo);
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "ThreeLetterISOLanguageName", myCIintl.ThreeLetterISOLanguageName, myCItrad.ThreeLetterISOLanguageName);
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "ThreeLetterWindowsLanguageName", myCIintl.ThreeLetterWindowsLanguageName, myCItrad.ThreeLetterWindowsLanguageName);
            Console.WriteLine("{0,-31}{1,-47}{2,-25}", "TwoLetterISOLanguageName", myCIintl.TwoLetterISOLanguageName, myCItrad.TwoLetterISOLanguageName);
            Console.WriteLine();

            // Compare two strings using myCIintl.
            Console.WriteLine("Comparing \"llegar\" and \"lugar\"");
            Console.WriteLine("   With myCIintl.CompareInfo.Compare: {0}", myCIintl.CompareInfo.Compare("llegar", "lugar"));
            Console.WriteLine("   With myCItrad.CompareInfo.Compare: {0}", myCItrad.CompareInfo.Compare("llegar", "lugar"));
        }

        public static void Reverse()
        {
            int num, reverse = 0;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
        }

        public static void Feb()
        {
            int First = -1;
            int Second = 2;
            int Third = 0;

            Console.Write(First + ",");
            Console.Write(Second + ",");
            while (Third < 50)
            {
                Third = First + Second;
                Console.Write(Third + ",");
                First = Second;
                Second = Third;
            }
        }

        public static void BinaryTriangle()
        {
            for (int i = 1; i <= 5; i++)
            {
                bool binary = true;
                Console.Write(Convert.ToInt32(binary));
                for (int j = 1; j < i; j++)
                {
                    binary = !binary;
                    Console.Write(Convert.ToInt32(binary));
                }
                Console.WriteLine();
            }
        }

        public static void CountsOnes()
        {
            int[] a = new int[] { 1, 2, 3, 1, 1, 5, 3, 4, 1 };
            int checkInt = 1;
            int count = 0;
        }

        public static void CheckTimeSpan(TimeSpan? timeout)
        {
            if(timeout.HasValue)
            {
                Console.WriteLine("HasValue");
            }
            Console.WriteLine("Time: {0}", timeout);
        }

        public static void DeserializeObject()
        {
            person _Person = new person();
            _Person.ID = 1;
            _Person.Name = "Iftikhar";
            _Person.Address = "Lahore";

            var serializedObject = JsonConvert.SerializeObject(_Person);

            person deserializedObject = JsonConvert.DeserializeObject<person>(serializedObject);

            var abc = deserializedObject;
            
        }
    
        public static void SimpleHTTPGetRequest()
        {
            string URL = "http://localhost:15672/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            var abc = request.GetResponse();
        }

        public static void BinaryFormatterAndBack()
        {
            try
            {
                LISMessageBase MB = new LISMessageBase()
                {
                    ID = 1,
                    Name = "IftikharAhmad",
                    Address = "Chemnitz"
                };


                var abc = ObjectToByteArray(MB);

                var xyz = ByteArrayToObject(abc);

            }
            catch(Exception ex)
            {
                var abc = ex;
            }

        }

        public static void CountOnes()
        {
            int[] intArray = new int[] { 1, 2, 1, 4, 1 };

            int totalCount = intArray.Where(x => x.Equals(1)).Count();

            Console.WriteLine("Total 1's: {0}", totalCount);
        }

        public static void randNumber()
        {
            Random r = new Random();
            int num = r.Next(1,100);
            Console.WriteLine("Random Generate Number: {0}", num);
        }

        public static void checkWordFrequency()
        {
            string Sentence = "we only loop once over the source, which reduces the cost of the method.";
            int totalOccurance = Sentence.Split("the").Length - 1;
            Console.WriteLine("Total Occurance: {0}", totalOccurance);
        }

        public static void printDiamond()
        {
            decimal start = 5;
            var midPoint = Math.Ceiling(start / 2);
            for(int i = 0; i <= start; i++)
            {
                for(int j = 0; j<=start; j++)
                {
                    if(j == midPoint)
                    {
                        Console.WriteLine("+");
                    }
                }
            }
        }

        public static void ReadImage()
        {
            try
            {
                byte[] binaryData = new byte[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 };

                using (var pdf = new PdfDocument())
                {
                    pdf.LoadFromBytes(binaryData);
                    using (var bitmap = pdf.SaveAsImage(0, PdfImageType.Bitmap))
                    {
                        var abc = bitmap;
                        
                    }
                }
            }
            catch(Exception ex)
            {
                var abc = ex;
            }

        }

        public static void PassGeneric<T>(string base64, T test)
        {
            //var abc = 123;
            //var bb = abc as T;
        }

        //public static void checkOperationContext()
        //{
        //    var abc = OperationContext.Current?.Host?.BaseAddresses?.FirstOrDefault();
        //}

        public static string HashPasswordForStoringInConfigFile(string value)
        {
            MD5 algorithm = MD5.Create();
            byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(value));
            string sh1 = "";
            for (int i = 0; i < data.Length; i++)
            {
                sh1 += data[i].ToString("x2").ToUpperInvariant();
            }

            return sh1;
        }

        public static void InfiniteLoop()
        {
            int num = 0;
            while(true)
            {
                Console.WriteLine("Number: {0}", num);
                num++;
            }
        }

        #endregion

        #region [Private Method]
        private static byte[] ObjectToByteArray(object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        private static Object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }

        #endregion

    }

    public sealed class sealedclass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public sealedclass(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }

    #region View Model
    public class person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
    #endregion
}
