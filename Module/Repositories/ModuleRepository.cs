using Bygdrift.Warehouse;
using Module.Repositories.Models;
using Module.Services;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Module.Repositories
{
    public class ModuleRepository
    {
        private readonly AzureRestApiService service;

        public ModuleRepository(AppBase<Settings> app) => service = new AzureRestApiService(app);

        public async Task<List<AppService>> GetModulesAsync()
        {
            var res = new List<AppService>();
            var data = await service.GetAppServicesAsync();
            foreach (var app in data.value)
            {
                res.Add(new AppService()
                {
                    Name = app.name,
                    ShortName = app.name.Substring(0, app.name.IndexOf('-')),
                    Type = app.type,
                    Kind = app.kind,
                    Location = app.location,
                    State = app.properties.state,
                    HostNames = app.properties.hostNames,
                    lastModifiedTimeUtc = app.properties.lastModifiedTimeUtc,
                    ResourceGroup = app.properties.resourceGroup,
                });
            }
            return res;
        }

        public async Task<AppService> GetModuleAsync(string name)
        {
            var data = await service.GetAppServiceAsync(name);
            return data == null ? null : new AppService()
            {
                Name = data.name,
                ShortName = data.name.Substring(0, data.name.IndexOf('-')),
                Type = data.type,
                Location = data.location,
            };
        }

        public async Task<JObject> GetAppSettingsAsync(string name)
        {
            var data = await service.GetAppSettingsAsync(name);
            return data?.properties;
        }

        public IEnumerable<KeyValuePair<string, object>> GetAppSecrets(string name)
        {
            return default;
            //Uncomment when 1.0.4 of Warehouse is released
            //if (string.IsNullOrEmpty(name))
            //    return null;

            //var data = service.App.KeyVault.GetSecrets();
            //var shortName = name.Contains('-') ? name.Substring(0, name.IndexOf('-')) : name;

            //return data.Where(o => o.Key.ToLower().StartsWith("secret--" + shortName.ToLower()));
        }
    }
}
