using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OplugAbpProject.EntityFrameworkCore
{
    public static class OplugAbpProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OplugAbpProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OplugAbpProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
