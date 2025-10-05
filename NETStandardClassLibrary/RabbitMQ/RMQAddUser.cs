using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NETStandardClassLibrary
{
    public class RabbitMQScripts
    {

        internal bool IsSucceeded { get; set; }
        internal bool IsManagementToolEnabled { get; set; }
        private string GuestUserName { get; set; }
        private string GuestPassword { get; set; }
        private string HostName { get; set; }

        public RabbitMQScripts(string guestUserName, string guestPassword, string hostName)
        {
            GuestUserName = guestUserName;
            GuestPassword = guestPassword;
            HostName = hostName;
        }

        public void EnableManagementTool()
        {
            IsManagementToolEnabled = false;
            try
            {
                var startInfo =
                                new ProcessStartInfo
                                {
                                    FileName = @"C:\Windows\System32\cmd.exe",
                                    Arguments = "/c rabbitmq-plugins enable rabbitmq_management",
                                    WorkingDirectory = @"C:\Program Files\RabbitMQ Server\rabbitmq_server-3.8.16\sbin",
                                    CreateNoWindow = true
                                };
                Process.Start(startInfo).WaitForExit();
                IsManagementToolEnabled = true;
            }
            catch (Exception)
            {
                IsManagementToolEnabled = false;
            }
        }

        public async Task AddUserModified(string UserName, string Password)
        {
            try
            {
                IsSucceeded = false;
                // Set MQ server credentials
                NetworkCredential networkCredential = new NetworkCredential(GuestUserName, GuestPassword);

                // Instantiate HttpClientHandler, passing in the NetworkCredential
                HttpClientHandler httpClientHandler = new HttpClientHandler { Credentials = networkCredential };

                // Instantiate HttpClient passing in the HttpClientHandler
                using (HttpClient httpClient = new HttpClient(httpClientHandler))
                {
                    // Get the response from the API endpoint.
                    using (HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("http://"+ HostName + ":15672/api/users/"))
                    {
                        // Get the response content.
                        HttpContent httpContent = httpResponseMessage.Content;
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

                            bool accountExists = mqAccountNames.Any(x => x == UserName);

                            if (accountExists)
                            {
                                IsSucceeded = true;
                            }
                            else
                            {
                                string uri = $"http://{HostName}:15672/api/users/{UserName}";

                                MqUser mqUser = new MqUser
                                {
                                    password = Password,
                                    tags = "administrator"
                                };

                                string info = JsonConvert.SerializeObject(mqUser);
                                StringContent content = new StringContent(info, Encoding.UTF8, "application/json");

                                using (HttpResponseMessage httpResponseMessageUserAdded = await httpClient.PutAsync(uri, content))
                                {
                                    if (!httpResponseMessageUserAdded.IsSuccessStatusCode)
                                    {
                                        IsSucceeded = false;
                                    }

                                    uri = $"http://{HostName}:15672/api/permissions/%2F/{UserName}";

                                    MqPermissions mqPermissions = new MqPermissions
                                    {
                                        configure = ".*",
                                        write = ".*",
                                        read = ".*"
                                    };

                                    info = JsonConvert.SerializeObject(mqPermissions);
                                    content = new StringContent(info, Encoding.UTF8, "application/json");

                                    using (HttpResponseMessage httpResponseMessagePermissionsAdded = await httpClient.PutAsync(uri, content))
                                    {
                                        if (!httpResponseMessage.IsSuccessStatusCode)
                                        {
                                            Console.WriteLine("There was an error creating the permissions on the MQ user account.");
                                            IsSucceeded = false;
                                        }
                                        IsSucceeded = true;
                                    }
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                IsSucceeded = false;
                Console.WriteLine(e);
            }
        }
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