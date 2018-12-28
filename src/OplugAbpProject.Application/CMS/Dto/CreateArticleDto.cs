using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OplugAbpProject.CMS.Dto
{
    [AutoMapTo(typeof(Article))]
    public class CreateArticleDto : EntityDto<long>
    {
        [Required, MaxLength(50)]
        public string Title { get; set; }
        [Column(TypeName = "text")]
        public string Contents { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
