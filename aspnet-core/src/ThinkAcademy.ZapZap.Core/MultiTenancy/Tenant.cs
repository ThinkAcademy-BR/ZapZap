using Abp.MultiTenancy;
using ThinkAcademy.ZapZap.Authorization.Users;

namespace ThinkAcademy.ZapZap.MultiTenancy
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
