using XassCorePlatform.Projects.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace XassCorePlatform.Projects.Permissions;

public class ProjectsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProjectsPermissions.GroupName, L("Permission:Projects"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProjectsResource>(name);
    }
}
