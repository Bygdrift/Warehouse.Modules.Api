using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;

namespace Module.AppFunctions
{
    //https://github.com/Azure/azure-functions-openapi-extension/blob/main/docs/openapi-core.md#openapi-metadata-configuration

    //https://petstore.swagger.io/#/pet/findPetsByTags
    //https://github.com/Azure/azure-functions-openapi-extension/blob/main/samples/Microsoft.Azure.Functions.Worker.Extensions.OpenApi.FunctionApp.OutOfProc/PetHttpTrigger.cs
    public class OpenApiConfigurationOptions : IOpenApiConfigurationOptions
    {
        public OpenApiInfo Info { get; set; } = new OpenApiInfo()
        {
            Version = "1.0.0",
            Title = "OpenAPI Document on Bygdrift Warehouse",
            //Description = "HTTP APIs that run on Azure Functions using OpenAPI specification.",
            //TermsOfService = new Uri("https://github.com/Azure/azure-functions-openapi-extension"),
            //Contact = new OpenApiContact()
            //{
            //    Name = "Contoso",
            //    Email = "azfunc-openapi@contoso.com",
            //    Url = new Uri("https://github.com/Azure/azure-functions-openapi-extension/issues"),
            //},
            //License = new OpenApiLicense()
            //{
            //    Name = "MIT",
            //    Url = new Uri("http://opensource.org/licenses/MIT"),
            //}
        };

        public List<OpenApiServer> Servers { get; set; } = new List<OpenApiServer>();

        public OpenApiVersionType OpenApiVersion { get; set; } = OpenApiVersionType.V3;
        public bool IncludeRequestingHostName { get; set; }
        public bool ForceHttp { get; set; } = false;
        public bool ForceHttps { get; set; } = false;
    }
}
