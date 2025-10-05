using NETStandardClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
//using System.ServiceModel;

namespace NETStandardClassLibrary
{
    public static class BaseDirectory
    {
        public static void checkBaseDirectory()
        {
            //var path = AppDomain.CurrentDomain.BaseDirectory;
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        }

        public static async void callRabbitScript()
        {
            var RabbitObject = new RabbitMQScripts("guest", "guest", "localhost");
            RabbitObject.EnableManagementTool();
            if(RabbitObject.IsManagementToolEnabled)
            {
               await RabbitObject.AddUserModified("NewUser", "NewUser");
            }
            if(RabbitObject.IsSucceeded)
            {
                
            }
        }

        public static void justserialize(SerializedModel Model)
        {
            var abc = __ObjectToByteArray(Model);
        }

        private static byte[] __ObjectToByteArray(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
    }
}
