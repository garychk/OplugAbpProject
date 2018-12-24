using System.Threading.Tasks;
using Abp.Application.Services;
using OplugAbpProject.Sessions.Dto;

namespace OplugAbpProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
