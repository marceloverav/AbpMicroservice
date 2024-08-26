using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace XassCorePlatform.Blazor;

[Dependency(ReplaceServices = true)]
public class XassCorePlatformBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "XassCorePlatform";
}
