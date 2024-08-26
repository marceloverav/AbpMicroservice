using XassCorePlatform.Administration;
using XassCorePlatform.Administration.EntityFrameworkCore;
using XassCorePlatform.IdentityService;
using XassCorePlatform.IdentityService.EntityFrameworkCore;
using XassCorePlatform.Microservice.Shared;
using XassCorePlatform.SaaS;
using XassCorePlatform.SaaS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace XassCorePlatform.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdministrationEntityFrameworkCoreModule),
    typeof(AdministrationApplicationContractsModule),
    typeof(IdentityServiceEntityFrameworkCoreModule),
    typeof(IdentityServiceApplicationContractsModule),
    typeof(SaaSEntityFrameworkCoreModule),
    typeof(SaaSApplicationContractsModule)
)]
public class XassCorePlatformDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
