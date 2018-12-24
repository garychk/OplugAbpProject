using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OplugAbpProject.Controllers
{
    public abstract class OplugAbpProjectControllerBase: AbpController
    {
        protected OplugAbpProjectControllerBase()
        {
            LocalizationSourceName = OplugAbpProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
