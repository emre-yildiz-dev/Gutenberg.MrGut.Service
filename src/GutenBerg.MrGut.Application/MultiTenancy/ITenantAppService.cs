using Abp.Application.Services;
using GutenBerg.MrGut.MultiTenancy.Dto;

namespace GutenBerg.MrGut.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

