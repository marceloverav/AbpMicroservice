using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace XassCorePlatform;

[Dependency(ReplaceServices = true)]
public class XassCorePlatformBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "XassCorePlatform";
}
