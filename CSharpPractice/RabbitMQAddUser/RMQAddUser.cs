using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace CSharpPractice
{
    public static class RMQAddUser
    {
        public static async void AddUser()
        {
            try
            {
                //Account I want to create
                var userName = "TestUserName";
                var password = "TestPassword";
                // Set MQ server credentials
                NetworkCredential networkCredential = new NetworkCredential("guest", "guest");

                // Instantiate HttpClientHandler, passing in the NetworkCredential
                HttpClientHandler httpClientHandler = new HttpClientHandler { Credentials = networkCredential };

                // Instantiate HttpClient passing in the HttpClientHandler
                using HttpClient httpClient = new HttpClient(httpClientHandler);

                // Get the response from the API endpoint.
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("http://localhost:15672/api/users/");

                // Get the response content.
                HttpContent httpContent = httpResponseMessage.Content;

                // Get the stream of the content.
                using StreamReader streamReader = new StreamReader(await httpContent.ReadAsStreamAsync());

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

                bool accountExists = false;

                foreach (string mqAccountName in mqAccountNames)
                {
                    if (mqAccountName == userName)
                    {
                        accountExists = true;
                    }
                }

                switch (accountExists)
                {
                    case true:
                        Console.WriteLine("This user already exists on the MQ server.");
                        break;
                    case false:
                        // Create the new user on the MQ Server
                        Console.WriteLine("This user will be created on the MQ server.");

                        string uri = $"http://localhost:15672/api/users/{userName}";

                        MqUser mqUser = new MqUser
                        {
                            password = password,
                            tags = "administrator"
                        };

                        string info = JsonConvert.SerializeObject(mqUser);
                        StringContent content = new StringContent(info, Encoding.UTF8, "application/json");

                        httpResponseMessage = await httpClient.PutAsync(uri, content);
                        if (!httpResponseMessage.IsSuccessStatusCode)
                        {
                            Console.WriteLine("There was an error creating the MQ user account.");
                            Thread.Sleep(2500);
                            //return false;
                        }

                        uri = $"http://localhost:15672/api/permissions/%2F/{userName}";

                        MqPermissions mqPermissions = new MqPermissions
                        {
                            configure = ".*",
                            write = ".*",
                            read = ".*"
                        };

                        info = JsonConvert.SerializeObject(mqPermissions);
                        content = new StringContent(info, Encoding.UTF8, "application/json");

                        httpResponseMessage = await httpClient.PutAsync(uri, content);

                        if (!httpResponseMessage.IsSuccessStatusCode)
                        {
                            Console.WriteLine("There was an error creating the permissions on the MQ user account.");
                            Thread.Sleep(2500);
                            //return false;
                        }

                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
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