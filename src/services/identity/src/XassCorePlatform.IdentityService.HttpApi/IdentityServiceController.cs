using XassCorePlatform.IdentityService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace XassCorePlatform.IdentityService;

public abstract class IdentityServiceController : AbpControllerBase
{
    protected IdentityServiceController()
    {
        LocalizationResource = typeof(IdentityServiceResource);
    }
}
