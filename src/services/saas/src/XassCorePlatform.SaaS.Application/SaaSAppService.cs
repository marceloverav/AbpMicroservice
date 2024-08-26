using XassCorePlatform.SaaS.Localization;
using Volo.Abp.Application.Services;

namespace XassCorePlatform.SaaS;

public abstract class SaaSAppService : ApplicationService
{
    protected SaaSAppService()
    {
        LocalizationResource = typeof(SaaSResource);
        ObjectMapperContext = typeof(SaaSApplicationModule);
    }
}
