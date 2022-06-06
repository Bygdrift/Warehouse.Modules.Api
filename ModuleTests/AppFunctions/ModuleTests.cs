using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using System.Threading.Tasks;

namespace ModuleTests.Refines
{
    [TestClass]
    public class ModuleTests
    {
        private readonly Mock<ILogger<Module.AppFunctions.Module>> loggerMock = new();
        private readonly Module.AppFunctions.Module function;

        public ModuleTests() => function = new Module.AppFunctions.Module(loggerMock.Object);

        [TestMethod]
        public async Task Trigger()
        {
            var a = await function.Modules(default);
        }
    }
}
