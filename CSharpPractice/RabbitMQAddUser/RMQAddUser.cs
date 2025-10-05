using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation.Runspaces;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace CSharpPractice
{
    public static class RMQAddUser
    {
        public static async Task<bool> EnableRabbitMQManagementTool()
        {
            try
            {
                if(!await checkIfRabbitMQManagementToolAlreadyEnabled())
                {
                    var path = findpath();
                    var startInfo =
                                    new ProcessStartInfo
                                    {
                                        FileName = @"C:\Windows\System32\cmd.exe",
                                        Arguments = "/c rabbitmq-plugins enable rabbitmq_management",
                                        WorkingDirectory = path,
                                        CreateNoWindow = true
                                    };
                    Process.Start(startInfo).WaitForExit();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static async Task<bool> AddRabbitMQUser(string userName, string password)
        {
            try
            {
                bool isAccountExist = true;
                //Instantiate HttpClientHandler, passing in the NetworkCredential
                using (HttpClientHandler httpClientHandler = new HttpClientHandler { Credentials = new NetworkCredential("guest", "guest") })
                {
                    // Instantiate HttpClient passing in the HttpClientHandler
                    using (HttpClient httpClient = new HttpClient(httpClientHandler))
                    {
                        isAccountExist = await CheckAccountExist(httpClient, userName);
                        //If Account dont exist, then add account
                        if (!isAccountExist)
                        {
                            bool isUserAdded = await AddUser(httpClient, userName, password);
                            if (isUserAdded)
                                await AddPermission(httpClient, userName);
                        }
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        public static async Task<bool> AddUser(HttpClient httpClient, string userName, string password)
        {
            MqUser mqUser = new MqUser
            {
                password = password,
                tags = "administrator"
            };

            string info = JsonConvert.SerializeObject(mqUser);
            using (StringContent content = new StringContent(info, Encoding.UTF8, "application/json"))
            {
                using (HttpResponseMessage httpResponseMessage = await httpClient.PutAsync($"http://localhost:15672/api/users/{userName}", content))
                {
                    return httpResponseMessage.IsSuccessStatusCode;
                }
            }
        }

        public static async Task AddPermission(HttpClient httpClient, string userName)
        {
            MqPermissions mqPermissions = new MqPermissions
            {
                configure = ".*",
                write = ".*",
                read = ".*"
            };

            string info = JsonConvert.SerializeObject(mqPermissions);
            using (StringContent content = new StringContent(info, Encoding.UTF8, "application/json"))
            {
                using(HttpResponseMessage httpResponseMessage = await httpClient.PutAsync($"http://localhost:15672/api/permissions/%2F/{userName}", content))
                {
                    
                }
            }
        }


        #region checkifrabbitmqalreadyconfigured
        private static async Task<bool> checkIfRabbitMQManagementToolAlreadyEnabled()
        {
            //Instantiate HttpClientHandler, passing in the NetworkCredential
            using (HttpClientHandler httpClientHandler = new HttpClientHandler { Credentials = new NetworkCredential("guest", "guest") })
            {
                // Instantiate HttpClient passing in the HttpClientHandler
                using (HttpClient httpClient = new HttpClient(httpClientHandler))
                {
                    string url = $"http://localhost:15672";
                    try
                    {
                        using (HttpResponseMessage response = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Head, url)))
                        {
                            return response.IsSuccessStatusCode;
                        }
                    }
                    catch (HttpRequestException ex)
                    {
                        return false;
                    }
                }
            }
        }
        #endregion

        #region CheckAccountExist
        private static async Task<bool> CheckAccountExist(HttpClient httpClient, string userName)
        {
            //Get Response from Api endpoint
            using (HttpResponseMessage httpResponseMessages = await httpClient.GetAsync("http://localhost:15672/api/users/"))
            {
                // Get the response content.
                HttpContent httpContent = httpResponseMessages.Content;

                // Get the stream of the content.
                using (StreamReader streamReader = new StreamReader(await httpContent.ReadAsStreamAsync()))
                {
                    // Get the output string.
                    string returnedJsonString = await streamReader.ReadToEndAsync();

                    // Instantiate a list to loop through.
                    List<string> mqAccountNames = new List<string>();

                    if (returnedJsonString != "")
                    {
                        // Deserialize into object
                        dynamic dynamicJson = JsonConvert.DeserializeObject(returnedJsonString);
                        if (dynamicJson != null)
                        {
                            foreach (dynamic item in dynamicJson)
                            {
                                mqAccountNames.Add(item.name.ToString());
                            }
                        }
                    }
                    return mqAccountNames.Any(x => x == userName);
                }
            }
        }
        #endregion

        #region findpath
        private static string findpath()
        {
            var BasePath = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\RabbitMQ", "UninstallString", null);
            var RabbitMQVersion = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\RabbitMQ", "DisplayVersion", null);

            var DirectoryPath = Path.GetDirectoryName(BasePath);
            var finalPath = Path.Combine(DirectoryPath, "rabbitmq_server-" + RabbitMQVersion, "sbin");

            return finalPath;
        }
        #endregion
    }

    public class MqUser
    {
        public string password { get; set; }
        public string tags { get; set; }
    }

    public class MqPermissions
    {
        public string configure { get; set; }
        public string write { get; set; }
        public string read { get; set; }

    }
}