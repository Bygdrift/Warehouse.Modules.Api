using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module;
using Module.Services;
using System.Threading.Tasks;

namespace ModuleTests.Services
{
    [TestClass]
    public class AzureRestApiTests
    {
        private readonly AzureRestApiService service;
        private readonly Bygdrift.Warehouse.AppBase<Settings> app = new();
        public AzureRestApiTests() => service = new AzureRestApiService(app);

        [TestMethod]
        public async Task Test()
        {
            //var b = await service.GetResourceGroupsAsync();
            var services = await service.GetAppServicesAsync();
            //var appService = await service.GetAppServiceAsync("OS2IOT-xu24jelgvefoq");
            //var appSettings = await service.GetAppSettingsAsync("OS2IOT-xu24jelgvefoq");
        }
    }
}
