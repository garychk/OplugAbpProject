using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OplugAbpProject.Configuration;
using OplugAbpProject.Web;

namespace OplugAbpProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class OplugAbpProjectDbContextFactory : IDesignTimeDbContextFactory<OplugAbpProjectDbContext>
    {
        public OplugAbpProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OplugAbpProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            OplugAbpProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(OplugAbpProjectConsts.ConnectionStringName));

            return new OplugAbpProjectDbContext(builder.Options);
        }
    }
}
