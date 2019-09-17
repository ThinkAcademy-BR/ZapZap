using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkAcademy.ZapZap.Configuration;

namespace ThinkAcademy.ZapZap.Web.Host.Startup
{
    [DependsOn(
       typeof(ZapZapWebCoreModule))]
    public class ZapZapWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ZapZapWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZapZapWebHostModule).GetAssembly());
        }
    }
}
