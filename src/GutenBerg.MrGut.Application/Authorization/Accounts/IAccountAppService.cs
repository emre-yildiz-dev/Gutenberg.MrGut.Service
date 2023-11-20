using System.Threading.Tasks;
using Abp.Application.Services;
using GutenBerg.MrGut.Authorization.Accounts.Dto;

namespace GutenBerg.MrGut.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
