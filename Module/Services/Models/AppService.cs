namespace Module.Services.Models
{

    public class AppService
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string location { get; set; }
        public AppServiceTags tags { get; set; }
        public AppServiceProperties properties { get; set; }
    }

    public class AppServiceTags
    {
        public string hiddenlinkappinsightsresourceid { get; set; }
        public string hiddenlinkappinsightsinstrumentationkey { get; set; }
        public string hiddenlinkappinsightsconnstring { get; set; }
    }

    public class AppServiceProperties
    {
        public int numberOfWorkers { get; set; }
        public string[] defaultDocuments { get; set; }
        public string netFrameworkVersion { get; set; }
        public string phpVersion { get; set; }
        public string pythonVersion { get; set; }
        public string nodeVersion { get; set; }
        public string powerShellVersion { get; set; }
        public string linuxFxVersion { get; set; }
        public object windowsFxVersion { get; set; }
        public bool requestTracingEnabled { get; set; }
        public bool remoteDebuggingEnabled { get; set; }
        public string remoteDebuggingVersion { get; set; }
        public bool httpLoggingEnabled { get; set; }
        public object azureMonitorLogCategories { get; set; }
        public bool acrUseManagedIdentityCreds { get; set; }
        public object acrUserManagedIdentityID { get; set; }
        public int logsDirectorySizeLimit { get; set; }
        public bool detailedErrorLoggingEnabled { get; set; }
        public string publishingUsername { get; set; }
        public object publishingPassword { get; set; }
        public object appSettings { get; set; }
        public object metadata { get; set; }
        public object connectionStrings { get; set; }
        public object machineKey { get; set; }
        public object handlerMappings { get; set; }
        public object documentRoot { get; set; }
        public string scmType { get; set; }
        public bool use32BitWorkerProcess { get; set; }
        public bool webSocketsEnabled { get; set; }
        public bool alwaysOn { get; set; }
        public object javaVersion { get; set; }
        public object javaContainer { get; set; }
        public object javaContainerVersion { get; set; }
        public string appCommandLine { get; set; }
        public string managedPipelineMode { get; set; }
        public AppServiceVirtualapplication[] virtualApplications { get; set; }
        public int winAuthAdminState { get; set; }
        public int winAuthTenantState { get; set; }
        public bool customAppPoolIdentityAdminState { get; set; }
        public bool customAppPoolIdentityTenantState { get; set; }
        public object runtimeADUser { get; set; }
        public object runtimeADUserPassword { get; set; }
        public string loadBalancing { get; set; }
        public object[] routingRules { get; set; }
        public AppServiceExperiments experiments { get; set; }
        public object limits { get; set; }
        public bool autoHealEnabled { get; set; }
        public object autoHealRules { get; set; }
        public object tracingOptions { get; set; }
        public string vnetName { get; set; }
        public bool vnetRouteAllEnabled { get; set; }
        public int vnetPrivatePortsCount { get; set; }
        public object publicNetworkAccess { get; set; }
        public bool siteAuthEnabled { get; set; }
        public AppServiceSiteauthsettings siteAuthSettings { get; set; }
        public object cors { get; set; }
        public object push { get; set; }
        public object apiDefinition { get; set; }
        public object apiManagementConfig { get; set; }
        public object autoSwapSlotName { get; set; }
        public bool localMySqlEnabled { get; set; }
        public int managedServiceIdentityId { get; set; }
        public object xManagedServiceIdentityId { get; set; }
        public object keyVaultReferenceIdentity { get; set; }
        public AppServiceIpsecurityrestriction[] ipSecurityRestrictions { get; set; }
        public AppServiceScmipsecurityrestriction[] scmIpSecurityRestrictions { get; set; }
        public bool scmIpSecurityRestrictionsUseMain { get; set; }
        public bool http20Enabled { get; set; }
        public string minTlsVersion { get; set; }
        public object minTlsCipherSuite { get; set; }
        public object supportedTlsCipherSuites { get; set; }
        public string scmMinTlsVersion { get; set; }
        public string ftpsState { get; set; }
        public int preWarmedInstanceCount { get; set; }
        public int functionAppScaleLimit { get; set; }
        public object healthCheckPath { get; set; }
        public bool fileChangeAuditEnabled { get; set; }
        public bool functionsRuntimeScaleMonitoringEnabled { get; set; }
        public object websiteTimeZone { get; set; }
        public int minimumElasticInstanceCount { get; set; }
        public AppServiceAzurestorageaccounts azureStorageAccounts { get; set; }
        public int http20ProxyFlag { get; set; }
        public object sitePort { get; set; }
        public bool antivirusScanEnabled { get; set; }
        public object storageType { get; set; }
    }

    public class AppServiceExperiments
    {
        public object[] rampUpRules { get; set; }
    }

    public class AppServiceSiteauthsettings
    {
        public object enabled { get; set; }
        public object unauthenticatedClientAction { get; set; }
        public object tokenStoreEnabled { get; set; }
        public object allowedExternalRedirectUrls { get; set; }
        public object defaultProvider { get; set; }
        public object clientId { get; set; }
        public object clientSecret { get; set; }
        public object clientSecretSettingName { get; set; }
        public object clientSecretCertificateThumbprint { get; set; }
        public object issuer { get; set; }
        public object allowedAudiences { get; set; }
        public object additionalLoginParams { get; set; }
        public bool isAadAutoProvisioned { get; set; }
        public object aadClaimsAuthorization { get; set; }
        public object googleClientId { get; set; }
        public object googleClientSecret { get; set; }
        public object googleClientSecretSettingName { get; set; }
        public object googleOAuthScopes { get; set; }
        public object facebookAppId { get; set; }
        public object facebookAppSecret { get; set; }
        public object facebookAppSecretSettingName { get; set; }
        public object facebookOAuthScopes { get; set; }
        public object gitHubClientId { get; set; }
        public object gitHubClientSecret { get; set; }
        public object gitHubClientSecretSettingName { get; set; }
        public object gitHubOAuthScopes { get; set; }
        public object twitterConsumerKey { get; set; }
        public object twitterConsumerSecret { get; set; }
        public object twitterConsumerSecretSettingName { get; set; }
        public object microsoftAccountClientId { get; set; }
        public object microsoftAccountClientSecret { get; set; }
        public object microsoftAccountClientSecretSettingName { get; set; }
        public object microsoftAccountOAuthScopes { get; set; }
        public object configVersion { get; set; }
    }

    public class AppServiceAzurestorageaccounts
    {
    }

    public class AppServiceVirtualapplication
    {
        public string virtualPath { get; set; }
        public string physicalPath { get; set; }
        public bool preloadEnabled { get; set; }
        public object virtualDirectories { get; set; }
    }

    public class AppServiceIpsecurityrestriction
    {
        public string ipAddress { get; set; }
        public string action { get; set; }
        public int priority { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class AppServiceScmipsecurityrestriction
    {
        public string ipAddress { get; set; }
        public string action { get; set; }
        public int priority { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
