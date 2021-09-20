using System;
using System.Collections.Generic;
using System.Text;
using CSharpPractice.Interface;

namespace CSharpPractice.Implementation
{
    [Serializable]
    class LISMessageBase : ILISMessageBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
