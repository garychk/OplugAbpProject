using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OplugAbpProject.CMS.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OplugAbpProject.CMS
{
    public interface IArticleAppService : IAsyncCrudAppService<ArticleDto, long, PagedResultRequestDto, CreateArticleDto, ArticleDto>
    {
        Task<List<ArticleDto>> GetListsAsync(int SkipCount, int MaxResultCount);
        Task<long> CreateOrUpdateAsync(CreateArticleDto input);
    }
}
