using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Bygdrift.Warehouse;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Module.AppFunctions.Helpers;
using Module.Repositories;
using Module.Repositories.Models;
using Newtonsoft.Json.Linq;


//Parking-xu24jelgvefoq
namespace Module.AppFunctions
{
    public class Module
    {
        public readonly AppBase<Settings> App;
        public readonly ModuleRepository moduleRepository;

        public Module(ILogger<Module> logger)
        {
            App = new AppBase<Settings>(logger);
            moduleRepository = new ModuleRepository(App);
        }

        [FunctionName(nameof(Modules))]
        [OpenApiOperation(operationId: nameof(Modules), tags: new[] { "Module" }, Summary = "Lists all modules", Visibility = OpenApiVisibilityType.Important)]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(List<AppService>), Summary = "successful operation", Description = "successful operation")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.NotFound, Summary = "No modules found")]
        public async Task<IActionResult> Modules([HttpTrigger(AuthorizationLevel.Admin, "get", Route = "module")] HttpRequest req)
        {
            return new OkObjectResult(await moduleRepository.GetModulesAsync());
        }

        [FunctionName(nameof(ModuleByName))]
        [OpenApiOperation(operationId: nameof(Modules), tags: new[] { "Module" }, Summary = "Get a single module", Visibility = OpenApiVisibilityType.Important)]
        [OpenApiParameter(name: "name", In = ParameterLocation.Path, Required = true, Type = typeof(string), Summary = "Can be name like 'Parking-xu24jelgvefsq'")]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(AppService), Summary = "successful operation", Description = "successful operation")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.NotFound, Summary = "Module not found")]
        public async Task<IActionResult> ModuleByName([HttpTrigger(AuthorizationLevel.Admin, "get", Route = "module/{name}")] HttpRequest req, string name)
        {
            return new OkObjectResult(await moduleRepository.GetModuleAsync(name));
        }

        [FunctionName(nameof(ModuleByNameSettings))]
        [OpenApiOperation(operationId: nameof(Modules), tags: new[] { "Module" }, Summary = "Get a single modules settings", Visibility = OpenApiVisibilityType.Important)]
        [OpenApiParameter(name: "name", In = ParameterLocation.Path, Required = true, Type = typeof(string), Summary = "Can be name like 'Parking-xu24jelgvefsq'")]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(JObject), Summary = "successful operation", Description = "successful operation")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.NotFound, Summary = "Module not found")]
        public async Task<IActionResult> ModuleByNameSettings([HttpTrigger(AuthorizationLevel.Admin, "get", Route = "moduleSettings/{name}")] HttpRequest req, string name)
        {
            return new OkObjectResult(await moduleRepository.GetAppSettingsAsync(name));
        }

        [FunctionName(nameof(ModuleByNameSecrets))]
        [OpenApiOperation(operationId: nameof(Modules), tags: new[] { "Module" }, Summary = "Get a single modules secrets", Visibility = OpenApiVisibilityType.Important)]
        [OpenApiParameter(name: "name", In = ParameterLocation.Path, Required = true, Type = typeof(string), Summary = "Can be name like 'Parking-xu24jelgvefsq'")]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(Dictionary<string, object>), Summary = "successful operation", Description = "successful operation")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.NotFound, Summary = "Module not found")]
        public IActionResult ModuleByNameSecrets([HttpTrigger(AuthorizationLevel.Admin, "get", Route = "moduleSecrets/{name}")] HttpRequest req, string name)
        {
            return new OkObjectResult(moduleRepository.GetAppSecrets(name));
        }
    }
}

