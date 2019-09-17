using System.Collections.Generic;

namespace ThinkAcademy.ZapZap.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
