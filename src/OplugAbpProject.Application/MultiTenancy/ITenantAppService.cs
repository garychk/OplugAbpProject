using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OplugAbpProject.MultiTenancy.Dto;

namespace OplugAbpProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
