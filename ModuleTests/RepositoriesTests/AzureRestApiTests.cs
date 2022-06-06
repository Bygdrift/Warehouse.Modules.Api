using Bygdrift.Warehouse;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module;
using Module.Repositories;
using Module.Services;
using System.Threading.Tasks;

namespace ModuleTests.RepositoriesTests
{
    [TestClass]
    public class RepositoriesTests
    {
        private readonly AppBase<Settings> app;
        private readonly ModuleRepository repository;
        public RepositoriesTests()
        {
            app = new();
            repository = new ModuleRepository(app);
        }

        [TestMethod]
        public async Task Test()
        {
            
            var a = await repository.GetAppSettingsAsync("OS2IOT-xu24jelgvefoq");
        }
    }
}
