using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
