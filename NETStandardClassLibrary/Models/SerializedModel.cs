using System;
using System.Collections.Generic;
using System.Text;

namespace NETStandardClassLibrary.Models
{
    [Serializable]
    public class SerializedModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Type Type { get; set; }
    }
}
