using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.CMS
{
    [Table("Members")]
    public class Members : Entity<long>, IHasCreationTime, ICreationAudited, IMustHaveTenant
    {
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public int TenantId { get; set; }
        [MaxLength(500)]
        public string Photo { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(50)]
        public string Province { get; set; }
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(50)]
        public string District { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string QQ { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(20)]
        public string Fax { get; set; }
        [MaxLength(20)]
        public string Mobile { get; set; }
        [MaxLength(8)]
        public string Sex { get; set; }
        public DateTime? Birthday { get; set; }
        [MaxLength(20)]
        public string QQOpenID { get; set; }
        [MaxLength(20)]
        public string WXOpenID { get; set; }
        [DefaultValue(0)]
        public long Points { get; set; }
        [MaxLength(50)]
        public string IDNum { get; set; }
        [MaxLength(20)]
        public string Zipcode { get; set; }
    }
}
