using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkAcademy.ZapZap.Configuration;
using ThinkAcademy.ZapZap.EntityFrameworkCore;
using ThinkAcademy.ZapZap.Migrator.DependencyInjection;

namespace ThinkAcademy.ZapZap.Migrator
{
    [DependsOn(typeof(ZapZapEntityFrameworkModule))]
    public class ZapZapMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ZapZapMigratorModule(ZapZapEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ZapZapMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ZapZapConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZapZapMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
