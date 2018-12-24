using System.Threading.Tasks;
using Abp.Application.Services;
using OplugAbpProject.Authorization.Accounts.Dto;

namespace OplugAbpProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
