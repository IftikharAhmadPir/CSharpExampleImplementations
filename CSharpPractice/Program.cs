using System;
using System.IO;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
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
            //var abc = MembershipImp.Generate(10, 3);
            //BasicProgrammingExample.HashPasswordForStoringInConfigFile("Iftikhar");

            var filedata = File.ReadAllText("C:\\Users\\iftik\\Documents\\tutorial1.rtf");
            var reply = RichTextStripper.StripRichTextFormat(filedata);

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
