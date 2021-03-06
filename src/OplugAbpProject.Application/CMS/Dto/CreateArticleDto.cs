﻿using Abp.Application.Services.Dto;
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
        [MaxLength(50)]
        public string SubTitle { get; set; }
        [Column(TypeName = "text")]
        public string Contents { get; set; }
        public long? CreatorUserId { get; set; }
        public int TenantId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [MaxLength(500)]
        public string Tags { get; set; }        
        public bool IsTop { get; set; }
        public bool IsRec { get; set; }
        public bool IsHot { get; set; }
        [MaxLength(50)]
        public string Author { get; set; }
        [MaxLength(500)]
        public string ImageUrl { get; set; }
        [MaxLength(500)]
        public string FileUrl { get; set; }
        [MaxLength(500)]
        public string VideoUrl { get; set; }
        [MaxLength(500)]
        public string Summary { get; set; }
        public DateTime? EndTime { get; set; }
        [Column(TypeName = "text")]
        public string ExtendAttr { get; set; }
    }
}
