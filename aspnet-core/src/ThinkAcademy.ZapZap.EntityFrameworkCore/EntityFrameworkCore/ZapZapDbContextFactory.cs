using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ThinkAcademy.ZapZap.Configuration;
using ThinkAcademy.ZapZap.Web;

namespace ThinkAcademy.ZapZap.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ZapZapDbContextFactory : IDesignTimeDbContextFactory<ZapZapDbContext>
    {
        public ZapZapDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ZapZapDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ZapZapDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ZapZapConsts.ConnectionStringName));

            return new ZapZapDbContext(builder.Options);
        }
    }
}
