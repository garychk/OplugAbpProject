using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.CMS
{
    [Table("Comments")]
    public class Comments : Entity<long>, IHasCreationTime, ICreationAudited, IMustHaveTenant
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
