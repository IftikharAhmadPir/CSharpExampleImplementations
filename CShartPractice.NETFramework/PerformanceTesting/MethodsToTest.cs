using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShartPractice
{
    class MethodsToTest
    {
        public static void toString()
        {
            int i = 1122334455;
            var before = DateTime.Now.Millisecond;
            string converted = i.ToString();
            var after = DateTime.Now.Millisecond;
        }
    }
}
