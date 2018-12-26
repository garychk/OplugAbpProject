using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OplugAbpProject.CMS
{
    [Table("Article")]
    public class Article : Entity<long>, IHasCreationTime, ICreationAudited,IMustHaveTenant
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
