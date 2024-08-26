using Volo.Abp.Reflection;

namespace XassCorePlatform.Projects.Permissions;

public class ProjectsPermissions
{
    public const string GroupName = "Projects";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProjectsPermissions));
    }
}
