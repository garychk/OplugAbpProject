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
    public class MembersAppService : AsyncCrudAppService<Members, MembersDto, long, PagedResultRequestDto, CreateMembersDto, MembersDto>, IMembersAppService
    {
        private readonly IObjectMapper _objectMapper;

        public MembersAppService(IRepository<Members, long> repository, IObjectMapper objectMapper): base(repository)
        {
            _objectMapper = objectMapper;
            AbpSession = NullAbpSession.Instance;
        }
    }
}
