using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ThinkAcademy.ZapZap.Authorization.Roles;
using ThinkAcademy.ZapZap.Authorization.Users;
using ThinkAcademy.ZapZap.MultiTenancy;

namespace ThinkAcademy.ZapZap.EntityFrameworkCore
{
    public class ZapZapDbContext : AbpZeroDbContext<Tenant, Role, User, ZapZapDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ZapZapDbContext(DbContextOptions<ZapZapDbContext> options)
            : base(options)
        {
        }
    }
}
