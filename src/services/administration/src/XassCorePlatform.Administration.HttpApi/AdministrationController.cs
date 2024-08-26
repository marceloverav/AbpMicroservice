using XassCorePlatform.Administration.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace XassCorePlatform.Administration;

public abstract class AdministrationController : AbpControllerBase
{
    protected AdministrationController()
    {
        LocalizationResource = typeof(AdministrationResource);
    }
}
