using System.Threading.Tasks;
using Abp.Application.Services;
using GutenBerg.MrGut.Sessions.Dto;

namespace GutenBerg.MrGut.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
