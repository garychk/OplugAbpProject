using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OplugAbpProject.Authorization;

namespace OplugAbpProject
{
    [DependsOn(
        typeof(OplugAbpProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OplugAbpProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OplugAbpProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OplugAbpProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
