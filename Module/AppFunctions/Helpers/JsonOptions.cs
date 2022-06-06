using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Module.AppFunctions.Helpers
{
    public class JsonOptions
    {
        public static readonly JsonSerializerOptions Serialize = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = false };
        public static readonly JsonSerializerOptions SerializePretty = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = true };

        public static OkObjectResult OkObject(object value)
        {
            var jsonString = JsonSerializer.Serialize(value, Serialize);
            return new OkObjectResult(jsonString);
        }

        public static OkObjectResult OkObjectPretty(object value)
        {
            var jsonString = JsonSerializer.Serialize(value, SerializePretty);
            return new OkObjectResult(jsonString);
        }
    }
}
