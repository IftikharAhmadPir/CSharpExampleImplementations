using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.Hosting;
using System.IO;
using System.Reflection;
using System.Web.Security;
using System.ServiceModel;
using System.Windows.Forms;
using CShartPractice;
using CSharpPractice;

namespace CShartPractice.NETFramework
{
    public static class BasicProgrammingExample
    {
        public static void checkAppSettingValue()
        {
            string key = "Iftikhar";
            var abc = WebConfigurationManager.AppSettings[key];
        }

        public static void checkHostingEnvironment()
        {
            string HostingPath = HostingEnvironment.ApplicationPhysicalPath;
            string HostingPath0 = AppDomain.CurrentDomain.BaseDirectory;

            var abc = Directory.GetFiles(HostingPath0, "LIS.*.IBLL.dll", SearchOption.TopDirectoryOnly)
                .Select(file =>
                {
                    try
                    {
                        return Assembly.LoadFrom(file);
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                });
        }

        public static void generatePassword()
        {
            var a1 = Membership.GeneratePassword(5, 1);
            var a2 = Membership.GeneratePassword(6, 2);
            var a3 = Membership.GeneratePassword(7, 3);
            var a4 = Membership.GeneratePassword(8, 4);
            var a5 = Membership.GeneratePassword(9, 5);
            var a6 = Membership.GeneratePassword(10, 6);
            var a7 = Membership.GeneratePassword(11, 7);
            var a8 = Membership.GeneratePassword(12, 8);
            var a9 = Membership.GeneratePassword(13, 9);
        }

        public static void checkOperationContext()
        {
            var abc = OperationContext.Current?.Host?.BaseAddresses?.FirstOrDefault();
        }
        public static string HashPasswordForStoringInConfigFile(string value)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(value, "md5");
        }

        public static void GetDirectory()
        {
            //var directory = System.IO.Path.GetDirectoryName("C:\\Users\\iftik\\source\\repos\\CSharpPractice\\CShartPractice.NETFramework\\");
            //var againDirectory = AppContext.BaseDirectory;
            var path1 = HostingEnvironment.ApplicationPhysicalPath;
            var path2 = AppContext.BaseDirectory;
        }

        public static void CheckRichText()
        {
            string input = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1031{\fonttbl{\f0\fnil\fcharset0 Arial;}{\f1\fnil\fcharset238{\*\fname Arial;}Arial CE;}}  \viewkind4\uc1\pard\fs17 Diese Sicht enth\'e4lt alle Kundenauftr\'e4ge aus #*SLAUF (sprich alle Zustellteilstrecken), die normal, importiert, ILV oder Avise sind. Ebenfalls sichtbar sind Ums\'e4tze und Erl\'f6se aus #*SumKA, die KMGFT aus #*Auf, Namen und Adressen von Auftraggeber, Absender, Empf\'e4nger und ESped aus dem Kundenstamm (#*Kun).\f1   \par }";
            using (RichTextBox rtb = new RichTextBox())
            {
                rtb.Rtf = input;
                var abc = rtb.Text;
            }

            var aaa = RichTextStripper.StripRichTextFormat(input);
        }
    }
}
