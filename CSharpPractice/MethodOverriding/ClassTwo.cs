using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice.MethodOverriding
{
    public class ClassTwo : ClassOne
    {
        public override int addSum(int a, int b)
        {
            return a * b;
        }
    }
}
