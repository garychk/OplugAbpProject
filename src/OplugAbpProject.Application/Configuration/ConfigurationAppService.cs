using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OplugAbpProject.Configuration.Dto;

namespace OplugAbpProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OplugAbpProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
