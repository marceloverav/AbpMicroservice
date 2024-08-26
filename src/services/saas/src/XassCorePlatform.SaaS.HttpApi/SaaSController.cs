using XassCorePlatform.SaaS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace XassCorePlatform.SaaS;

public abstract class SaaSController : AbpControllerBase
{
    protected SaaSController()
    {
        LocalizationResource = typeof(SaaSResource);
    }
}
