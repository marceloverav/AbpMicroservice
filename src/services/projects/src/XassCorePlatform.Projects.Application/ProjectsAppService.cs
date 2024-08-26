using XassCorePlatform.Projects.Localization;
using Volo.Abp.Application.Services;

namespace XassCorePlatform.Projects;

public abstract class ProjectsAppService : ApplicationService
{
    protected ProjectsAppService()
    {
        LocalizationResource = typeof(ProjectsResource);
        ObjectMapperContext = typeof(ProjectsApplicationModule);
    }
}
