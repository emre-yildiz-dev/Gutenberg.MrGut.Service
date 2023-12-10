using Abp.Domain.Services;
using Abp.Runtime.Session;

namespace GutenBerg.MrGut.Managers;

public class BaseManager : DomainService
{
    public IAbpSession AbpSession { get; set; }

    public BaseManager()
    {
        LocalizationSourceName = MrGutConsts.LocalizationSourceName;
        AbpSession = NullAbpSession.Instance;
    }
}
