using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("ResourceType")]
    public partial class ResourceType : Entity<int>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [StringLength(8)]
        public string ResourceTypeID { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        public bool Inactive { get; set; }

        [Required]
        [StringLength(8)]
        public string ExternalMESType { get; set; }
        public int TenantId { get; set; }
    }
}
