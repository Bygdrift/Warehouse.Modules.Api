using Bygdrift.Warehouse.Helpers.Attributes;

namespace Module
{
    public class Settings
    {
        [ConfigSetting]
        public string AzureSubscriptionId { get; set; }

        [ConfigSetting]
        public string AzureClientId { get; set; }

        [ConfigSetting]
        public string AzureresourceGroup { get; set; }

        [ConfigSetting]
        public string AzureTenantId { get; set; }

        [ConfigSecret]
        public string AzureSecret { get; set; }
    }
}
