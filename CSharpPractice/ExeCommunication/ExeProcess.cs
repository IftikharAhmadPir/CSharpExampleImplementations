using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Newtonsoft.Json;

namespace CSharpPractice
{
    public class ExeProcess
    {
        public void ExecuteConsoleApp(string Input)
        {
            using (Process exeprocess = Process.Start(new ProcessStartInfo()
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                FileName = "C:\\Users\\iftik\\source\\repos\\ExeProcess\\ExeProcess\\bin\\Debug\\ExeProcess.exe",
            }))
            {
                using (StreamWriter mystreamWriter = exeprocess.StandardInput)
                    mystreamWriter.WriteLine(Input);

                StringBuilder line = new StringBuilder();
                
                do
                {
                    line.Append(exeprocess.StandardOutput.ReadLine());
                }
                while (!line.ToString().Contains(" "));

                line.Replace(" ","");

                exeprocess.WaitForExit();

                var returned = exeprocess.StandardOutput.ReadToEnd();
            };
        }

        public static byte[] ObjectToByteArray(Object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

    }

    [Serializable]
    public class employe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

}
