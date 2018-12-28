using OplugAbpProject.CMS;
using OplugAbpProject.CMS.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OplugAbpProject.Tests.CMS
{
    public class ArticleAppService_Tests: OplugAbpProjectTestBase
    {
        private readonly IArticleAppService _articleAppService;

        public ArticleAppService_Tests()
        {
            _articleAppService = Resolve<IArticleAppService>();
        }

        [Fact]
        public async  Task GetListsAsync()
        {
           var resp = await _articleAppService.GetListsAsync();
        }

        [Fact]
        public async Task CreateOrUpdateAsync()
        {
            CreateArticleDto input = new CreateArticleDto();
            input.CategoryId = 0;
            input.Contents = "test";
            input.Title = "test";
            await _articleAppService.CreateOrUpdateAsync(input);
        }
    }
}
