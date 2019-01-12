using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OplugAbpProject.MultiTenancy.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OplugAbpProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
        Task<List<TenantDto>> GetLists(int SkipCount, int MaxResultCount);
    }
}
