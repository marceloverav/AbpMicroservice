using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;

namespace XassCorePlatform.SaaS;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(SaaSDomainSharedModule)
)]
[DependsOn(typeof(AbpTenantManagementDomainModule))]
public class SaaSDomainModule : AbpModule
{
}
