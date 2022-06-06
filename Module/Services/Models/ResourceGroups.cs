namespace Module.Services.Models
{

    public class ResourceGroups
    {
        public Value[] value { get; set; }
    }

    public class Value
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string location { get; set; }
        public ResourceGroupsProperties properties { get; set; }
    }

    public class ResourceGroupsProperties
    {
        public string provisioningState { get; set; }
    }
}
