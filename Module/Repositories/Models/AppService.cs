using System;

namespace Module.Repositories.Models
{
    public class AppService
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Type { get; set; }
        public string Kind { get; set; }
        public string Location { get; set; }
        public string ResourceGroup { get; set; }
        public string State { get; set; }
        public string[] HostNames { get; set; }
        public DateTime lastModifiedTimeUtc { get; set; }

        
    }
}
