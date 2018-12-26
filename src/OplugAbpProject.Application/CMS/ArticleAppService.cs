using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using OplugAbpProject.CMS.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OplugAbpProject.CMS
{
    public class ArticleAppService : AsyncCrudAppService<Article, ArticleDto, long, PagedResultRequestDto, CreateArticleDto, ArticleDto>, IArticleAppService
    {
        public ArticleAppService(IRepository<Article, long> repository) : base(repository)
        {

        }
        public async Task<ListResultDto<ArticleDto>> GetListsAsync()
        {
            var result = await Repository.GetAllListAsync();
            return result.MapTo<ListResultDto<ArticleDto>>();
        }
    }
}
