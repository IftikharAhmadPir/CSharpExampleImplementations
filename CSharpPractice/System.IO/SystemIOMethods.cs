using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
namespace CSharpPractice
{
    class SystemIOMethods
    {
        public static void formatPath()
        {
            var ret1 = Path.Combine(Path.GetDirectoryName(new Uri(Assembly.GetCallingAssembly().CodeBase).LocalPath), "LIS.NetSped.Core.CrystalReports.exe");
        }
    }
}
