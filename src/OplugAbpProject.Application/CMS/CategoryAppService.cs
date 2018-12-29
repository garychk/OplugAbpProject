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
    public class CategoryAppService : AsyncCrudAppService<Category, CategoryDto, long, PagedResultRequestDto, CreateCategoryDto, CategoryDto>, ICategoryAppService
    {
        private readonly IObjectMapper _objectMapper;

        public CategoryAppService(IRepository<Category, long> repository, IObjectMapper objectMapper) : base(repository)
        {
            _objectMapper = objectMapper;
            AbpSession = NullAbpSession.Instance;
        }
    }
}
