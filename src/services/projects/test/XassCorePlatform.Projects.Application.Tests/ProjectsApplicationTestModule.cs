using Volo.Abp.Modularity;

namespace XassCorePlatform.Projects;

[DependsOn(
    typeof(ProjectsApplicationModule),
    typeof(ProjectsDomainTestModule)
    )]
public class ProjectsApplicationTestModule : AbpModule
{

}
