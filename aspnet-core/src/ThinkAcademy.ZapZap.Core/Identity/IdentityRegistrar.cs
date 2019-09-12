using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ThinkAcademy.ZapZap.Authorization;
using ThinkAcademy.ZapZap.Authorization.Roles;
using ThinkAcademy.ZapZap.Authorization.Users;
using ThinkAcademy.ZapZap.Editions;
using ThinkAcademy.ZapZap.MultiTenancy;

namespace ThinkAcademy.ZapZap.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
