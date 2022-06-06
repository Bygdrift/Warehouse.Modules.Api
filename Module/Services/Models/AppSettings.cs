using System.Collections.Generic;

namespace Module.Services.Models
{
    public class AppSettings
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string location { get; set; }
        public AppSettingsTags tags { get; set; }
        public dynamic properties { get; set; }
    }

    public class AppSettingsTags
    {
        public string hiddenlinkappinsightsresourceid { get; set; }
        public string hiddenlinkappinsightsinstrumentationkey { get; set; }
        public string hiddenlinkappinsightsconnstring { get; set; }
    }
}
