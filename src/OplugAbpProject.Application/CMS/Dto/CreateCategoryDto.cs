using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OplugAbpProject.CMS.Dto
{
    [AutoMapTo(typeof(Category))]
    public class CreateCategoryDto : EntityDto<long>
    {
        [Required, MaxLength(50)]
        public string CategoryName { get; set; }
        [Required, MaxLength(50)]
        public string CategoryIndex { get; set; }
        [Required, MaxLength(50)]
        public string Layout { get; set; }
        [Required, DefaultValue(0)]
        public int ParentId { get; set; }
        [Required]
        public bool IsHide { get; set; }
        [MaxLength(50)]
        public string Icons { get; set; }
        [MaxLength(500)]
        public string LinkUrl { get; set; }
        [Column(TypeName = "text")]
        public string Intro { get; set; }
        public bool IsDeleted { get; set; }
    }
}
