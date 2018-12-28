using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.CMS
{
    [Table("Businesses")]
    public class Businesses : Entity<long>, IHasCreationTime, ICreationAudited, IMustHaveTenant, IHasModificationTime
    {
        [Required, MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string SubTitle { get; set; }
        [Column(TypeName = "text")]
        public string Contents { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [MaxLength(500)]
        public string Tags { get; set; }
        [DefaultValue(0)]
        public long Hits { get; set; }
        [MaxLength(500)]
        public string ImageUrl { get; set; }
        [MaxLength(500)]
        public string FileUrl { get; set; }
        [MaxLength(500)]
        public string VideoUrl { get; set; }
        [DefaultValue(0)]
        public decimal longitude { get; set; }
        [DefaultValue(0)]
        public decimal latitude { get; set; }
        [DefaultValue(0)]
        public decimal Price { get; set; }
        [MaxLength(50)]
        public string VendName { get; set; }
        [MaxLength(50)]
        public string Telphone { get; set; }
        [MaxLength(50)]
        public string Contactor { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(500)]
        public string Summary { get; set; }
        [Column(TypeName = "text")]
        public string ExtendAttr { get; set; }
        public long? CreatorUserId { get; set; }        
        public int TenantId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
