﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [MaxLength(50)]
        public string SubTitle { get; set; }
        [Column(TypeName = "text")]
        public string Contents { get; set; }
        public DateTime CreationTime { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [MaxLength(500)]
        public string Tags { get; set; }
        [DefaultValue(0)]
        public long Hits { get; set; }
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
        public DateTime? LastModificationTime { get; set; }
    }
}
