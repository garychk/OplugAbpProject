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
    public class CommentsAppService : AsyncCrudAppService<Comments, CommentsDto, long, PagedResultRequestDto, CreateCommentsDto, CommentsDto>, ICommentsAppService
    {
        private readonly IObjectMapper _objectMapper;

        public CommentsAppService(IRepository<Comments, long> repository, IObjectMapper objectMapper) : base(repository)
        {
            _objectMapper = objectMapper;
        }
    }
}
