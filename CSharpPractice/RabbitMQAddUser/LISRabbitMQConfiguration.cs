using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public static class LISRabbitMQConfiguration
    {
        #region [Needs]

        private static readonly string m_GuestUserName = "guest";

        private static readonly string m_GuestPassword = "guest";

        #endregion

        #region [Public methods]

        #region EnableManagementPlugin
        public static bool EnableManagementPlugin()
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Windows\System32\cmd.exe",
                    Arguments = "/c rabbitmq-plugins enable rabbitmq_management",
                    WorkingDirectory = @"C:\Program Files\RabbitMQ Server\rabbitmq_server-3.8.16\sbin",
                    CreateNoWindow = true
                };
                Process.Start(startInfo).WaitForExit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region AddRabbitMQUser
        public static async void AddRabbitMQUser(string UserName, string Password)
        {
            try
            {
                //// Set MQ server credentials
                //NetworkCredential networkCredential = new NetworkCredential(m_GuestUserName, m_GuestPassword);

                // Instantiate HttpClientHandler, passing in the NetworkCredential
                //using (HttpClientHandler httpClientHandler = new HttpClientHandler { Credentials = new NetworkCredential("guest","guest") })
                //{
                //    using (HttpClient httpClient = new HttpClient(httpClientHandler))
                //    {
                //        // Get the response from the API endpoint.
                //        using (HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("http://localhost:15672/api/users/"))
                //        {
                //            await __ReadHTTPStream(httpResponseMessage.Content, UserName, Password);
                //        }
                //    }
                //}

                ////Adding User
                string uri = $"http://localhost:15672/api/users/{UserName}";

                LISRabbitMQUser mqUser = new LISRabbitMQUser
                {
                    Password = Password,
                    Tags = "administrator"
                };

                await __AddRabbitMQUserPutRequest(mqUser, uri);

                //Adding Permissions
                uri = $"http://localhost:15672/api/permissions/%2F/{UserName}";

                LISRabbitMQUserPermissions mqPermissions = new LISRabbitMQUserPermissions
                {
                    Configure = ".*",
                    Write = ".*",
                    Read = ".*"
                };

                await __AddRabbitMQUserPutRequest(mqPermissions, uri);
                //await __AddRabbitMQUserPermissions(mqPermissions, uri);
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #endregion

        #region [Private methods]

        //public static async void readstream(HttpClientHandler httpClientHandler,string UserName, string Password)
        //{
        //    ////// Set MQ server credentials
        //    //NetworkCredential networkCredential = new NetworkCredential(m_GuestUserName, m_GuestPassword);

        //    //using (HttpClientHandler httpClientHandler = new HttpClientHandler { Credentials = networkCredential })
        //    //{
        //        // Instantiate HttpClient passing in the HttpClientHandler
        //        using (HttpClient httpClient = new HttpClient(httpClientHandler))
        //        {
        //            // Get the response from the API endpoint.
        //            using (HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("http://localhost:15672/api/users/"))
        //            {
        //                await __ReadHTTPStream(httpResponseMessage.Content, UserName, Password);
        //            }
        //        }
        //    //}

        //}


        private static async Task __ReadHTTPStream(HttpContent httpContent, string UserName, string Password)
        {
            var accountExists = false;
            //// Get the response content.
            //HttpContent httpContent = httpResponseMessage.Content;
            // Get the stream of the content.
            using (StreamReader streamReader = new StreamReader(await httpContent.ReadAsStreamAsync()))
            {
                // Get the output string.
                string returnedJsonString = await streamReader.ReadToEndAsync();

                accountExists = __CheckIfUserAlreadyExists(returnedJsonString, UserName);
            }

            //if (accountExists)
            //{

            //}
            //else
            //{
            //    ////Adding User
            //    string uri = $"http://localhost:15672/api/users/{UserName}";

            //    LISRabbitMQUser mqUser = new LISRabbitMQUser
            //    {
            //        Password = Password,
            //        Tags = "administrator"
            //    };

            //    await __AddRabbitMQUserPutRequest(mqUser, uri);
            //    //await __AddRabbitMQUser(mqUser, uri);


            //    //Adding Permissions
            //    uri = $"http://localhost:15672/api/permissions/%2F/{UserName}";

            //    LISRabbitMQUserPermissions mqPermissions = new LISRabbitMQUserPermissions
            //    {
            //        Configure = ".*",
            //        Write = ".*",
            //        Read = ".*"
            //    };

            //    await __AddRabbitMQUserPutRequest(mqPermissions, uri);
            //    //await __AddRabbitMQUserPermissions(mqPermissions, uri);
            //}

        }

        private static bool __CheckIfUserAlreadyExists(string Stream, string UserName)
        {
            // Instantiate a list to loop through.
            List<string> mqAccountNames = new List<string>();
            if (Stream != "")
            {
                // Deserialize into object
                dynamic dynamicJson = JsonConvert.DeserializeObject(Stream);
                if (dynamicJson != null)
                {
                    foreach (dynamic item in dynamicJson)
                    {
                        mqAccountNames.Add(item.name.ToString());
                    }
                }
            }
            //Checking if Account Already Exists
            return mqAccountNames.Any(x => x == UserName);
        }

        private static async Task __AddRabbitMQUserPutRequest<T>(T Model, string uri) where T : class
        {
            string info = JsonConvert.SerializeObject(Model);

            StringContent content = new StringContent(info, Encoding.UTF8, "application/json");

            //// Set MQ server credentials

            using (HttpClientHandler httpClientHandler = new HttpClientHandler { Credentials = new NetworkCredential("guest","guest") })
            {
                // Instantiate HttpClient passing in the HttpClientHandler
                using (HttpClient httpClient = new HttpClient(httpClientHandler))
                {
                    using (var abc = await httpClient.PutAsync(uri, content))
                    {
                        //var status = httpResponseMessage.StatusCode;
                    }
                }
            }
        }

        private static async Task __AddRabbitMQUser(LISRabbitMQUser Model, string uri)
        {
            string info = JsonConvert.SerializeObject(Model);

            StringContent content = new StringContent(info, Encoding.UTF8, "application/json");

            //// Set MQ server credentials
            NetworkCredential networkCredential = new NetworkCredential(m_GuestUserName, m_GuestPassword);

            using (HttpClientHandler httpClientHandler = new HttpClientHandler { Credentials = networkCredential })
            {
                // Instantiate HttpClient passing in the HttpClientHandler
                using (HttpClient httpClient = new HttpClient(httpClientHandler))
                {
                    using (HttpResponseMessage httpResponseMessage = await httpClient.PutAsync(uri, content))
                    {
                        var status = httpResponseMessage.StatusCode;
                    }
                }
            }
        }
        private static async Task __AddRabbitMQUserPermissions(LISRabbitMQUserPermissions Model, string uri)
        {
            string info = JsonConvert.SerializeObject(Model);

            StringContent content = new StringContent(info, Encoding.UTF8, "application/json");

            //// Set MQ server credentials
            NetworkCredential networkCredential = new NetworkCredential(m_GuestUserName, m_GuestPassword);

            using (HttpClientHandler httpClientHandler = new HttpClientHandler { Credentials = networkCredential })
            {
                // Instantiate HttpClient passing in the HttpClientHandler
                using (HttpClient httpClient = new HttpClient(httpClientHandler))
                {
                    using (HttpResponseMessage httpResponseMessage = await httpClient.PutAsync(uri, content))
                    {
                        var status = httpResponseMessage.StatusCode;
                    }
                }
            }
        }
        #endregion
    }
}
