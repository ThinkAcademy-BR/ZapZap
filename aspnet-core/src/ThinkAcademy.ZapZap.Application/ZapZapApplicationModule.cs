using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkAcademy.ZapZap.Authorization;

namespace ThinkAcademy.ZapZap
{
    [DependsOn(
        typeof(ZapZapCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ZapZapApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ZapZapAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ZapZapApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
