using Bygdrift.Warehouse;
using Module.Services.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

//How to setup authorization on Azure: https://edi.wang/post/2021/8/23/how-to-get-access-token-for-azure-rest-apis-in-net
namespace Module.Services
{
    public class AzureRestApiService
    {
        private HttpClient _client;
        public string token;
        private DateTime tokenFetched;  //Expires in an hour

        public AppBase<Settings> App { get; }

        public AzureRestApiService(AppBase<Settings> app) => App = app;

        public HttpClient Client
        {
            get
            {
                
                if (_client == null || token == null || DateTime.Now.Subtract(tokenFetched).TotalHours >= 1)
                    _client = GetHttpClient();

                return _client;
            }
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/rest/api/appservice/web-apps/list
        /// </summary>
        public async Task<AppServices> GetAppServicesAsync()
        {
            return await GetAsync<AppServices>($"/subscriptions/{App.Settings.AzureSubscriptionId}/resourceGroups/{App.Settings.AzureresourceGroup}/providers/Microsoft.Web/sites?api-version=2021-02-01");
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/rest/api/appservice/web-apps/get-configuration
        /// </summary>
        public async Task<AppService> GetAppServiceAsync(string name)
        {
            return await GetAsync<AppService>($"/subscriptions/{App.Settings.AzureSubscriptionId}/resourceGroups/{App.Settings.AzureresourceGroup}/providers/Microsoft.Web/sites/{name}/config/web?api-version=2021-02-01");
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/rest/api/appservice/web-apps/list-application-settings
        /// </summary>
        public async Task<AppSettings> GetAppSettingsAsync(string name)
        {
            return await PostAsync<AppSettings>($"/subscriptions/{App.Settings.AzureSubscriptionId}/resourceGroups/{App.Settings.AzureresourceGroup}/providers/Microsoft.Web/sites/{name}/config/appsettings/list?api-version=2021-02-01", null);
        }

        public async Task<ResourceGroups> GetResourceGroupsAsync()
        {
            return await GetAsync<ResourceGroups>("/subscriptions/2020a9be-f0b6-49db-a45e-12f72b285334/resourcegroups?api-version=2020-09-01");
        }

        private async Task<T> GetAsync<T>(string subUrl)
        {
            if (Client == null)
                return default;

            //var delimiter = subUrl.Contains('?') ? "&" : "?";
            var response = await Client.GetAsync($"{subUrl}");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                App.Log.LogError("The webservice {Url} failed. Error: {Error}.", response.RequestMessage.RequestUri, response.ReasonPhrase);
                return default;
            }
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        private async Task<T> PostAsync<T>(string subUrl, HttpContent content)
        {
            if (Client == null)
                return default;

            var response = await Client.PostAsync(subUrl, content);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                App.Log.LogError("The webservice {Url} failed. Error: {Error}.", response.RequestMessage.RequestUri, response.ReasonPhrase);
                return default;
            }
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        private HttpClient GetHttpClient()
        {
            var client = new HttpClient{BaseAddress = new Uri("https://management.azure.com")};
            var request = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "grant_type", "client_credentials" },
                { "client_id", App.Settings.AzureClientId },
                { "client_secret", App.Settings.AzureSecret },
                { "resource", client.BaseAddress.ToString() }
            });

            var response = client.PostAsync($"https://login.microsoftonline.com/{App.Settings.AzureTenantId}/oauth2/token", request).Result;
            if (response.StatusCode != HttpStatusCode.OK)
            {
                App.Log.LogError($"The API failed to fetch the token. Error: {response.ReasonPhrase}.");
                client.Dispose();
                return null;
            }

            tokenFetched = DateTime.Now;
            var json = response.Content.ReadAsStringAsync().Result;
            token = ((dynamic)JsonConvert.DeserializeObject(json)).access_token;
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            return client;
        }
    }
}
