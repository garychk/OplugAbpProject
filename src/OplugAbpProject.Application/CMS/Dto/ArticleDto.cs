using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace OplugAbpProject.CMS.Dto
{
    [AutoMapFrom(typeof(Article))]
    public class ArticleDto : EntityDto<long>
    {
    }
}
