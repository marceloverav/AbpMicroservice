using XassCorePlatform.Administration.Localization;
using Volo.Abp.Application.Services;

namespace XassCorePlatform.Administration;

public abstract class AdministrationAppService : ApplicationService
{
    protected AdministrationAppService()
    {
        LocalizationResource = typeof(AdministrationResource);
        ObjectMapperContext = typeof(AdministrationApplicationModule);
    }
}
