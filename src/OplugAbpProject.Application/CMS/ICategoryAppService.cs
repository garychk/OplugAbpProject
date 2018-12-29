﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OplugAbpProject.CMS.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OplugAbpProject.CMS
{
    public interface ICategoryAppService : IAsyncCrudAppService<CategoryDto, long, PagedResultRequestDto, CreateCategoryDto, CategoryDto>
    {
    }
}
