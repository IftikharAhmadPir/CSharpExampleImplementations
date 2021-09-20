using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Configuration;


namespace CSharpPractice
{
    public static class Configuration
    {
        public static void checkAppSettingValue()
        {
            var checkVal = ConfigurationManager.AppSettings["Iftikhar"];
        }
    }
}
