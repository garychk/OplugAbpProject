using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OplugAbpProject.CMS.Dto
{
    [AutoMapFrom(typeof(Article))]
    public class ArticleDto : EntityDto<long>
    {
        [Required, MaxLength(50)]
        public string Title { get; set; }
        [Column(TypeName = "text")]
        public string Contents { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public int TenantId { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
