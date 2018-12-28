using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.CMS
{
    [Table("Category")]
    public class Category : Entity<long>, ICreationAudited, IMustHaveTenant, ISoftDelete
    {
        [Required, MaxLength(50)]
        public string CategoryName { get; set; }
        [Required, MaxLength(50)]
        public string CategoryIndex { get; set; }
        [Required, MaxLength(50)]
        public string Layout { get; set; }
        [Required, DefaultValue(0)]
        public int ParentId { get; set; }
        [Required, DefaultValue(0)]
        public int Childs { get; set; }
        [Required, DefaultValue(0)]
        public int Level { get; set; }
        [Required]
        public bool IsHide { get; set; }
        [MaxLength(50)]
        public string Icons { get; set; }
        [MaxLength(500)]
        public string LinkUrl { get; set; }
        [Column(TypeName = "text")]
        public string Intro { get; set; }
        public long? CreatorUserId { get; set; }
        public int TenantId { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
