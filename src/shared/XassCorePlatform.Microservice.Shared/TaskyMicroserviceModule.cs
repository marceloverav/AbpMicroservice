using XassCorePlatform.Administration.EntityFrameworkCore;
using XassCorePlatform.Hosting.Shared;
using Volo.Abp.Modularity;

namespace XassCorePlatform.Microservice.Shared;

[DependsOn(
    typeof(XassCorePlatformHostingModule),
    typeof(AdministrationEntityFrameworkCoreModule)
)]
public class XassCorePlatformMicroserviceModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    }
}
