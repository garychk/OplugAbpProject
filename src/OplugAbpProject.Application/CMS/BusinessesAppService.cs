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
    public class BusinessesAppService : AsyncCrudAppService<Businesses, BusinessesDto, long, PagedResultRequestDto, CreateBusinessesDto, BusinessesDto>, IBusinessesAppService
    {
        private readonly IObjectMapper _objectMapper;

        public BusinessesAppService(IRepository<Businesses, long> repository, IObjectMapper objectMapper) : base(repository)
        {
            _objectMapper = objectMapper;
        }
    }
}
