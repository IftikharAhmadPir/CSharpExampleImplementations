using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace NETFrameworkClassLibrary
{
    public class BaseDirectory
    {
        public void checkBaseDirectory()
        {
            //Change for Development
            var path1 = HostingEnvironment.ApplicationPhysicalPath;
            var path = AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
