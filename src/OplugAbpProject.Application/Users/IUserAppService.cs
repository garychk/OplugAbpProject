using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OplugAbpProject.Roles.Dto;
using OplugAbpProject.Users.Dto;

namespace OplugAbpProject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
