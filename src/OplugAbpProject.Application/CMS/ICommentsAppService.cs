using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OplugAbpProject.CMS.Dto;

namespace OplugAbpProject.CMS
{
    public interface ICommentsAppService : IAsyncCrudAppService<CommentsDto, long, PagedResultRequestDto, CreateCommentsDto, CommentsDto>
    {
    }
}
