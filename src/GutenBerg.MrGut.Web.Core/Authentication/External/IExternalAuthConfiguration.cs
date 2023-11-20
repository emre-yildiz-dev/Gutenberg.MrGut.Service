using System.Collections.Generic;

namespace GutenBerg.MrGut.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
