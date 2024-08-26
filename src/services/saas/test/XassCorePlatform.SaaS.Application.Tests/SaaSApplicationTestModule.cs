using Volo.Abp.Modularity;

namespace XassCorePlatform.SaaS;

[DependsOn(
    typeof(SaaSApplicationModule),
    typeof(SaaSDomainTestModule)
    )]
public class SaaSApplicationTestModule : AbpModule
{

}
