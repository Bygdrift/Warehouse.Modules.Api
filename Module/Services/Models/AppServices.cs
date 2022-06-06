using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Services.Models
{

    public class AppServices
    {
        public AppServicesValue[] value { get; set; }
        public object nextLink { get; set; }
        public object id { get; set; }
    }

    public class AppServicesValue
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string kind { get; set; }
        public string location { get; set; }
        public AppServicesTags tags { get; set; }
        public AppServicesProperties properties { get; set; }
        public AppServicesIdentity identity { get; set; }
    }

    public class AppServicesTags
    {
        public string hiddenlinkappinsightsresourceid { get; set; }
        public string hiddenlinkappinsightsinstrumentationkey { get; set; }
        public string hiddenlinkappinsightsconnstring { get; set; }
    }

    public class AppServicesProperties
    {
        public string name { get; set; }
        public string state { get; set; }
        public string[] hostNames { get; set; }
        public string webSpace { get; set; }
        public string selfLink { get; set; }
        public string repositorySiteName { get; set; }
        public object owner { get; set; }
        public string usageState { get; set; }
        public bool enabled { get; set; }
        public bool adminEnabled { get; set; }
        public string[] enabledHostNames { get; set; }
        public AppServicesSiteproperties siteProperties { get; set; }
        public string availabilityState { get; set; }
        public object sslCertificates { get; set; }
        public object[] csrs { get; set; }
        public object cers { get; set; }
        public object siteMode { get; set; }
        public AppServicesHostnamesslstate[] hostNameSslStates { get; set; }
        public object computeMode { get; set; }
        public object serverFarm { get; set; }
        public string serverFarmId { get; set; }
        public bool reserved { get; set; }
        public bool isXenon { get; set; }
        public bool hyperV { get; set; }
        public DateTime lastModifiedTimeUtc { get; set; }
        public string storageRecoveryDefaultState { get; set; }
        public string contentAvailabilityState { get; set; }
        public string runtimeAvailabilityState { get; set; }
        public bool vnetRouteAllEnabled { get; set; }
        public AppServicesSiteconfig siteConfig { get; set; }
        public string deploymentId { get; set; }
        public object slotName { get; set; }
        public object trafficManagerHostNames { get; set; }
        public string sku { get; set; }
        public bool scmSiteAlsoStopped { get; set; }
        public object targetSwapSlot { get; set; }
        public object hostingEnvironment { get; set; }
        public object hostingEnvironmentProfile { get; set; }
        public bool clientAffinityEnabled { get; set; }
        public bool clientCertEnabled { get; set; }
        public string clientCertMode { get; set; }
        public object clientCertExclusionPaths { get; set; }
        public bool hostNamesDisabled { get; set; }
        public object domainVerificationIdentifiers { get; set; }
        public string customDomainVerificationId { get; set; }
        public string kind { get; set; }
        public string inboundIpAddress { get; set; }
        public string possibleInboundIpAddresses { get; set; }
        public string ftpUsername { get; set; }
        public string ftpsHostName { get; set; }
        public string outboundIpAddresses { get; set; }
        public string possibleOutboundIpAddresses { get; set; }
        public int containerSize { get; set; }
        public int dailyMemoryTimeQuota { get; set; }
        public object suspendedTill { get; set; }
        public int siteDisabledReason { get; set; }
        public object functionExecutionUnitsCache { get; set; }
        public object maxNumberOfWorkers { get; set; }
        public string homeStamp { get; set; }
        public object cloningInfo { get; set; }
        public object hostingEnvironmentId { get; set; }
        public AppServicesTags1 tags { get; set; }
        public string resourceGroup { get; set; }
        public string defaultHostName { get; set; }
        public object slotSwapStatus { get; set; }
        public bool httpsOnly { get; set; }
        public string redundancyMode { get; set; }
        public object inProgressOperationId { get; set; }
        public object geoDistributions { get; set; }
        public object privateEndpointConnections { get; set; }
        public object publicNetworkAccess { get; set; }
        public object buildVersion { get; set; }
        public object targetBuildVersion { get; set; }
        public object migrationState { get; set; }
        public string eligibleLogCategories { get; set; }
        public bool storageAccountRequired { get; set; }
        public object virtualNetworkSubnetId { get; set; }
        public string keyVaultReferenceIdentity { get; set; }
    }

    public class AppServicesSiteproperties
    {
        public object metadata { get; set; }
        public AppServicesProperty1[] properties { get; set; }
        public object appSettings { get; set; }
    }

    public class AppServicesProperty1
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class AppServicesSiteconfig
    {
        public int numberOfWorkers { get; set; }
        public object defaultDocuments { get; set; }
        public object netFrameworkVersion { get; set; }
        public object phpVersion { get; set; }
        public object pythonVersion { get; set; }
        public object nodeVersion { get; set; }
        public object powerShellVersion { get; set; }
        public string linuxFxVersion { get; set; }
        public object windowsFxVersion { get; set; }
        public object requestTracingEnabled { get; set; }
        public object remoteDebuggingEnabled { get; set; }
        public object remoteDebuggingVersion { get; set; }
        public object httpLoggingEnabled { get; set; }
        public object azureMonitorLogCategories { get; set; }
        public bool acrUseManagedIdentityCreds { get; set; }
        public object acrUserManagedIdentityID { get; set; }
        public object logsDirectorySizeLimit { get; set; }
        public object detailedErrorLoggingEnabled { get; set; }
        public object publishingUsername { get; set; }
        public object publishingPassword { get; set; }
        public object appSettings { get; set; }
        public object metadata { get; set; }
        public object connectionStrings { get; set; }
        public object machineKey { get; set; }
        public object handlerMappings { get; set; }
        public object documentRoot { get; set; }
        public object scmType { get; set; }
        public object use32BitWorkerProcess { get; set; }
        public object webSocketsEnabled { get; set; }
        public bool alwaysOn { get; set; }
        public object javaVersion { get; set; }
        public object javaContainer { get; set; }
        public object javaContainerVersion { get; set; }
        public object appCommandLine { get; set; }
        public object managedPipelineMode { get; set; }
        public object virtualApplications { get; set; }
        public object winAuthAdminState { get; set; }
        public object winAuthTenantState { get; set; }
        public object customAppPoolIdentityAdminState { get; set; }
        public object customAppPoolIdentityTenantState { get; set; }
        public object runtimeADUser { get; set; }
        public object runtimeADUserPassword { get; set; }
        public object loadBalancing { get; set; }
        public object routingRules { get; set; }
        public object experiments { get; set; }
        public object limits { get; set; }
        public object autoHealEnabled { get; set; }
        public object autoHealRules { get; set; }
        public object tracingOptions { get; set; }
        public object vnetName { get; set; }
        public object vnetRouteAllEnabled { get; set; }
        public object vnetPrivatePortsCount { get; set; }
        public object publicNetworkAccess { get; set; }
        public object cors { get; set; }
        public object push { get; set; }
        public object apiDefinition { get; set; }
        public object apiManagementConfig { get; set; }
        public object autoSwapSlotName { get; set; }
        public object localMySqlEnabled { get; set; }
        public object managedServiceIdentityId { get; set; }
        public object xManagedServiceIdentityId { get; set; }
        public object keyVaultReferenceIdentity { get; set; }
        public object ipSecurityRestrictions { get; set; }
        public object scmIpSecurityRestrictions { get; set; }
        public object scmIpSecurityRestrictionsUseMain { get; set; }
        public bool http20Enabled { get; set; }
        public object minTlsVersion { get; set; }
        public object minTlsCipherSuite { get; set; }
        public object supportedTlsCipherSuites { get; set; }
        public object scmMinTlsVersion { get; set; }
        public object ftpsState { get; set; }
        public object preWarmedInstanceCount { get; set; }
        public int functionAppScaleLimit { get; set; }
        public object healthCheckPath { get; set; }
        public object fileChangeAuditEnabled { get; set; }
        public object functionsRuntimeScaleMonitoringEnabled { get; set; }
        public object websiteTimeZone { get; set; }
        public int minimumElasticInstanceCount { get; set; }
        public object azureStorageAccounts { get; set; }
        public object http20ProxyFlag { get; set; }
        public object sitePort { get; set; }
        public object antivirusScanEnabled { get; set; }
        public object storageType { get; set; }
    }

    public class AppServicesTags1
    {
        public string hiddenlinkappinsightsresourceid { get; set; }
        public string hiddenlinkappinsightsinstrumentationkey { get; set; }
        public string hiddenlinkappinsightsconnstring { get; set; }
    }

    public class AppServicesHostnamesslstate
    {
        public string name { get; set; }
        public string sslState { get; set; }
        public object ipBasedSslResult { get; set; }
        public object virtualIP { get; set; }
        public object thumbprint { get; set; }
        public object toUpdate { get; set; }
        public object toUpdateIpBasedSsl { get; set; }
        public string ipBasedSslState { get; set; }
        public string hostType { get; set; }
    }

    public class AppServicesIdentity
    {
        public string type { get; set; }
        public string tenantId { get; set; }
        public string principalId { get; set; }
    }

}
