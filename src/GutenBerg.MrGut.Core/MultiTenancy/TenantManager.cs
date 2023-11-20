using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using GutenBerg.MrGut.Authorization.Users;
using GutenBerg.MrGut.Editions;

namespace GutenBerg.MrGut.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
