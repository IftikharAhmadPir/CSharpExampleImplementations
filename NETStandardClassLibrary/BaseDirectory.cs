using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandardClassLibrary
{
    public class BaseDirectory
    {
        public void checkBaseDirectory()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
