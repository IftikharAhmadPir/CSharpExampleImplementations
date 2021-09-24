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
            var abc = Membership.GeneratePassword(10, 3);
        }

        public static void checkOperationContext()
        {
            var abc = OperationContext.Current?.Host?.BaseAddresses?.FirstOrDefault();
        }
        public static void HashPasswordForStoringInConfigFile()
        {
            var aa = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("Iftikhar", "md5");
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
            using(RichTextBox rtb = new RichTextBox())
            {
                rtb.Rtf = "Iftikhar";
                var abc = rtb.Rtf;
            }
        }
    }
}
