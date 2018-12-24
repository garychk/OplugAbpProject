using System.Threading.Tasks;
using OplugAbpProject.Configuration.Dto;

namespace OplugAbpProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
