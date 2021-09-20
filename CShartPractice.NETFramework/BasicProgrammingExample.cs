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
    }
}
