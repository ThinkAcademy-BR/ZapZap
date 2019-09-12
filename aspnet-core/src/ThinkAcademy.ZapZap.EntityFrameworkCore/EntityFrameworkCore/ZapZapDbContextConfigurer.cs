using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ThinkAcademy.ZapZap.EntityFrameworkCore
{
    public static class ZapZapDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ZapZapDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ZapZapDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
