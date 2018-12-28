using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using Abp.Runtime.Session;
using OplugAbpProject.CMS.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OplugAbpProject.CMS
{
    public class ArticleAppService : AsyncCrudAppService<Article, ArticleDto, long, PagedResultRequestDto, CreateArticleDto, ArticleDto>, IArticleAppService
    {
        private readonly IObjectMapper _objectMapper;

        public ArticleAppService(IRepository<Article, long> repository, IObjectMapper objectMapper) : base(repository)
        {
            _objectMapper = objectMapper;
            AbpSession = NullAbpSession.Instance;
        }
        public async Task<List<ArticleDto>> GetListsAsync()
        {
            List<ArticleDto> datas = new List<ArticleDto>();
            var result = await Repository.GetAllListAsync(o => o.TenantId == AbpSession.TenantId.Value);            
            return _objectMapper.Map(result, datas);
        }

        public async Task CreateOrUpdateAsync(CreateArticleDto input)
        {            
            var obj = ObjectMapper.Map<Article>(input);
            obj.TenantId = AbpSession.TenantId.Value;
            obj.CreatorUserId = AbpSession.UserId;
            obj.CreationTime = DateTime.Now;
            await Repository.InsertAndGetIdAsync(obj);
        }

    }
}
