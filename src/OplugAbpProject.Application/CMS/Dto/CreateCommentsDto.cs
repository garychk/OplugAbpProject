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
    [AutoMapTo(typeof(Comments))]
    public class CreateCommentsDto : EntityDto<long>
    {
        public int TenantId { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        [Column(TypeName = "text")]
        public string Contents { get; set; }
        [DefaultValue(0)]
        public long ForeignId { get; set; }
        [DefaultValue(0)]
        public long ParentId { get; set; }
        [DefaultValue(0)]
        public long AgreeCount { get; set; }
        [DefaultValue(0)]
        public long AgainstCount { get; set; }
    }
}
