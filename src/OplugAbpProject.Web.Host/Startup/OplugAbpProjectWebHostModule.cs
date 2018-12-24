using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OplugAbpProject.Configuration;

namespace OplugAbpProject.Web.Host.Startup
{
    [DependsOn(
       typeof(OplugAbpProjectWebCoreModule))]
    public class OplugAbpProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OplugAbpProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OplugAbpProjectWebHostModule).GetAssembly());
        }
    }
}
