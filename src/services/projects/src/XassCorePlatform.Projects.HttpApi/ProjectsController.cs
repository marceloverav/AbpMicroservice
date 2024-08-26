using XassCorePlatform.Projects.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace XassCorePlatform.Projects;

public abstract class ProjectsController : AbpControllerBase
{
    protected ProjectsController()
    {
        LocalizationResource = typeof(ProjectsResource);
    }
}
