using XassCorePlatform.IdentityService.Localization;
using Volo.Abp.Application.Services;

namespace XassCorePlatform.IdentityService;

public abstract class IdentityServiceAppService : ApplicationService
{
    protected IdentityServiceAppService()
    {
        LocalizationResource = typeof(IdentityServiceResource);
        ObjectMapperContext = typeof(IdentityServiceApplicationModule);
    }
}
