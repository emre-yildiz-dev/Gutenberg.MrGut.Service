using Abp.MultiTenancy;
using GutenBerg.MrGut.Authorization.Users;

namespace GutenBerg.MrGut.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
