using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OplugAbpProject.ERP
{
    [Table("DMRCorAct")]
    public partial class DMRCorAct : Entity<Guid>, IMustHaveTenant
    {
        [StringLength(8)]
        public string Company { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        [Required]
        public string CommentText { get; set; }

        public int NonConfNum { get; set; }

        [Required]
        [StringLength(75)]
        public string AsigndTo { get; set; }

        [Required]
        [StringLength(75)]
        public string AuditBy { get; set; }

        [Required]
        public string AuditCmts { get; set; }

        [Required]
        public string CauseInv { get; set; }

        [Required]
        [StringLength(8)]
        public string Dept { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOpen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DuDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AuditDt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ActionComp { get; set; }

        public int DMRNum { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ActionID { get; set; }

        [Required]
        [StringLength(8)]
        public string CauseReasonCode { get; set; }

        [Required]
        [StringLength(8)]
        public string CorrectiveActionReasonCode { get; set; }

        public int VendorNum { get; set; }

        public int ConNum { get; set; }
        public int TenantId { get; set; }
    }
}
