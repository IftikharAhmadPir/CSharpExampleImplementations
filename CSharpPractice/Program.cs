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

            string input = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1031{\fonttbl{\f0\fnil\fcharset0 Arial;}{\f1\fnil\fcharset238{\*\fname Arial;}Arial CE;}}  \viewkind4\uc1\pard\fs17 Diese Sicht enth\'e4lt alle Kundenauftr\'e4ge aus #*SLAUF (sprich alle Zustellteilstrecken), die normal, importiert, ILV oder Avise sind. Ebenfalls sichtbar sind Ums\'e4tze und Erl\'f6se aus #*SumKA, die KMGFT aus #*Auf, Namen und Adressen von Auftraggeber, Absender, Empf\'e4nger und ESped aus dem Kundenstamm (#*Kun).\f1   \par }";
            var reply = RichTextStripper.StripRichTextFormat(input);

            //BasicProgrammingExample.InfiniteLoop();

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
